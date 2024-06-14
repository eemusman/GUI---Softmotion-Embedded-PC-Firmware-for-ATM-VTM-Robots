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

namespace GUIsf
{
    public partial class MainGUI : Form
    {
        
        private Form1 form=null;
        Alarm alarm = new Alarm();
        Engineer engr = new Engineer();
        IO io = new IO();
        Main main = new Main();
        Database database = new Database();
        public RS232Form tpcomm;
        public Robot robot;
        multipleaxis multiaxisform = new multipleaxis();
        Manual manualform = new Manual();
        Teaching teachform = new Teaching();
        MotorParameters paramform = new MotorParameters();
        string formcheck ;

        public MainGUI(Form1 form1)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            form= form1 as Form1;
            InitializeComponent();  
            alarm.MdiParent = this;
            alarm.Hide();
            engr.MdiParent = this;
            engr.Hide();
            io.MdiParent = this;
            io.Hide();
            main.MdiParent = this;
            main.Hide();
            database.MdiParent = this;
            database.Hide();
            robot = new Robot(this, tpcomm);
            robot.MdiParent = this;
            robot.Hide();
            tpcomm = new RS232Form(robot);
            tpcomm.MdiParent = this;
            tpcomm.Hide();
            multiaxisform.MdiParent = this;
            multiaxisform.Hide();
            manualform.MdiParent=this;
            manualform.Hide();
            teachform.MdiParent = this;
            teachform.Hide();
            paramform.MdiParent = this;
            paramform.Hide();


        }


        ~MainGUI()
        {
            form.Close();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
                {
                    try
                    {
                        // Attempt to cast the control to type MdiClient.
                        ctlMDI = (MdiClient)ctl;

                        // Set the BackColor of the MdiClient control.
                        ctlMDI.BackColor =Color.FromArgb(40,40,40);
                    }
                    catch (InvalidCastException )
                    {
                        
                    }
                }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
           
            
        }

      

        

        private void button5_Click(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            
        }

        

        

        private void button8_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void mainbutton_Click(object sender, EventArgs e)
        {

            mainbutton.Inactive1= Color.SteelBlue;
            mainbutton.Inactive2 = Color.SteelBlue;
            
            main.Visible = true;
            main.Focus();

            switch (formcheck)
            {
                case "robot":
                    robotbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    robotbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    robotbutton.NormalColorB = Color.Gray;
                    break;
                case "io":
                    iobutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    iobutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    iobutton.NormalColorB = Color.Gray;
                    break;
                case "commportal":

                    commbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    commbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    commbutton.NormalColorB = Color.Gray;
                    break;
                case "database":
                    databasebutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    databasebutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    databasebutton.NormalColorB = Color.Gray;
                    break;
                case "alarm":

                    alarmbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    alarmbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    alarmbutton.NormalColorB = Color.Gray;
                    break;
                case "engr":

                    engrbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    engrbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    engrbutton.NormalColorB = Color.Gray;
                    break;
                case "multipleaxis":

                    multipleaxis.NormalBorderColor = Color.FromArgb(64, 64, 64); 
                    multipleaxis.NormalColorA = Color.FromArgb(64, 64, 64);
                    multipleaxis.NormalColorB = Color.Gray;
                    break;
                case "manual":
                    manualbutton.NormalBorderColor = Color.FromArgb(64, 64, 64);
                    manualbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    manualbutton.NormalColorB = Color.Gray;
                    break;
                case "teaching":

                    teachingbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    teachingbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    teachingbutton.NormalColorB = Color.Gray;
                    break;
                case "parameters":

                    parambutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    parambutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    parambutton.NormalColorB = Color.Gray;
                    break;


                default:
                    break;
            }
            formcheck = "main";
        }

