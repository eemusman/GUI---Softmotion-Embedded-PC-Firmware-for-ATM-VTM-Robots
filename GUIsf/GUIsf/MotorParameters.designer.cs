namespace GUIsf
{
    partial class MotorParameters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.motorlist = new System.Windows.Forms.DataGridView();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.motorparamread = new AltoControls.AltoButton();
            this.motorparamsave = new AltoControls.AltoButton();
            this.motorparamlist = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.driverparamread = new AltoControls.AltoButton();
            this.driverparamsave = new AltoControls.AltoButton();
            this.driverparamlist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.motorlist)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motorparamlist)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverparamlist)).BeginInit();
            this.SuspendLayout();
            // 
            // motorlist
            // 
            this.motorlist.AllowUserToAddRows = false;
            this.motorlist.AllowUserToDeleteRows = false;
            this.motorlist.AllowUserToResizeColumns = false;
            this.motorlist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.motorlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.motorlist.BackgroundColor = System.Drawing.Color.Silver;
            this.motorlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.motorlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.motorlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.motorlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.motorlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.motorlist.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.motorlist.Location = new System.Drawing.Point(9, 56);
            this.motorlist.MultiSelect = false;
            this.motorlist.Name = "motorlist";
            this.motorlist.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.motorlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.motorlist.RowHeadersWidth = 30;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.motorlist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.motorlist.Size = new System.Drawing.Size(274, 617);
            this.motorlist.TabIndex = 1;
            this.motorlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.motorlist_CellMouseClick);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox9.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(7, 10);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(456, 35);
            this.textBox9.TabIndex = 29;
            this.textBox9.Text = "Motor Parameters";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(8, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(275, 35);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "Motor List";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 749);
            this.panel1.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(7, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(499, 35);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "Driver Parameters";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.motorparamread);
            this.panel2.Controls.Add(this.motorparamsave);
            this.panel2.Controls.Add(this.motorparamlist);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Location = new System.Drawing.Point(289, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 749);
            this.panel2.TabIndex = 33;
            // 
            // motorparamread
            // 
            this.motorparamread.Active1 = System.Drawing.Color.LightBlue;
            this.motorparamread.Active2 = System.Drawing.Color.SteelBlue;
            this.motorparamread.BackColor = System.Drawing.Color.Transparent;
            this.motorparamread.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.motorparamread.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorparamread.ForeColor = System.Drawing.Color.Black;
            this.motorparamread.Inactive1 = System.Drawing.Color.SteelBlue;
            this.motorparamread.Inactive2 = System.Drawing.Color.LightBlue;
            this.motorparamread.Location = new System.Drawing.Point(55, 676);
            this.motorparamread.Name = "motorparamread";
            this.motorparamread.Radius = 10;
            this.motorparamread.Size = new System.Drawing.Size(97, 59);
            this.motorparamread.Stroke = false;
            this.motorparamread.StrokeColor = System.Drawing.Color.Gray;
            this.motorparamread.TabIndex = 222;
            this.motorparamread.Text = "Read";
            this.motorparamread.Transparency = false;
            this.motorparamread.Click += new System.EventHandler(this.motorparamread_Click);
            // 
            // motorparamsave
            // 
            this.motorparamsave.Active1 = System.Drawing.Color.LightBlue;
            this.motorparamsave.Active2 = System.Drawing.Color.SteelBlue;
            this.motorparamsave.BackColor = System.Drawing.Color.Transparent;
            this.motorparamsave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.motorparamsave.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorparamsave.ForeColor = System.Drawing.Color.Black;
            this.motorparamsave.Inactive1 = System.Drawing.Color.SteelBlue;
            this.motorparamsave.Inactive2 = System.Drawing.Color.LightBlue;
            this.motorparamsave.Location = new System.Drawing.Point(319, 676);
            this.motorparamsave.Name = "motorparamsave";
            this.motorparamsave.Radius = 10;
            this.motorparamsave.Size = new System.Drawing.Size(95, 59);
            this.motorparamsave.Stroke = false;
            this.motorparamsave.StrokeColor = System.Drawing.Color.Gray;
            this.motorparamsave.TabIndex = 221;
            this.motorparamsave.Text = "Save";
            this.motorparamsave.Transparency = false;
            this.motorparamsave.Click += new System.EventHandler(this.motorparamsave_Click);
            // 
            // motorparamlist
            // 
            this.motorparamlist.AllowUserToAddRows = false;
            this.motorparamlist.AllowUserToDeleteRows = false;
            this.motorparamlist.AllowUserToResizeColumns = false;
            this.motorparamlist.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.motorparamlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.motorparamlist.BackgroundColor = System.Drawing.Color.Silver;
            this.motorparamlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.motorparamlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.motorparamlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.motorparamlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.motorparamlist.DefaultCellStyle = dataGridViewCellStyle8;
            this.motorparamlist.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.motorparamlist.Location = new System.Drawing.Point(7, 53);
            this.motorparamlist.MultiSelect = false;
            this.motorparamlist.Name = "motorparamlist";
            this.motorparamlist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.motorparamlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.motorparamlist.RowHeadersWidth = 50;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.motorparamlist.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.motorparamlist.Size = new System.Drawing.Size(456, 617);
            this.motorparamlist.TabIndex = 195;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.driverparamread);
            this.panel3.Controls.Add(this.driverparamsave);
            this.panel3.Controls.Add(this.driverparamlist);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Location = new System.Drawing.Point(760, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 749);
            this.panel3.TabIndex = 34;
            // 
            // driverparamread
            // 
            this.driverparamread.Active1 = System.Drawing.Color.LightBlue;
            this.driverparamread.Active2 = System.Drawing.Color.SteelBlue;
            this.driverparamread.BackColor = System.Drawing.Color.Transparent;
            this.driverparamread.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.driverparamread.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverparamread.ForeColor = System.Drawing.Color.Black;
            this.driverparamread.Inactive1 = System.Drawing.Color.SteelBlue;
            this.driverparamread.Inactive2 = System.Drawing.Color.LightBlue;
            this.driverparamread.Location = new System.Drawing.Point(62, 676);
            this.driverparamread.Name = "driverparamread";
            this.driverparamread.Radius = 10;
            this.driverparamread.Size = new System.Drawing.Size(97, 59);
            this.driverparamread.Stroke = false;
            this.driverparamread.StrokeColor = System.Drawing.Color.Gray;
            this.driverparamread.TabIndex = 224;
            this.driverparamread.Text = "Read";
            this.driverparamread.Transparency = false;
            this.driverparamread.Click += new System.EventHandler(this.driverparamread_Click);
            // 
            // driverparamsave
            // 
            this.driverparamsave.Active1 = System.Drawing.Color.LightBlue;
            this.driverparamsave.Active2 = System.Drawing.Color.SteelBlue;
            this.driverparamsave.BackColor = System.Drawing.Color.Transparent;
            this.driverparamsave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.driverparamsave.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverparamsave.ForeColor = System.Drawing.Color.Black;
            this.driverparamsave.Inactive1 = System.Drawing.Color.SteelBlue;
            this.driverparamsave.Inactive2 = System.Drawing.Color.LightBlue;
            this.driverparamsave.Location = new System.Drawing.Point(350, 676);
            this.driverparamsave.Name = "driverparamsave";
            this.driverparamsave.Radius = 10;
            this.driverparamsave.Size = new System.Drawing.Size(95, 59);
            this.driverparamsave.Stroke = false;
            this.driverparamsave.StrokeColor = System.Drawing.Color.Gray;
            this.driverparamsave.TabIndex = 223;
            this.driverparamsave.Text = "Save";
            this.driverparamsave.Transparency = false;
            this.driverparamsave.Click += new System.EventHandler(this.driverparamsave_Click);
            // 
            // driverparamlist
            // 
            this.driverparamlist.AllowUserToAddRows = false;
            this.driverparamlist.AllowUserToDeleteRows = false;
            this.driverparamlist.AllowUserToResizeColumns = false;
            this.driverparamlist.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.driverparamlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.driverparamlist.BackgroundColor = System.Drawing.Color.Silver;
            this.driverparamlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.driverparamlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driverparamlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.driverparamlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.driverparamlist.DefaultCellStyle = dataGridViewCellStyle13;
            this.driverparamlist.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.driverparamlist.Location = new System.Drawing.Point(7, 53);
            this.driverparamlist.MultiSelect = false;
            this.driverparamlist.Name = "driverparamlist";
            this.driverparamlist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driverparamlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.driverparamlist.RowHeadersWidth = 50;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.driverparamlist.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.driverparamlist.Size = new System.Drawing.Size(499, 617);
            this.driverparamlist.TabIndex = 196;
            // 
            // MotorParameters
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.motorlist);
            this.Controls.Add(this.panel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::GUIsf.Properties.Settings.Default, "locate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = global::GUIsf.Properties.Settings.Default.locate;
            this.Name = "MotorParameters";
            this.Text = "MotorParameters";
            this.Load += new System.EventHandler(this.MotorParameters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.motorlist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motorparamlist)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverparamlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView motorlist;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView motorparamlist;
        private System.Windows.Forms.DataGridView driverparamlist;
        private AltoControls.AltoButton motorparamsave;
        private AltoControls.AltoButton motorparamread;
        private AltoControls.AltoButton driverparamread;
        private AltoControls.AltoButton driverparamsave;
    }
}