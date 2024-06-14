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
    public enum State : int
    {
        None, Command, CR
    }


    public partial class RS232Form : Form
    {
        private string message=null;
        private SerialPort serialPort = new SerialPort();
        private Robot RobotMain = null;
        private Boolean isConnected = false;
        private ConcurrentQueue<char> serialDataQueue = new ConcurrentQueue<char>();
        public string comstr;
        private Boolean isStatusReceived = false;
        private delegate void displayDelegate(string x);
        displayDelegate displayFunction;
        private delegate void replenishDelegate(string x);
        replenishDelegate replenishFunction;


        public RS232Form()
        {
            InitializeComponent();

        }

        public RS232Form(Form robotmain)
        {
            RobotMain= robotmain as Robot;
            InitializeComponent();
            replenishFunction = clearText;
            displayFunction = displayText;

            //serialPort.ReadBufferSize = 12;

            groupBox1.ForeColor = Color.White;
            OutputGroup.ForeColor = Color.White;

            PortCombo.Items.AddRange(SerialPort.GetPortNames());
            PortCombo.SelectedIndex = 0;

            BaudCombo.Items.Add(9600);
            BaudCombo.SelectedIndex = BaudCombo.Items.Count - 1;
            BaudCombo.Items.Add(14400);
            BaudCombo.SelectedIndex = BaudCombo.Items.Count - 1;
            BaudCombo.Items.Add(19200);
            BaudCombo.SelectedIndex = BaudCombo.Items.Count - 1;
            BaudCombo.Items.Add(38400);
            BaudCombo.SelectedIndex = BaudCombo.Items.Count - 1;
            BaudCombo.Items.Add(57600);
            BaudCombo.SelectedIndex = BaudCombo.Items.Count - 1;
            BaudCombo.Items.Add(115200);
            BaudCombo.SelectedIndex = 2;


            DataCombo.Items.Add(5);
            DataCombo.SelectedIndex = DataCombo.Items.Count - 1;
            DataCombo.Items.Add(6);
            DataCombo.SelectedIndex = DataCombo.Items.Count - 1;
            DataCombo.Items.Add(7);
            DataCombo.SelectedIndex = DataCombo.Items.Count - 1;
            DataCombo.Items.Add(8);
            DataCombo.SelectedIndex = DataCombo.Items.Count - 1;

            ParityCombo.Items.Add(Parity.None);
            ParityCombo.SelectedIndex = ParityCombo.Items.Count - 1;
            ParityCombo.Items.Add(Parity.Even);
            ParityCombo.SelectedIndex = ParityCombo.Items.Count - 1;
            ParityCombo.Items.Add(Parity.Odd);
            ParityCombo.SelectedIndex = ParityCombo.Items.Count - 1;
            ParityCombo.Items.Add(Parity.Mark);
            ParityCombo.SelectedIndex = ParityCombo.Items.Count - 1;
            ParityCombo.Items.Add(Parity.Space);
            ParityCombo.SelectedIndex = 0;

            StopCombo.Items.Add(StopBits.One);
            StopCombo.SelectedIndex = StopCombo.Items.Count - 1;

            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            ConnectButton.BackColor = Color.Red;


        }
        public string RecvComm
        {
            get { return comstr; }
            set { comstr = value; }
        }

        private void CloseSerialPort()
        {
            try
            {
                serialPort.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
            if (OutputText.InvokeRequired)
            {
                OutputText.Invoke(displayFunction, new object[] { x });
            }
            else
            {
                if (OutputText.Lines.Length > 20)
                {
                    OutputText.Clear();
                }
                OutputText.Text += DateTime.Now + " " + x + "\n";
            }
        }

        private void OutputText_TextChanged(object sender, EventArgs e)
        {
            OutputText.SelectionStart = OutputText.Text.Length;
            OutputText.ScrollToCaret();

        }
        private void clearText(string x)
        {
            if (txtrecvcomm.InvokeRequired)
            {
                txtrecvcomm.Invoke(replenishFunction, new object[] { x });

            }
            else
            {
                txtrecvcomm.Text = x;
                this.RobotMain.TextBoxText = x;
            }
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
            string command=null;
            Thread.Sleep(15);

            if (isStatusReceived)
            {
                if (senddatatxtbox.Text == null)
                {
                    command = sendcomm;
                }
                else if(sendcomm==null)
                {
                    command = senddatatxtbox.Text;
                }
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

       
        private void ConnectButton_Click_1(object sender, EventArgs e)
        {
            OutputText.Text = null;


            if (isConnected)
            {
                Thread closedown = new Thread(new ThreadStart(CloseSerialPort));
                closedown.Start();
                ConnectButton.Text = "Connect";
                ConnectButton.BackColor = Color.Red;
                isConnected = false;
                OutputGroup.Enabled = false;
            }
            else
            {
                serialPort.PortName = PortCombo.Text;
                serialPort.BaudRate = Convert.ToInt32(BaudCombo.Text);
                serialPort.DataBits = Convert.ToInt32(DataCombo.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), ParityCombo.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), StopCombo.Text);

                serialPort.ReadTimeout = 200;
                serialPort.WriteTimeout = 200;

                serialPort.RtsEnable = false;
                serialPort.DtrEnable = true;

                serialPort.Open();

                ConnectButton.Text = "Disconnect";
                ConnectButton.BackColor = Color.Green;
                isConnected = true;
                OutputGroup.Enabled = true;

            }
        }

        private void sendata_Click_1(object sender, EventArgs e)
        {
            string sendcomm = null;
            SendData(sendcomm);
        }
    }
}