        private void manualbutton_Click_1(object sender, EventArgs e)
        {
            manualbutton.NormalBorderColor = Color.SteelBlue;
            manualbutton.NormalColorA = Color.SteelBlue;
            manualbutton.NormalColorB = Color.SteelBlue;
            manualform.Visible=true;
            manualform.Focus();
            switch (formcheck)
            {
                case "robot":
                    robotbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    robotbutton.NormalColorA = Color.FromArgb(64,64,64);
                    robotbutton.NormalColorB = Color.Gray;
                    break;
                case "io":
                    iobutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    iobutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    iobutton.NormalColorB = Color.Gray;
                    break;
                case "commportal":

                    commbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    commbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    commbutton.NormalColorB = Color.Gray;
                    break;
                case "database":
                    databasebutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    databasebutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    databasebutton.NormalColorB = Color.Gray;
                    break;
                case "alarm":

                    alarmbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    alarmbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    alarmbutton.NormalColorB = Color.Gray;
                    break;
                case "engr":

                    engrbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    engrbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    engrbutton.NormalColorB = Color.Gray;
                    break;
                case "multipleaxis":

                    multipleaxis.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    multipleaxis.NormalColorA = Color.FromArgb(64, 64, 64);
                    multipleaxis.NormalColorB = Color.Gray;
                    break;
                case "main":
                    mainbutton.Inactive1 = Color.FromArgb(64, 64, 64); ;
                    mainbutton.Inactive2 = Color.Gray; 

                    break;
                case "teaching":

                    teachingbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    teachingbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    teachingbutton.NormalColorB = Color.Gray;
                    break;
                case "parameters":

                    parambutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    parambutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    parambutton.NormalColorB = Color.Gray;
                    break;


                default:
                    break;
            }
            formcheck = "manual";
        }

        

        private void colorButton1_Click(object sender, EventArgs e)
        {

            robotbutton.NormalBorderColor = Color.SteelBlue;
            robotbutton.NormalColorA = Color.SteelBlue;
            robotbutton.NormalColorB = Color.SteelBlue;

            robot.Visible = true;
            robot.Focus();

            switch (formcheck)
            {
                case "manual":
                    manualbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    manualbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    manualbutton.NormalColorB = Color.Gray;
                    break;
                case "io":
                    iobutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    iobutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    iobutton.NormalColorB = Color.Gray;
                    break;
                case "commportal":

                    commbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    commbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    commbutton.NormalColorB = Color.Gray;
                    break;
                case "database":
                    databasebutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    databasebutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    databasebutton.NormalColorB = Color.Gray;
                    break;
                case "alarm":

                    alarmbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    alarmbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    alarmbutton.NormalColorB = Color.Gray;
                    break;
                case "engr":

                    engrbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    engrbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    engrbutton.NormalColorB = Color.Gray;
                    break;
                case "multipleaxis":

                    multipleaxis.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    multipleaxis.NormalColorA = Color.FromArgb(64, 64, 64);
                    multipleaxis.NormalColorB = Color.Gray;
                    break;
                case "main":
                    mainbutton.Inactive1 = Color.FromArgb(64, 64, 64); ;
                    mainbutton.Inactive2 = Color.Gray;

                    break;
                case "teaching":

                    teachingbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    teachingbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    teachingbutton.NormalColorB = Color.Gray;
                    break;
                case "parameters":

                    parambutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    parambutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    parambutton.NormalColorB = Color.Gray;
                    break;


                default:
                    break;
            }
            formcheck = "robot";

        }

        private void multipleaxis_Click_1(object sender, EventArgs e)
        {

            multipleaxis.NormalBorderColor = Color.SteelBlue;
            multipleaxis.NormalColorA = Color.SteelBlue;
            multipleaxis.NormalColorB = Color.SteelBlue;

            multiaxisform.Visible = true;
            multiaxisform.Focus();

            switch (formcheck)
            {
                case "manual":
                    manualbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    manualbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    manualbutton.NormalColorB = Color.Gray;
                    break;
                case "io":
                    iobutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    iobutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    iobutton.NormalColorB = Color.Gray;
                    break;
                case "commportal":

                    commbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    commbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    commbutton.NormalColorB = Color.Gray;
                    break;
                case "database":
                    databasebutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    databasebutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    databasebutton.NormalColorB = Color.Gray;
                    break;
                case "alarm":

                    alarmbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    alarmbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    alarmbutton.NormalColorB = Color.Gray;
                    break;
                case "engr":

                    engrbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    engrbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    engrbutton.NormalColorB = Color.Gray;
                    break;
                case "robot":

                    robotbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    robotbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    robotbutton.NormalColorB = Color.Gray;
                    break;
                case "main":
                    mainbutton.Inactive1 = Color.FromArgb(64, 64, 64); ;
                    mainbutton.Inactive2 = Color.Gray;

                    break;
                case "teaching":

                    teachingbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    teachingbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    teachingbutton.NormalColorB = Color.Gray;
                    break;
                case "parameters":

                    parambutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    parambutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    parambutton.NormalColorB = Color.Gray;
                    break;


                default:
                    break;
            }
            formcheck = "multipleaxis";

        }

