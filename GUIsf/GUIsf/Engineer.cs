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
    public partial class Engineer : Form
    {

        //Variables 

        string[] str1;
        public Engineer()
        {
            InitializeComponent();
        }

        private void Engineer_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add("index", "Index");
            dataGridView2.Columns.Add("parameter", "Parameter");
            dataGridView2.Columns.Add("value", "Value");


            //if (dataGridView1.Rows[0].Cells[0].Selected)
            {
                IOFILE iofile = new IOFILE("sample.txt");
                string[] param = iofile.ReadParam("[Axis0]");

                for (int i = 0; i <param.Length-10; i++)
                {
                    dataGridView2.Rows.Add();
                }
                for (int i = 10; i < param.Length; i++)
                {

                    string[] valuess = param[i].Split('=');
                    //dataGridView2.Rows.Add();
                    for (int j = 0; j < 2; j++)
                    {
                        dataGridView2.Rows[i - 10].Cells[0].Value = i - 9;
                        dataGridView2.Rows[i - 10].Cells[j + 1].Value = valuess[j];
                    }


                }
            }

            
            //if (dataGridView1.Rows[1].Cells[0].Selected)
            //{
            //    IOFILE iofile = new IOFILE("sample.txt");
            //    string[] param = iofile.ReadParam(str1[1]);
            //    for (int i = 10; i < param.Length; i++)
            //    {

            //        string[] valuess = param[i].Split('=');
            //        // dataGridView2.Rows.Add();
            //        for (int j = 0; j < 2; j++)
            //        {
            //            dataGridView2.Rows[i - 10].Cells[0].Value = i - 9;
            //            dataGridView2.Rows[i - 10].Cells[j + 1].Value = valuess[j];
            //        }


            //    }
            //}
            //if (dataGridView1.Rows[2].Cells[0].Selected)
            //{
            //    IOFILE iofile = new IOFILE("sample.txt");
            //    string[] param = iofile.ReadParam(str1[2]);
            //    for (int i = 10; i < param.Length; i++)
            //    {

            //        string[] valuess = param[i].Split('=');
            //        //  dataGridView2.Rows.Add();
            //        for (int j = 0; j < 2; j++)
            //        {
            //            dataGridView2.Rows[i - 10].Cells[0].Value = i - 9;
            //            dataGridView2.Rows[i - 10].Cells[j + 1].Value = valuess[j];
            //        }



            //    }

            //}
            //if (dataGridView1.Rows[3].Cells[0].Selected)
            //{
            //    IOFILE iofile = new IOFILE("sample.txt");
            //    string[] param = iofile.ReadParam(str1[3]);
            //    for (int i = 10; i < param.Length; i++)
            //    {

            //        string[] valuess = param[i].Split('=');
            //        //  dataGridView2.Rows.Add();
            //        for (int j = 0; j < 2; j++)
            //        {
            //            dataGridView2.Rows[i - 10].Cells[0].Value = i - 9;
            //            dataGridView2.Rows[i - 10].Cells[j + 1].Value = valuess[j];
            //        }


            //    }
            //}
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[0].Selected)
            {
                IOFILE iofile = new IOFILE("sample.txt");
                string[] param = iofile.ReadParam(str1[0]);
                for (int i = 10; i < param.Length; i++)
                {

                    string[] valuess = param[i].Split('=');
                    //dataGridView2.Rows.Add();
                    for (int j = 0; j < 2; j++)
                    {
                        dataGridView2.Rows[i - 10].Cells[0].Value = i - 9;
                        dataGridView2.Rows[i - 10].Cells[j + 1].Value = valuess[j];
                    }


                }
            }
            if (dataGridView1.Rows[1].Cells[0].Selected)
            {
                IOFILE iofile = new IOFILE("sample.txt");
                string[] param = iofile.ReadParam(str1[1]);
                for (int i = 10; i < param.Length; i++)
                {

                    string[] valuess = param[i].Split('=');
                    // dataGridView2.Rows.Add();
                    for (int j = 0; j < 2; j++)
                    {
                        dataGridView2.Rows[i - 10].Cells[0].Value = i - 9;
                        dataGridView2.Rows[i - 10].Cells[j + 1].Value = valuess[j];
                    }


                }
            }
            if (dataGridView1.Rows[2].Cells[0].Selected)
            {
                IOFILE iofile = new IOFILE("sample.txt");
                string[] param = iofile.ReadParam(str1[2]);
                for (int i = 10; i < param.Length; i++)
                {

                    string[] valuess = param[i].Split('=');
                    //  dataGridView2.Rows.Add();
                    for (int j = 0; j < 2; j++)
                    {
                        dataGridView2.Rows[i - 10].Cells[0].Value = i - 9;
                        dataGridView2.Rows[i - 10].Cells[j + 1].Value = valuess[j];
                    }



                }

            }
            if (dataGridView1.Rows[3].Cells[0].Selected)
            {
                IOFILE iofile = new IOFILE("sample.txt");
                string[] param = iofile.ReadParam(str1[3]);
                for (int i = 10; i < param.Length; i++)
                {

                    string[] valuess = param[i].Split('=');
                    //  dataGridView2.Rows.Add();
                    for (int j = 0; j < 2; j++)
                    {
                        dataGridView2.Rows[i - 10].Cells[0].Value = i - 9;
                        dataGridView2.Rows[i - 10].Cells[j + 1].Value = valuess[j];
                    }


                }
            }

        }
    }
}
