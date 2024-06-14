using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Threading;

namespace GUIsf
{
    public enum States : int
    {
        None, Command, CR 
    }

    class RS232
    {
        private string message = null;
        private SerialPort serialPort = new SerialPort();
        private FormRobot RobotMain = null;
        private Boolean isConnected = false;
        private ConcurrentQueue<char> serialDataQueue = new ConcurrentQueue<char>();
        public string comstr;
        public string OutputText = null;
        public string recvcomm = null;
        //Define other variables here too
        private Boolean isStatusReceived = false;
        private delegate void displayDelegate(string x);
        displayDelegate displayFunction;
        private delegate void replenishDelegate(string x);
        replenishDelegate replenishFunction;

        public RS232()
        {
            replenishFunction = clearText;
            displayFunction = displayText;
            serialPort.ReadTimeout = 200;
            serialPort.WriteTimeout = 200;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }
        public string RecvComm
        {
            get { return comstr; }
            set { comstr = value; }

        }
        public string setPortName
        {
            get { return serialPort.PortName; }
            set { serialPort.PortName=value; }
        }
        public int setBaudRate
        {
            get { return serialPort.BaudRate; }
            set { serialPort.BaudRate = value; }
        }
        public int setDataBits
        {
            get { return serialPort.DataBits; }
            set { serialPort.DataBits = value; }
        }

        public void setParity(string parity)
        {
            serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), parity);
        }

        public void setStopBits()
        {
            serialPort.StopBits = StopBits.One;
        }

        public void Connect()
        {
            if (!isConnected)
            {
                serialPort.RtsEnable = false;
                serialPort.DtrEnable = true;
                serialPort.Open();
                isConnected = true;
              

            }


        }
        public void Disconnect()
        {
            if (isConnected)
            {
                Thread closedown = new Thread(new ThreadStart(CloseSerialPort));
                closedown.Start();
                isConnected = false;
            }

        }

        private void CloseSerialPort()
        {
            try
            {
                serialPort.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                message = serialPort.ReadLine();
                Thread commextract = new Thread(new ThreadStart(ExtractCommand));
                commextract.Start();
                if (message != "")
                    displayFunction(message);

            }
            catch (TimeoutException) { MessageBox.Show("OutputText Write Failed in ReadSerialDataQueue", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void displayText(string x)
        {
            OutputText += DateTime.Now + " " + x + "\n";
        }

        private void clearText(string x)
        {

            recvcomm = x;
            
        }
        public string GetRecvcomm()
        {
            return recvcomm;
        }

        private void ExtractCommand()
        {

            State status = State.None;
            try
            {
                for (int index = 0; index < message.Length; index++)
                {
                    serialDataQueue.Enqueue(message[index]);
                    isStatusReceived = true;

                    if (status == State.None && (message[index] == '\u0002'))
                    {
                        status = State.Command;
                        continue;
                    }

                    if (status == State.Command && (message[index] != '\r'))
                    {
                        status = State.Command;
                        comstr += message[index];
                        continue;
                    }
                    else if (status == State.Command)
                    {
                        status = State.CR;
                    }
                    if (status == State.CR && (message[index] == '\r'))
                    {

                        replenishFunction(comstr);
                        comstr = null;
                        continue;
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Extract Command is failed in COMMapp", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void SendData(string sendcomm)
        {
            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;
            string command = null;
            Thread.Sleep(15);

            if (isStatusReceived)
            {
                command = sendcomm;
                byte[] STX = new byte[] { 0x02 };
                byte[] CRLF = new byte[] { 0x0d, 0x0a, 0x0a };
                char[] comm = command.ToCharArray();
                serialPort.Write(STX, 0, 1);
                serialPort.Write(comm, 0, comm.Length);
                serialPort.Write(CRLF, 0, CRLF.Length);
                isStatusReceived = false;
            }
            serialPort.RtsEnable = false;
            serialPort.DtrEnable = true;
        }
    }
}