        private void iobutton_Click(object sender, EventArgs e)
        {

            iobutton.NormalBorderColor = Color.SteelBlue;
            iobutton.NormalColorA = Color.SteelBlue;
            iobutton.NormalColorB = Color.SteelBlue;

            io.Visible = true;
            io.Focus();

            switch (formcheck)
            {
                case "manual":
                    manualbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    manualbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    manualbutton.NormalColorB = Color.Gray;
                    break;
                case "multipleaxis":
                    multipleaxis.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    multipleaxis.NormalColorA = Color.FromArgb(64, 64, 64);
                    multipleaxis.NormalColorB = Color.Gray;
                    break;
                case "commportal":

                    commbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    commbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    commbutton.NormalColorB = Color.Gray;
                    break;
                case "database":
                    databasebutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    databasebutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    databasebutton.NormalColorB = Color.Gray;
                    break;
                case "alarm":

                    alarmbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    alarmbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    alarmbutton.NormalColorB = Color.Gray;
                    break;
                case "engr":

                    engrbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    engrbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    engrbutton.NormalColorB = Color.Gray;
                    break;
                case "robot":

                    robotbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    robotbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    robotbutton.NormalColorB = Color.Gray;
                    break;
                case "main":
                    mainbutton.Inactive1 = Color.FromArgb(64, 64, 64); ;
                    mainbutton.Inactive2 = Color.Gray;

                    break;
                case "teaching":

                    teachingbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    teachingbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    teachingbutton.NormalColorB = Color.Gray;
                    break;
                case "parameters":

                    parambutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    parambutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    parambutton.NormalColorB = Color.Gray;
                    break;


                default:
                    break;
            }
            formcheck = "io";


        }

        private void teachingbutton_Click(object sender, EventArgs e)
        {

            teachingbutton.NormalBorderColor = Color.SteelBlue;
            teachingbutton.NormalColorA = Color.SteelBlue;
            teachingbutton.NormalColorB = Color.SteelBlue;

            teachform.Visible=true;
            teachform.Focus();

            switch (formcheck)
            {
                case "manual":
                    manualbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    manualbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    manualbutton.NormalColorB = Color.Gray;
                    break;
                case "multipleaxis":
                    multipleaxis.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    multipleaxis.NormalColorA = Color.FromArgb(64, 64, 64);
                    multipleaxis.NormalColorB = Color.Gray;
                    break;
                case "commportal":

                    commbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    commbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    commbutton.NormalColorB = Color.Gray;
                    break;
                case "database":
                    databasebutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    databasebutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    databasebutton.NormalColorB = Color.Gray;
                    break;
                case "alarm":

                    alarmbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    alarmbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    alarmbutton.NormalColorB = Color.Gray;
                    break;
                case "engr":

                    engrbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    engrbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    engrbutton.NormalColorB = Color.Gray;
                    break;
                case "robot":

                    robotbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    robotbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    robotbutton.NormalColorB = Color.Gray;
                    break;
                case "main":
                    mainbutton.Inactive1 = Color.FromArgb(64, 64, 64); ;
                    mainbutton.Inactive2 = Color.Gray;

                    break;
                case "io":

                    iobutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    iobutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    iobutton.NormalColorB = Color.Gray;
                    break;
                case "parameters":

                    parambutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    parambutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    parambutton.NormalColorB = Color.Gray;
                    break;


                default:
                    break;
            }
            formcheck = "teaching";


        }

