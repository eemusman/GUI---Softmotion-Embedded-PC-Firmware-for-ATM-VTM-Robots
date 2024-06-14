using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMX3ApiCLR;


namespace GUIsf
{
    public enum Hand : int
    {
        A=0, B, C, D, L,R,T,Z
    }

    public partial class Robot : Form
    {
        //Forms Communication
        private MainGUI MainForm = null;
        private RS232Form TPComm= null;

        //Serial Communication 

        RS232 serialcomm = new RS232();
        //Check Variables
        string SelectedAxis = null;

        //delegate 
        public delegate void UpdateDataGrid(string label);
        public bool IsCancelled { get; set; }
        Thread t;

        string[] str = new string[12];
        string[] str1;
        Softmotion[] softmotion = new Softmotion[Softmotion.MAXUSMANMOTOR];
        int lastaxisno=-1;
        
        public Robot()
        {
            InitializeComponent();
            Softmotion.Alloc();
            for (int i = 0; i < Softmotion.MAXUSMANMOTOR; i++)
            {
                softmotion[i] = Softmotion.softmotions[i];
            }
            DoubleBuffered = true;
            axesparameterlist.Columns.Add("axisno", "Axis No");
            axesparameterlist.Columns.Add("name", "Name");
            axesparameterlist.Columns.Add("apos", "Actual Pos");
            axesparameterlist.Columns.Add("cpos", "Comm. Pos");
            axesparameterlist.Columns.Add("maxspd", "MaxSpeed");
            axesparameterlist.Columns.Add("alarm", "LogicALARM");
            axesparameterlist.Columns.Add("servo", "Servo Status");
            axesparameterlist.Columns.Add("busy", "Busy");
            axesparameterlist.Columns.Add("init", "Initialize");
            axesparameterlist.Columns.Add("pot", "POT");
            axesparameterlist.Columns.Add("not", "NOT");
            axesparameterlist.Columns.Add("org", "ORG");

            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            for (int i = 0; i < axesparameterlist.ColumnCount; i++)
            {
                str[i] = axesparameterlist.Columns[i].HeaderText;
            }
            IOFILE iofile = new IOFILE("sample.txt");
            int numberofmotors = iofile.ReadInteger("[jjangMotor]", "NumOfMotor");

            str1 = new string[numberofmotors];
            for (int i = 0; i < numberofmotors; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(axesparameterlist);
                row.Cells[0].Value = i + 1;
                //dataGridView1.Rows.Add();
                //dataGridView1.Rows[i].Cells[0].Value = i + 1;
                str1[i] = "[" + "Axis" + i + "]";
                for (int j = 1; j < axesparameterlist.ColumnCount; j++)
                {

                    string value = iofile.ReadString(str1[i], str[j]);
                    if (value == "false" || value == "true")
                    {
                        if (value == "false")
                        {
                            row.Cells[j].Value = "OFF";
                            row.Cells[j].Style.BackColor = Color.White;
                        }
                        else
                        {
                            row.Cells[j].Value = "ON";
                            row.Cells[j].Style.BackColor = Color.LightGreen;
                        }


                    }
                    else
                    {
                        row.Cells[j].Value = iofile.ReadString(str1[i], str[j]);
                    }

                }
                rows.Add(row);
            }
            axesparameterlist.Rows.AddRange(rows.ToArray());


        }

