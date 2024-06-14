using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIsf
{
    public partial class MotorParameters : Form
    {
        //ECPlatform ecSDO = new ECPlatform();
        public string[] str;
        public string[] str1;
        public string[] str2;
        public string[] str3;
        List<DataGridViewRow> rows1 = new List<DataGridViewRow>();
        
        List<DataGridViewRow> rows3 = new List<DataGridViewRow>();

        IOFILE iofile = new IOFILE("sample.txt");
        IOFILE iofile1 = new IOFILE("sample driverparam.txt");

        public MotorParameters()
        {
            DoubleBuffered = true;
            InitializeComponent();
            DoubleBuffered = true;
            motorlist.Columns.Add("axisno", "Axis No");
            motorlist.Columns.Add("name", "Name");
            int numberofmotors = iofile.ReadInteger("[jjangMotor]", "NumOfMotor");

            str = new string[motorlist.ColumnCount];
            for (int i = 0; i < motorlist.ColumnCount; i++)
            {
                str[i] = motorlist.Columns[i].HeaderText;
            }
            str1 = new string[numberofmotors];
            for (int i = 0; i < numberofmotors; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(motorlist);
                row.Cells[0].Value = i + 1;
                str1[i] = "[" + "Axis" + i + "]";
                for (int j = 1; j < motorlist.ColumnCount; j++)
                {
                    string value = iofile.ReadString(str1[i], str[j]);
                    row.Cells[j].Value = value;
                }
                rows1.Add(row);
            }
            motorlist.Rows.AddRange(rows1.ToArray());
            
            // Motor Parameters
            motorparamlist.Columns.Add("index", "Index");
            motorparamlist.Columns.Add("parameter", "Parameter");
            motorparamlist.Columns.Add("value", "Value");

            // Driver Parameters
            driverparamlist.Columns.Add("index", "Index");
            driverparamlist.Columns.Add("parmeter", "Parameter");
            driverparamlist.Columns.Add("value", "Value");
            driverparamlist.Columns.Add("range", "Range");


            List<DataGridViewRow> rows2 = new List<DataGridViewRow>();

            string[] param = iofile.ReadParam(str1[0]);
            if (!(motorparamlist.Rows.Count > 0))
            {
                for (int i = 0; i < param.Length - 10; i++)
                {
                    motorparamlist.Rows.Add();
                }
            }
            for (int i = 10; i < param.Length; i++)
            {

                string[] valuess = param[i].Split('=');
                for (int j = 0; j < 2; j++)
                {
                    motorparamlist.Rows[i - 10].Cells[0].Value = i - 9;
                    motorparamlist.Rows[i - 10].Cells[j + 1].Value = valuess[j];
                }


            }

            string[] param1 = iofile1.ReadParam(str1[0]);


            int counter = 0;
            string[] range = new string[(param1.Length / 2) + 1];
            if (!(driverparamlist.Rows.Count > 0))
            {
                for (int i = 0; i < (param1.Length / 2); i++)
                {
                    driverparamlist.Rows.Add();
                }
            }
            for (int i = 1; i < param1.Length; i++)
            {

                string[] valuess = param1[i].Split('=');
                if (!(valuess[0].Contains("Range")))
                {
                    for (int j = 0; j < 2; j++)
                    {


                        driverparamlist.Rows[counter].Cells[j + 1].Value = valuess[j];
                        driverparamlist.Rows[counter].Cells[0].Value = counter + 1;


                    }
                    counter++;
                }
                else
                {
                    range[counter] = valuess[1];

                }
            }
            driverparamlist.Rows.AddRange(rows2.ToArray());
            for (int i = 0; i < range.Length - 1; i++)
            {

                driverparamlist.Rows[i].Cells[3].Value = range[i + 1];
            }

        }
        public void motorlist_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            if (motorlist.Rows[motorlist.CurrentCell.RowIndex].Cells[0].Selected)
            {
                List<DataGridViewRow> rows2 = new List<DataGridViewRow>();

                string[] param = iofile.ReadParam(str1[motorlist.CurrentCell.RowIndex]);
                if (!(motorparamlist.Rows.Count > 0))
                {
                    for (int i = 0; i < param.Length - 10; i++)
                    {
                        motorparamlist.Rows.Add();
                    }
                }
                for (int i = 10; i < param.Length; i++)
                {

                    string[] valuess = param[i].Split('=');
                    for (int j = 0; j < 2; j++)
                    {
                        motorparamlist.Rows[i - 10].Cells[0].Value = i - 9;
                        motorparamlist.Rows[i - 10].Cells[j + 1].Value = valuess[j];
                    }


                }
                
                string[] param1 = iofile1.ReadParam(str1[motorlist.CurrentCell.RowIndex]);
           
               
                int counter = 0;
                string[] range=new string[(param1.Length/2)+1];
                if (!(driverparamlist.Rows.Count > 0))
                {
                    for (int i = 0; i < (param1.Length/2); i++)
                    {
                        driverparamlist.Rows.Add();
                    }
                }
                for (int i = 1; i < param1.Length; i++)
                {

                    string[] valuess = param1[i].Split('=');
                    if (!(valuess[0].Contains("Range")))
                    {
                        for (int j = 0; j < 2; j++)
                        {


                            driverparamlist.Rows[counter].Cells[j + 1].Value = valuess[j];
                            driverparamlist.Rows[counter].Cells[0].Value = counter + 1;


                        }
                        counter++;
                    }
                    else
                    {
                        range[counter] = valuess[1];

                    }
                }
                driverparamlist.Rows.AddRange(rows2.ToArray());
                for (int i = 0; i < range.Length-1; i++)
                {
                   
                    driverparamlist.Rows[i].Cells[3].Value = range[i+1];
                }


            }
            

        }

       
  

       

      

        

        private void MotorParameters_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void motorparamread_Click(object sender, EventArgs e)
        {
            string[] param = iofile.ReadParam(str1[motorlist.CurrentCell.RowIndex]);
            if (!(motorparamlist.Rows.Count > 0))
            {
                for (int i = 0; i < param.Length - 10; i++)
                {
                    motorparamlist.Rows.Add();
                }
            }
            for (int i = 10; i < param.Length; i++)
            {

                string[] valuess = param[i].Split('=');
                for (int j = 0; j < 2; j++)
                {
                    motorparamlist.Rows[i - 10].Cells[0].Value = i - 9;
                    motorparamlist.Rows[i - 10].Cells[j + 1].Value = valuess[j];
                }


            }

            string[] param1 = iofile1.ReadParam(str1[motorlist.CurrentCell.RowIndex]);
        }

        private void motorparamsave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < motorparamlist.Rows.Count; i++)
                {
                    iofile.WriteString(str1[motorlist.CurrentCell.RowIndex], motorparamlist.Rows[i].Cells[1].Value.ToString(), motorparamlist.Rows[i].Cells[2].Value.ToString());
                }

                MessageBox.Show("Motor Parameters are saved", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Motor Parameters are not saved", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void driverparamread_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows2 = new List<DataGridViewRow>();
            string[] param1 = iofile1.ReadParam(str1[motorlist.CurrentCell.RowIndex]);


            int counter = 0;
            string[] range = new string[(param1.Length / 2) + 1];
            if (!(driverparamlist.Rows.Count > 0))
            {
                for (int i = 0; i < (param1.Length / 2); i++)
                {
                    driverparamlist.Rows.Add();
                }
            }
            for (int i = 1; i < param1.Length; i++)
            {

                string[] valuess = param1[i].Split('=');
                if (!(valuess[0].Contains("Range")))
                {
                    for (int j = 0; j < 2; j++)
                    {


                        driverparamlist.Rows[counter].Cells[j + 1].Value = valuess[j];
                        driverparamlist.Rows[counter].Cells[0].Value = counter + 1;


                    }
                    counter++;
                }
                else
                {
                    range[counter] = valuess[1];

                }
            }
            driverparamlist.Rows.AddRange(rows2.ToArray());
            for (int i = 0; i < range.Length - 1; i++)
            {

                driverparamlist.Rows[i].Cells[3].Value = range[i + 1];
            }
        }

        private void driverparamsave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < driverparamlist.Rows.Count; i++)
                {
                    iofile1.WriteString(str1[motorlist.CurrentCell.RowIndex], driverparamlist.Rows[i].Cells[1].Value.ToString(), driverparamlist.Rows[i].Cells[2].Value.ToString());

                }
                MessageBox.Show("Driver Parameters are saved", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Driver Parameters are not saved", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