        private void databasebutton_Click(object sender, EventArgs e)
        {

            databasebutton.NormalBorderColor = Color.SteelBlue;
            databasebutton.NormalColorA = Color.SteelBlue;
            databasebutton.NormalColorB = Color.SteelBlue;

            database.Visible = true;
            database.Focus();

            switch (formcheck)
            {
                case "manual":
                    manualbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    manualbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    manualbutton.NormalColorB = Color.Gray;
                    break;
                case "multipleaxis":
                    multipleaxis.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    multipleaxis.NormalColorA = Color.FromArgb(64, 64, 64);
                    multipleaxis.NormalColorB = Color.Gray;
                    break;
                case "commportal":

                    commbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    commbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    commbutton.NormalColorB = Color.Gray;
                    break;
                case "teaching":
                    teachingbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    teachingbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    teachingbutton.NormalColorB = Color.Gray;
                    break;
                case "alarm":

                    alarmbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    alarmbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    alarmbutton.NormalColorB = Color.Gray;
                    break;
                case "engr":

                    engrbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    engrbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    engrbutton.NormalColorB = Color.Gray;
                    break;
                case "robot":

                    robotbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    robotbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    robotbutton.NormalColorB = Color.Gray;
                    break;
                case "main":
                    mainbutton.Inactive1 = Color.FromArgb(64, 64, 64); ;
                    mainbutton.Inactive2 = Color.Gray;

                    break;
                case "io":

                    iobutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    iobutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    iobutton.NormalColorB = Color.Gray;
                    break;
                case "parameters":

                    parambutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    parambutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    parambutton.NormalColorB = Color.Gray;
                    break;


                default:
                    break;
            }
            formcheck = "database";

        }

        private void alarmbutton_Click(object sender, EventArgs e)
        {

            alarmbutton.NormalBorderColor = Color.SteelBlue;
            alarmbutton.NormalColorA = Color.SteelBlue;
            alarmbutton.NormalColorB = Color.SteelBlue;

            alarm.Visible = true;
            alarm.Focus();

            switch (formcheck)
            {
                case "manual":
                    manualbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    manualbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    manualbutton.NormalColorB = Color.Gray;
                    break;
                case "multipleaxis":
                    multipleaxis.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    multipleaxis.NormalColorA = Color.FromArgb(64, 64, 64);
                    multipleaxis.NormalColorB = Color.Gray;
                    break;
                case "commportal":

                    commbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    commbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    commbutton.NormalColorB = Color.Gray;
                    break;
                case "teaching":
                    teachingbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    teachingbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    teachingbutton.NormalColorB = Color.Gray;
                    break;
                case "database":

                    databasebutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    databasebutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    databasebutton.NormalColorB = Color.Gray;
                    break;
                case "engr":

                    engrbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    engrbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    engrbutton.NormalColorB = Color.Gray;
                    break;
                case "robot":

                    robotbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    robotbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    robotbutton.NormalColorB = Color.Gray;
                    break;
                case "main":
                    mainbutton.Inactive1 = Color.FromArgb(64, 64, 64); ;
                    mainbutton.Inactive2 = Color.Gray;

                    break;
                case "io":

                    iobutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    iobutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    iobutton.NormalColorB = Color.Gray;
                    break;
                case "parameters":

                    parambutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    parambutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    parambutton.NormalColorB = Color.Gray;
                    break;


                default:
                    break;
            }
            formcheck = "alarm";


        }

        private void parambutton_Click(object sender, EventArgs e)
        {

            parambutton.NormalBorderColor = Color.SteelBlue;
            parambutton.NormalColorA = Color.SteelBlue;
            parambutton.NormalColorB = Color.SteelBlue;

            paramform.Visible = true;
            paramform.Focus();


            switch (formcheck)
            {
                case "manual":
                    manualbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    manualbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    manualbutton.NormalColorB = Color.Gray;
                    break;
                case "multipleaxis":
                    multipleaxis.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    multipleaxis.NormalColorA = Color.FromArgb(64, 64, 64);
                    multipleaxis.NormalColorB = Color.Gray;
                    break;
                case "commportal":

                    commbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    commbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    commbutton.NormalColorB = Color.Gray;
                    break;
                case "teaching":
                    teachingbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    teachingbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    teachingbutton.NormalColorB = Color.Gray;
                    break;
                case "database":

                    databasebutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    databasebutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    databasebutton.NormalColorB = Color.Gray;
                    break;
                case "engr":

                    engrbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    engrbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    engrbutton.NormalColorB = Color.Gray;
                    break;
                case "robot":

                    robotbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    robotbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    robotbutton.NormalColorB = Color.Gray;
                    break;
                case "main":
                    mainbutton.Inactive1 = Color.FromArgb(64, 64, 64); ;
                    mainbutton.Inactive2 = Color.Gray;

                    break;
                case "io":

                    iobutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    iobutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    iobutton.NormalColorB = Color.Gray;
                    break;
                case "alarm":

                    alarmbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    alarmbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    alarmbutton.NormalColorB = Color.Gray;
                    break;


                default:
                    break;
            }
            formcheck = "parameters";

        }