        public Robot(Form mainguiform)
        {
            InitializeComponent();
            Softmotion.Alloc();
            for (int i = 0; i < Softmotion.MAXUSMANMOTOR; i++)
            {
                softmotion[i] = Softmotion.softmotions[i];
            }
            DoubleBuffered = true;
            axesparameterlist.Columns.Add("axisno", "Axis No");
            axesparameterlist.Columns.Add("name", "Name");
            axesparameterlist.Columns.Add("apos", "Actual Pos");
            axesparameterlist.Columns.Add("cpos", "Comm. Pos");
            axesparameterlist.Columns.Add("maxspd", "MaxSpeed");
            axesparameterlist.Columns.Add("alarm", "LogicALARM");
            axesparameterlist.Columns.Add("servo", "Servo Status");
            axesparameterlist.Columns.Add("busy", "Busy");
            axesparameterlist.Columns.Add("init", "Initialize");
            axesparameterlist.Columns.Add("pot", "POT");
            axesparameterlist.Columns.Add("not", "NOT");
            axesparameterlist.Columns.Add("org", "ORG");

            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            for (int i = 0; i < axesparameterlist.ColumnCount; i++)
            {
                str[i] = axesparameterlist.Columns[i].HeaderText;
            }
            IOFILE iofile = new IOFILE("sample.txt");
            int numberofmotors = iofile.ReadInteger("[jjangMotor]", "NumOfMotor");

            str1 = new string[numberofmotors];
            for (int i = 0; i < numberofmotors; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(axesparameterlist);
                row.Cells[0].Value = i + 1;
                //dataGridView1.Rows.Add();
                //dataGridView1.Rows[i].Cells[0].Value = i + 1;
                str1[i] = "[" + "Axis" + i + "]";
                for (int j = 1; j < axesparameterlist.ColumnCount; j++)
                {

                    string value = iofile.ReadString(str1[i], str[j]);
                    if (value == "false" || value == "true")
                    {
                        if (value == "false")
                        {
                            row.Cells[j].Value = "OFF";
                            row.Cells[j].Style.BackColor = Color.White;
                        }
                        else
                        {
                            row.Cells[j].Value = "ON";
                            row.Cells[j].Style.BackColor = Color.LightGreen;
                        }


                    }
                    else
                    {
                        row.Cells[j].Value = iofile.ReadString(str1[i], str[j]);
                    }

                }
                rows.Add(row);
            }
            axesparameterlist.Rows.AddRange(rows.ToArray());


        }

        public Robot(Form mainguiform,Form commrobot)
        {
            InitializeComponent();
            TPComm = commrobot as RS232Form;
            MainForm = mainguiform as MainGUI;
            

            // Serial Communication
            serialcomm.setPortName = "COM1";
            serialcomm.setBaudRate = 19200;
            serialcomm.setDataBits = 8;
            serialcomm.setParity("None");
            serialcomm.setStopBits();
            //serialcomm.Connect();

            Softmotion.Alloc();
            for (int i = 0; i < Softmotion.MAXUSMANMOTOR; i++)
            {
                softmotion[i] = Softmotion.softmotions[i];
            }
            DoubleBuffered = true;
            axesparameterlist.Columns.Add("axisno", "Axis No");
            axesparameterlist.Columns.Add("name", "Name");
            axesparameterlist.Columns.Add("apos", "Actual Pos");
            axesparameterlist.Columns.Add("cpos", "Comm. Pos");
            axesparameterlist.Columns.Add("maxspd", "MaxSpeed");
            axesparameterlist.Columns.Add("alarm", "LogicALARM");
            axesparameterlist.Columns.Add("servo", "Servo Status");
            axesparameterlist.Columns.Add("busy", "Busy");
            axesparameterlist.Columns.Add("init", "Initialize");
            axesparameterlist.Columns.Add("pot", "POT");
            axesparameterlist.Columns.Add("not", "NOT");
            axesparameterlist.Columns.Add("org", "ORG");

            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            for (int i = 0; i < axesparameterlist.ColumnCount; i++)
            {
                str[i] = axesparameterlist.Columns[i].HeaderText;
            }
            IOFILE iofile = new IOFILE("sample.txt");
            int numberofmotors = iofile.ReadInteger("[jjangMotor]", "NumOfMotor");

            str1 = new string[numberofmotors];
            for (int i = 0; i < numberofmotors; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(axesparameterlist);
                row.Cells[0].Value = i + 1;
                //dataGridView1.Rows.Add();
                //dataGridView1.Rows[i].Cells[0].Value = i + 1;
                str1[i] = "[" + "Axis" + i + "]";
                for (int j = 1; j < axesparameterlist.ColumnCount; j++)
                {

                    string value = iofile.ReadString(str1[i], str[j]);
                    if (value == "false" || value == "true")
                    {
                        if (value == "false")
                        {
                            row.Cells[j].Value = "OFF";
                            row.Cells[j].Style.BackColor = Color.White;
                        }
                        else
                        {
                            row.Cells[j].Value = "ON";
                            row.Cells[j].Style.BackColor = Color.LightGreen;
                        }


                    }
                    else
                    {
                        row.Cells[j].Value = iofile.ReadString(str1[i], str[j]);
                    }

                }
                rows.Add(row);
            }
            axesparameterlist.Rows.AddRange(rows.ToArray());


        }


        private void Robot_Load(object sender, EventArgs e)
        {
            // GUI Update using threading 
            IsCancelled = false;

            t = new Thread(() =>
            {
                int i = 0;
                while (IsCancelled == false)
                {
                    Thread.Sleep(50);
                    string label = null;
                    Softmotion.getstatusupdate();

                    if (!this.IsDisposed)
                    {
                        try
                        {
                            if (axesparameterlist.IsHandleCreated)
                            {
                                axesparameterlist.Invoke(new UpdateDataGrid(UpdateGUI), label);
                            }

                        }
                        catch (Exception exception)
                        {

                        }


                    }
                    else
                    {

                        break;
                    }
                    i++;
                }

            });
            t.Start();

        }
        public string TextBoxText
        {
            get { return textComm.Text; }
            set { textComm.Text = value; }
        }

       
        private void UpdateGUI(string labeltext)
        {
            Thread commthread = new Thread(new ThreadStart(control_tp));
            commthread.Start();
            
            
            axisstatuslabel.Text = axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Value.ToString() + " Selected" + "(" + $"{softmotion[axesparameterlist.CurrentCell.RowIndex].opstate}" + ")";
            axesparameterlist.Rows[0].Cells[2].Value = softmotion[0].ActualPos + " °";
            axesparameterlist.Rows[0].Cells[3].Value =double.Parse(pitchvalue.Text)+ " °";
            axesparameterlist.Rows[1].Cells[2].Value = softmotion[1].ActualPos + " °";
            axesparameterlist.Rows[1].Cells[3].Value = double.Parse(pitchvalue.Text) + " °";

            if (softmotion[0].LogicSVON == true)
            {
                axesparameterlist.Rows[0].Cells[6].Value = "ON";
                axesparameterlist.Rows[0].Cells[6].Style.BackColor = Color.LightGreen;
            }
            else
            {
                axesparameterlist.Rows[0].Cells[6].Value = "OFF";
                axesparameterlist.Rows[0].Cells[6].Style.BackColor = Color.White;
            }
            if (softmotion[1].LogicSVON == true)
            {
                axesparameterlist.Rows[1].Cells[6].Value = "ON";
                axesparameterlist.Rows[1].Cells[6].Style.BackColor = Color.LightGreen;
            }
            else
            {
                axesparameterlist.Rows[1].Cells[6].Value = "OFF";
                axesparameterlist.Rows[1].Cells[6].Style.BackColor = Color.White;
            }
            if (Math.Abs(softmotion[0].ActualPos) <= 1000)
            {
                axesparameterlist.Rows[0].Cells[8].Value = "ON";
                axesparameterlist.Rows[0].Cells[8].Style.BackColor = Color.LightGreen;
            }
            else
            {
                axesparameterlist.Rows[0].Cells[8].Value = "OFF";
                axesparameterlist.Rows[0].Cells[8].Style.BackColor = Color.White;
            }
            if (Math.Abs(softmotion[1].ActualPos) <= 1000)
            {
                axesparameterlist.Rows[1].Cells[8].Value = "ON";
                axesparameterlist.Rows[1].Cells[8].Style.BackColor = Color.LightGreen;
            }
            else
            {
                axesparameterlist.Rows[1].Cells[8].Value = "OFF";
                axesparameterlist.Rows[1].Cells[8].Style.BackColor = Color.White;
            }
            if (softmotion[0].LogicPOT == true)
            {
                axesparameterlist.Rows[0].Cells[9].Value = "ON";
                axesparameterlist.Rows[0].Cells[9].Style.BackColor = Color.LightGreen;
            }
            else
            {
                axesparameterlist.Rows[0].Cells[9].Value = "OFF";
                axesparameterlist.Rows[0].Cells[9].Style.BackColor = Color.White;
            }
            if (softmotion[1].LogicPOT == true)
            {
                axesparameterlist.Rows[1].Cells[9].Value = "ON";
                axesparameterlist.Rows[1].Cells[9].Style.BackColor = Color.LightGreen;
            }
            else
            {
                axesparameterlist.Rows[1].Cells[9].Value = "OFF";
                axesparameterlist.Rows[1].Cells[9].Style.BackColor = Color.White;
            }

            if (softmotion[0].LogicNOT == true)
            {
                axesparameterlist.Rows[0].Cells[10].Value = "ON";
                axesparameterlist.Rows[0].Cells[10].Style.BackColor = Color.LightGreen;
            }
            else
            {
                axesparameterlist.Rows[0].Cells[10].Value = "OFF";
                axesparameterlist.Rows[0].Cells[10].Style.BackColor = Color.White;
            }
            if (softmotion[1].LogicNOT == true)
            {
                axesparameterlist.Rows[1].Cells[10].Value = "ON";
                axesparameterlist.Rows[1].Cells[10].Style.BackColor = Color.LightGreen;
            }
            else
            {
                axesparameterlist.Rows[1].Cells[10].Value = "OFF";
                axesparameterlist.Rows[1].Cells[10].Style.BackColor = Color.White;
            }


        }