        private void colorButton1_Click_1(object sender, EventArgs e)
        {
           
            
        }

        private void xuiFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void engrbutton_Click(object sender, EventArgs e)
        {
            engrbutton.NormalBorderColor = Color.SteelBlue;
            engrbutton.NormalColorA = Color.SteelBlue;
            engrbutton.NormalColorB = Color.SteelBlue;

            engr.Visible = true;
            engr.Focus();

            switch (formcheck)
            {
                case "manual":
                    manualbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    manualbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    manualbutton.NormalColorB = Color.Gray;
                    break;
                case "multipleaxis":
                    multipleaxis.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    multipleaxis.NormalColorA = Color.FromArgb(64, 64, 64);
                    multipleaxis.NormalColorB = Color.Gray;
                    break;
                case "commportal":

                    commbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    commbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    commbutton.NormalColorB = Color.Gray;
                    break;
                case "teaching":
                    teachingbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    teachingbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    teachingbutton.NormalColorB = Color.Gray;
                    break;
                case "database":

                    databasebutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    databasebutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    databasebutton.NormalColorB = Color.Gray;
                    break;
                case "parameters":

                    parambutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    parambutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    parambutton.NormalColorB = Color.Gray;
                    break;
                case "robot":

                    robotbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    robotbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    robotbutton.NormalColorB = Color.Gray;
                    break;
                case "main":
                    mainbutton.Inactive1 = Color.FromArgb(64, 64, 64); ;
                    mainbutton.Inactive2 = Color.Gray;

                    break;
                case "io":

                    iobutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    iobutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    iobutton.NormalColorB = Color.Gray;
                    break;
                case "alarm":

                    alarmbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    alarmbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    alarmbutton.NormalColorB = Color.Gray;
                    break;


                default:
                    break;
            }
            formcheck = "engr";

        }

        private void commbutton_Click(object sender, EventArgs e)
        {
            commbutton.NormalBorderColor = Color.SteelBlue;
            commbutton.NormalColorA = Color.SteelBlue;
            commbutton.NormalColorB = Color.SteelBlue;

            tpcomm.Visible = true;
            tpcomm.Focus();

            switch (formcheck)
            {
                case "manual":
                    manualbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    manualbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    manualbutton.NormalColorB = Color.Gray;
                    break;
                case "multipleaxis":
                    multipleaxis.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    multipleaxis.NormalColorA = Color.FromArgb(64, 64, 64);
                    multipleaxis.NormalColorB = Color.Gray;
                    break;
                case "engr":

                    engrbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    engrbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    engrbutton.NormalColorB = Color.Gray;
                    break;
                case "teaching":
                    teachingbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    teachingbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    teachingbutton.NormalColorB = Color.Gray;
                    break;
                case "database":

                    databasebutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    databasebutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    databasebutton.NormalColorB = Color.Gray;
                    break;
                case "parameters":

                    parambutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    parambutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    parambutton.NormalColorB = Color.Gray;
                    break;
                case "robot":

                    robotbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    robotbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    robotbutton.NormalColorB = Color.Gray;
                    break;
                case "main":
                    mainbutton.Inactive1 = Color.FromArgb(64, 64, 64); ;
                    mainbutton.Inactive2 = Color.Gray;

                    break;
                case "io":

                    iobutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    iobutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    iobutton.NormalColorB = Color.Gray;
                    break;
                case "alarm":

                    alarmbutton.NormalBorderColor = Color.FromArgb(64, 64, 64); ;
                    alarmbutton.NormalColorA = Color.FromArgb(64, 64, 64);
                    alarmbutton.NormalColorB = Color.Gray;
                    break;


                default:
                    break;
            }
            formcheck = "commportal";

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            

            this.Close();
            form.Close();
        }
    }
}