        ~Robot()
        {
            // Do nothing for now
            IsCancelled = true;
            t.Join();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        public void control_tp()
        {
            //textComm.Text = serialcomm.GetRecvcomm();
            //string tpmessage = serialcomm.GetRecvcomm();
            try
            {
                if (textComm.Text.Contains("MRET,?,A"))
                {
                    axesparameterlist.Rows[(int)Hand.A].Cells[0].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.A].Cells[1].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.A].Cells[2].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.A].Cells[3].Style.BackColor = Color.Aqua;
                    if ((lastaxisno != (int)Hand.A) && (lastaxisno != -1))
                    {
                        axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;

                    }
                    lastaxisno = (int)Hand.A;
                    SelectedAxis = "A";
                }
                else if(SelectedAxis=="A")
                {
                    softmotion[(int)Hand.A].AxisNo = (int)Hand.A;
                    string[] commsplit = textComm.Text.Split(',');
                    switch (commsplit[0])
                    {
                        case "MRET":
                            break;
                        case "SEVO":
                            if (commsplit[2] == "1")
                            {
                                serialcomm.SendData("0F0000,MRET,A,0,1,0,0,0,0,0,0,0,0");
                                softmotion[(int)Hand.A].servoON();
                            }
                            else
                            {
                                serialcomm.SendData("0F0000,MRET,A,0,0,0,0,0,0,0,0,0,0");
                                softmotion[(int)Hand.A].servoOFF();
                            }

                            break;
                        case "ZRET":
                            serialcomm.SendData("0F0000,MRET,A,0,1,1,0,0,0,0,0,0,0");
                            softmotion[(int)Hand.A].Home();
                            axesparameterlist.Rows[(int)Hand.A].Cells[8].Value = "ON";
                            axesparameterlist.Rows[(int)Hand.A].Cells[8].Style.BackColor = Color.LightGreen;
                            break;
                        case "ARES":
                            string sendcomm = "0F0000,MRET,A,0,1,0,0,0,0,0,0,0,0";
                            serialcomm.SendData(sendcomm);
                            for (int i = 0; i < axesparameterlist.Rows.Count; i++)
                            {
                                axesparameterlist.Rows[i].Cells[5].Style.BackColor = Color.White;
                                axesparameterlist.Rows[i].Cells[5].Value = "OFF";

                            }

                            break;
                        case "JOSP":

                            serialcomm.SendData("0F0000,MRET,A,0,1,0,1,0,0,0,0,0,0");
                            if (double.Parse(jogspeedvalue.Text) > 0)
                            {
                                axesparameterlist.Rows[(int)Hand.A].Cells[7].Value = "ON";
                                axesparameterlist.Rows[(int)Hand.A].Cells[7].Style.BackColor = Color.LightGreen;
                                softmotion[(int)Hand.A].speed = 200000;//Convert.ToSingle(commsplit[1])*(655365/100);
                                softmotion[(int)Hand.A].JogMove(true);

                            }
                            else
                            {
                                if (double.Parse(jogspeedvalue.Text) == 0)
                                {
                                    axesparameterlist.Rows[(int)Hand.A].Cells[7].Value = "OFF";
                                    axesparameterlist.Rows[(int)Hand.A].Cells[7].Style.BackColor = Color.White;
                                    softmotion[(int)Hand.A].Stop();

                                }
                                else
                                {
                                    axesparameterlist.Rows[(int)Hand.A].Cells[7].Value = "ON";
                                    axesparameterlist.Rows[(int)Hand.A].Cells[7].Style.BackColor = Color.LightGreen;
                                    softmotion[(int)Hand.A].speed = float.Parse(jogspeedvalue.Text);
                                    softmotion[(int)Hand.A].JogMove(false);

                                }
                            }
                            break;

                    }
                }
                if (textComm.Text.Contains("MRET,?,B"))
                {
                    axesparameterlist.Rows[(int)Hand.B].Cells[0].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.B].Cells[1].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.B].Cells[2].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.B].Cells[3].Style.BackColor = Color.Aqua;
                    if ((lastaxisno != (int)Hand.B) && (lastaxisno != -1))
                    {
                        axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;

                    }
                    lastaxisno = (int)Hand.B;
                    SelectedAxis = "B";
                }
                else if(SelectedAxis=="B")
                {
                    softmotion[(int)Hand.B].AxisNo = (int)Hand.B;
                    string[] commsplit = textComm.Text.Split(',');
                    switch (commsplit[0])
                    {
                        case "MRET":
                            break;
                        case "SEVO":
                            if (commsplit[2] == "1")
                            {
                                
                                softmotion[(int)Hand.B].servoON();

                                
                            }
                            else
                            {
                                softmotion[(int)Hand.B].servoOFF();
                            }

                            break;
                        case "ZRET":
                            softmotion[(int)Hand.B].Home();
                            axesparameterlist.Rows[(int)Hand.B].Cells[8].Value = "ON";
                            axesparameterlist.Rows[(int)Hand.B].Cells[8].Style.BackColor = Color.LightGreen;
                            break;
                        case "ARES":
                            for (int i = 0; i < axesparameterlist.Rows.Count; i++)
                            {
                                axesparameterlist.Rows[i].Cells[5].Style.BackColor = Color.White;
                                axesparameterlist.Rows[i].Cells[5].Value = "OFF";

                            }

                            break;
                        case "JOSP":


                            if (double.Parse(jogspeedvalue.Text) > 0)
                            {
                                axesparameterlist.Rows[(int)Hand.B].Cells[7].Value = "ON";
                                axesparameterlist.Rows[(int)Hand.B].Cells[7].Style.BackColor = Color.LightGreen;
                                softmotion[(int)Hand.B].speed = float.Parse(jogspeedvalue.Text);
                                softmotion[(int)Hand.B].JogMove(true);

                            }
                            else
                            {
                                if (double.Parse(jogspeedvalue.Text) == 0)
                                {
                                    axesparameterlist.Rows[(int)Hand.B].Cells[7].Value = "OFF";
                                    axesparameterlist.Rows[(int)Hand.B].Cells[7].Style.BackColor = Color.White;
                                    softmotion[(int)Hand.B].Stop();

                                }
                                else
                                {
                                    axesparameterlist.Rows[(int)Hand.B].Cells[7].Value = "ON";
                                    axesparameterlist.Rows[(int)Hand.B].Cells[7].Style.BackColor = Color.LightGreen;
                                    softmotion[(int)Hand.B].speed = float.Parse(jogspeedvalue.Text);
                                    softmotion[(int)Hand.B].JogMove(false);

                                }
                            }
                            break;
                    }
                
                }
                if (textComm.Text.Contains("MRET,?,C"))
                {
                    axesparameterlist.Rows[(int)Hand.C].Cells[0].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.C].Cells[1].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.C].Cells[2].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.C].Cells[3].Style.BackColor = Color.Aqua;
                    if ((lastaxisno != (int)Hand.C) && (lastaxisno != -1))
                    {
                        axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;

                    }
                    lastaxisno = (int)Hand.C;
                }
                if (textComm.Text.Contains("MRET,?,D"))
                {
                    axesparameterlist.Rows[(int)Hand.D].Cells[0].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.D].Cells[1].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.D].Cells[2].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.D].Cells[3].Style.BackColor = Color.Aqua;
                    if ((lastaxisno != (int)Hand.D) && (lastaxisno != -1))
                    {
                        axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;

                    }
                    lastaxisno = (int)Hand.D;
                }
                if (textComm.Text.Contains("MRET,?,L"))
                {
                    axesparameterlist.Rows[(int)Hand.L].Cells[0].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.L].Cells[1].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.L].Cells[2].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.L].Cells[3].Style.BackColor = Color.Aqua;
                    if ((lastaxisno != (int)Hand.L) && (lastaxisno != -1))
                    {
                        axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;

                    }
                    lastaxisno = (int)Hand.L;
                }
                if (textComm.Text.Contains("MRET,?,R"))
                {
                    axesparameterlist.Rows[(int)Hand.R].Cells[0].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.R].Cells[1].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.R].Cells[2].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.R].Cells[3].Style.BackColor = Color.Aqua;
                    if ((lastaxisno != (int)Hand.R) && (lastaxisno != -1))
                    {
                        axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;

                    }
                    lastaxisno = (int)Hand.R;
                }
                if (textComm.Text.Contains("MRET,?,T"))
                {
                    axesparameterlist.Rows[(int)Hand.T].Cells[0].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.T].Cells[1].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.T].Cells[2].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.T].Cells[3].Style.BackColor = Color.Aqua;
                    if ((lastaxisno != (int)Hand.T) && (lastaxisno != -1))
                    {
                        axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;

                    }
                    lastaxisno = (int)Hand.T;
                }
                if (textComm.Text.Contains("MRET,?,Z"))
                {
                    axesparameterlist.Rows[(int)Hand.Z].Cells[0].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.Z].Cells[1].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.Z].Cells[2].Style.BackColor = Color.Aqua;
                    axesparameterlist.Rows[(int)Hand.Z].Cells[3].Style.BackColor = Color.Aqua;
                    if ((lastaxisno != (int)Hand.Z) && (lastaxisno != -1))
                    {
                        axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                        axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;

                    }
                    lastaxisno = (int)Hand.Z;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //MessageBox.Show("TP Control failed in Robot", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void jogmovebutton_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {


                axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[7].Value = "OFF";
                axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[7].Style.BackColor = Color.White;

                softmotion[axesparameterlist.CurrentCell.RowIndex].Stop();
            }
            catch (Exception)
            {

                MessageBox.Show("JogmoveStop failed in Robot", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        public void jogmovebutton_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {

                axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[7].Value = "ON";
                axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[7].Style.BackColor = Color.LightGreen;

                if (double.Parse(jogspeedvalue.Text) >= 0)
                {

                    softmotion[axesparameterlist.CurrentCell.RowIndex].speed = float.Parse(jogspeedvalue.Text);
                    softmotion[axesparameterlist.CurrentCell.RowIndex].JogMove(true);
                }
                else
                {
                    softmotion[axesparameterlist.CurrentCell.RowIndex].JogMove(false);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("JogmoveStart failed in Robot", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //private void jogmove_Click(object sender, EventArgs e)
        //{
        //    if (softmotion[dataGridView1.CurrentCell.RowIndex].LogicSVON == true)
        //    {
        //        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value = "ON";
        //        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Style.BackColor = Color.LightGreen;
        //    }
        //    if (double.Parse(jogspeedvalue.Text) >= 0)
        //    {

        //       softmotion[dataGridView1.CurrentCell.RowIndex].speed = float.Parse(jogspeedvalue.Text);
        //       softmotion[dataGridView1.CurrentCell.RowIndex].JogMove(true);
        //    }
        //    else
        //    {
        //        softmotion[dataGridView1.CurrentCell.RowIndex].JogMove(false);
        //    }

        //}


        

     

        public void jogspeedincr_Click(object sender, EventArgs e)
        {
            double value = double.Parse(jogspeedvalue.Text);
            value = value + 1000;
            jogspeedvalue.Text = value.ToString();
            
            
        }



        public void dataGridView1_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            if (axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Selected)
            {

                axisstatuslabel.Text = axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Value.ToString() + " Selected" + "(" + $"{softmotion[axesparameterlist.CurrentCell.RowIndex].opstate}" + ")";
                softmotion[axesparameterlist.CurrentCell.RowIndex].AxisNo = axesparameterlist.CurrentCell.RowIndex;
                softmotion[axesparameterlist.CurrentCell.RowIndex].Open();
                softmotion[axesparameterlist.CurrentCell.RowIndex].createdevice();
                if (axesparameterlist.CurrentCell.RowIndex == 0)
                    softmotion[axesparameterlist.CurrentCell.RowIndex].setGearRatio(1, 1);
                else
                    softmotion[axesparameterlist.CurrentCell.RowIndex].setGearRatio(1,1);


                switch (axesparameterlist.CurrentCell.RowIndex)
                {
                    case 0:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 1:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 2:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 3:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 4:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 5:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 6:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 7:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 8:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 9:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 10:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 11:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 12:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 13:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 14:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                    case 15:
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[1].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[2].Style.BackColor = Color.Aqua;
                        axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Style.BackColor = Color.Aqua;
                        if (lastaxisno != axesparameterlist.CurrentCell.RowIndex)
                        {
                            axesparameterlist.Rows[lastaxisno].Cells[0].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[1].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[2].Style.BackColor = Color.White;
                            axesparameterlist.Rows[lastaxisno].Cells[3].Style.BackColor = Color.White;
                        }
                        lastaxisno = axesparameterlist.CurrentCell.RowIndex;
                        break;
                }

                robotcontrolpanel.Enabled = true;
            }
            else
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


     
        

        private void allservoonbutton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    softmotion[i].servoON();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("AllServoON failed in Robot", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void allservooffbutton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    softmotion[i].servoOFF();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("AllServoOFF failed in Robot", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void robotinitializebutton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    softmotion[i].AxisNo = i;
                    softmotion[i].Home();
                    axesparameterlist.Rows[i].Cells[8].Value = "ON";
                    axesparameterlist.Rows[i].Cells[8].Style.BackColor = Color.LightGreen;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Failed to Initialize in Robot", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void estopbutton_Click_1(object sender, EventArgs e)
        {
            Softmotion.EStop();
        }

        private void servoonbutton_Click(object sender, EventArgs e)
        {
            try
            {
                softmotion[axesparameterlist.CurrentCell.RowIndex].servoON();
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to ServoON in Robot", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void servooffbutton_Click(object sender, EventArgs e)
        {
            try
            {
                softmotion[axesparameterlist.CurrentCell.RowIndex].servoOFF();

            }
            catch (Exception)
            {

                MessageBox.Show("Failed to ServoOFF in Robot", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[7].Value = "OFF";
            axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[7].Style.BackColor = Color.White;

        }

        private void initbutton_Click(object sender, EventArgs e)
        {

            try
            {
                softmotion[axesparameterlist.CurrentCell.RowIndex].Home();
                axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[8].Value = "ON";
                axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[8].Style.BackColor = Color.LightGreen;
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to Initialize in Robot", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void alarmrstbutton_Click(object sender, EventArgs e)
        {

        }

      

        private void jogspeeddecr_Click(object sender, EventArgs e)
        {
            double value = double.Parse(jogspeedvalue.Text);
            value = value - 1000;
            jogspeedvalue.Text = value.ToString();

        }

        private void pitchmovebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (softmotion[axesparameterlist.CurrentCell.RowIndex].LogicSVON == true)
                {
                    axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[7].Value = "ON";
                    axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[7].Style.BackColor = Color.LightGreen;
                }
                softmotion[axesparameterlist.CurrentCell.RowIndex].Target = double.Parse(pitchvalue.Text);
                axesparameterlist.Rows[axesparameterlist.CurrentCell.RowIndex].Cells[3].Value = pitchvalue.Text + " °";
                softmotion[axesparameterlist.CurrentCell.RowIndex].speed = 1000;
                softmotion[axesparameterlist.CurrentCell.RowIndex].PosMove();



            }
            catch (Exception)
            {

                MessageBox.Show("PitchMove failed in Robot", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
