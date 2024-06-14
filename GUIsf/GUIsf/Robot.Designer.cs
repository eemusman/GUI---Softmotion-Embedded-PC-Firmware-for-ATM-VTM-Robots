namespace GUIsf
{
    partial class Robot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jogspeedvalue = new System.Windows.Forms.TextBox();
            this.pitchvalue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.robotcontrolpanel = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textComm = new System.Windows.Forms.TextBox();
            this.Command = new System.Windows.Forms.Label();
            this.jogpitchmovepanel = new System.Windows.Forms.GroupBox();
            this.pitchmovebutton = new ColorButton.ColorButton();
            this.jogmvbutton = new ColorButton.ColorButton();
            this.jogmoveincr = new System.Windows.Forms.Button();
            this.jogspeeddecr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.axisstatuslabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moverightbutton = new System.Windows.Forms.Button();
            this.moveupbutton = new System.Windows.Forms.Button();
            this.moveleftbutton = new System.Windows.Forms.Button();
            this.movedownbutton = new System.Windows.Forms.Button();
            this.econtrols = new System.Windows.Forms.GroupBox();
            this.estopbutton = new ColorButton.ColorButton();
            this.robotinitializebutton = new ColorButton.ColorButton();
            this.allservooffbutton = new ColorButton.ColorButton();
            this.allservoonbutton = new ColorButton.ColorButton();
            this.maincontrolspanel = new System.Windows.Forms.GroupBox();
            this.alarmrstbutton = new ColorButton.ColorButton();
            this.initbutton = new ColorButton.ColorButton();
            this.servooffbutton = new ColorButton.ColorButton();
            this.servoonbutton = new ColorButton.ColorButton();
            this.axesparameterlist = new System.Windows.Forms.DataGridView();
            this.robotcontrolpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.jogpitchmovepanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.econtrols.SuspendLayout();
            this.maincontrolspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axesparameterlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(267, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pitch";
            // 
            // jogspeedvalue
            // 
            this.jogspeedvalue.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogspeedvalue.Location = new System.Drawing.Point(386, 26);
            this.jogspeedvalue.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.jogspeedvalue.Name = "jogspeedvalue";
            this.jogspeedvalue.Size = new System.Drawing.Size(149, 38);
            this.jogspeedvalue.TabIndex = 12;
            this.jogspeedvalue.Text = "0";
            this.jogspeedvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pitchvalue
            // 
            this.pitchvalue.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchvalue.Location = new System.Drawing.Point(386, 72);
            this.pitchvalue.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pitchvalue.Name = "pitchvalue";
            this.pitchvalue.Size = new System.Drawing.Size(149, 40);
            this.pitchvalue.TabIndex = 13;
            this.pitchvalue.Text = "10000";
            this.pitchvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(538, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "um";
            // 
            // robotcontrolpanel
            // 
            this.robotcontrolpanel.Controls.Add(this.panel1);
            this.robotcontrolpanel.Controls.Add(this.jogpitchmovepanel);
            this.robotcontrolpanel.Controls.Add(this.label4);
            this.robotcontrolpanel.Controls.Add(this.label5);
            this.robotcontrolpanel.Controls.Add(this.axisstatuslabel);
            this.robotcontrolpanel.Controls.Add(this.groupBox1);
            this.robotcontrolpanel.Controls.Add(this.econtrols);
            this.robotcontrolpanel.Controls.Add(this.maincontrolspanel);
            this.robotcontrolpanel.Enabled = false;
            this.robotcontrolpanel.ForeColor = System.Drawing.Color.White;
            this.robotcontrolpanel.Location = new System.Drawing.Point(7, 380);
            this.robotcontrolpanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.robotcontrolpanel.Name = "robotcontrolpanel";
            this.robotcontrolpanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.robotcontrolpanel.Size = new System.Drawing.Size(1264, 300);
            this.robotcontrolpanel.TabIndex = 15;
            this.robotcontrolpanel.TabStop = false;
            this.robotcontrolpanel.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textComm);
            this.panel1.Controls.Add(this.Command);
            this.panel1.Location = new System.Drawing.Point(508, 259);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 39);
            this.panel1.TabIndex = 26;
            // 
            // textComm
            // 
            this.textComm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textComm.Location = new System.Drawing.Point(123, 5);
            this.textComm.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textComm.Name = "textComm";
            this.textComm.Size = new System.Drawing.Size(202, 27);
            this.textComm.TabIndex = 25;
            this.textComm.Text = "--tp command--";
            this.textComm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Command
            // 
            this.Command.AutoSize = true;
            this.Command.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Command.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Command.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command.ForeColor = System.Drawing.Color.White;
            this.Command.Location = new System.Drawing.Point(2, 8);
            this.Command.Margin = new System.Windows.Forms.Padding(0);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(81, 21);
            this.Command.TabIndex = 23;
            this.Command.Text = "Command";
            // 
            // jogpitchmovepanel
            // 
            this.jogpitchmovepanel.Controls.Add(this.pitchmovebutton);
            this.jogpitchmovepanel.Controls.Add(this.jogmvbutton);
            this.jogpitchmovepanel.Controls.Add(this.label3);
            this.jogpitchmovepanel.Controls.Add(this.pitchvalue);
            this.jogpitchmovepanel.Controls.Add(this.jogspeedvalue);
            this.jogpitchmovepanel.Controls.Add(this.jogmoveincr);
            this.jogpitchmovepanel.Controls.Add(this.jogspeeddecr);
            this.jogpitchmovepanel.Controls.Add(this.label2);
            this.jogpitchmovepanel.Controls.Add(this.label1);
            this.jogpitchmovepanel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogpitchmovepanel.ForeColor = System.Drawing.SystemColors.Control;
            this.jogpitchmovepanel.Location = new System.Drawing.Point(362, 135);
            this.jogpitchmovepanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.jogpitchmovepanel.Name = "jogpitchmovepanel";
            this.jogpitchmovepanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.jogpitchmovepanel.Size = new System.Drawing.Size(608, 118);
            this.jogpitchmovepanel.TabIndex = 16;
            this.jogpitchmovepanel.TabStop = false;
            this.jogpitchmovepanel.Text = "Jog/Pitch Mover";
            // 
            // pitchmovebutton
            // 
            this.pitchmovebutton.Active = true;
            this.pitchmovebutton.ButtonStyle = ColorButton.ColorButton.ButtonStyles.Rectangle;
            this.pitchmovebutton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchmovebutton.ForeColor = System.Drawing.Color.White;
            this.pitchmovebutton.GradientStyle = ColorButton.ColorButton.GradientStyles.Vertical;
            this.pitchmovebutton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pitchmovebutton.HoverColorA = System.Drawing.Color.Gray;
            this.pitchmovebutton.HoverColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pitchmovebutton.Location = new System.Drawing.Point(33, 71);
            this.pitchmovebutton.Name = "pitchmovebutton";
            this.pitchmovebutton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pitchmovebutton.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pitchmovebutton.NormalColorB = System.Drawing.Color.Gray;
            this.pitchmovebutton.Size = new System.Drawing.Size(154, 34);
            this.pitchmovebutton.SmoothingQuality = ColorButton.ColorButton.SmoothingQualities.AntiAlias;
            this.pitchmovebutton.TabIndex = 201;
            this.pitchmovebutton.Text = "Pitch Move";
            this.pitchmovebutton.Click += new System.EventHandler(this.pitchmovebutton_Click);
            // 
            // jogmvbutton
            // 
            this.jogmvbutton.Active = true;
            this.jogmvbutton.ButtonStyle = ColorButton.ColorButton.ButtonStyles.Rectangle;
            this.jogmvbutton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogmvbutton.ForeColor = System.Drawing.Color.White;
            this.jogmvbutton.GradientStyle = ColorButton.ColorButton.GradientStyles.Vertical;
            this.jogmvbutton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jogmvbutton.HoverColorA = System.Drawing.Color.Gray;
            this.jogmvbutton.HoverColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jogmvbutton.Location = new System.Drawing.Point(33, 31);
            this.jogmvbutton.Name = "jogmvbutton";
            this.jogmvbutton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jogmvbutton.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jogmvbutton.NormalColorB = System.Drawing.Color.Gray;
            this.jogmvbutton.Size = new System.Drawing.Size(154, 34);
            this.jogmvbutton.SmoothingQuality = ColorButton.ColorButton.SmoothingQualities.AntiAlias;
            this.jogmvbutton.TabIndex = 200;
            this.jogmvbutton.Text = "Jog Move";
            this.jogmvbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jogmovebutton_MouseDown);
            this.jogmvbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jogmovebutton_MouseUp);
            // 
            // jogmoveincr
            // 
            this.jogmoveincr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jogmoveincr.BackgroundImage")));
            this.jogmoveincr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jogmoveincr.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogmoveincr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jogmoveincr.Location = new System.Drawing.Point(542, 26);
            this.jogmoveincr.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.jogmoveincr.Name = "jogmoveincr";
            this.jogmoveincr.Size = new System.Drawing.Size(40, 37);
            this.jogmoveincr.TabIndex = 11;
            this.jogmoveincr.UseVisualStyleBackColor = true;
            this.jogmoveincr.Click += new System.EventHandler(this.jogspeedincr_Click);
            // 
            // jogspeeddecr
            // 
            this.jogspeeddecr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jogspeeddecr.BackgroundImage")));
            this.jogspeeddecr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jogspeeddecr.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogspeeddecr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jogspeeddecr.Location = new System.Drawing.Point(339, 27);
            this.jogspeeddecr.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.jogspeeddecr.Name = "jogspeeddecr";
            this.jogspeeddecr.Size = new System.Drawing.Size(39, 37);
            this.jogspeeddecr.TabIndex = 10;
            this.jogspeeddecr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.jogspeeddecr.UseVisualStyleBackColor = true;
            this.jogspeeddecr.Click += new System.EventHandler(this.jogspeeddecr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1121, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Robot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(584, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Single Axis";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // axisstatuslabel
            // 
            this.axisstatuslabel.AutoSize = true;
            this.axisstatuslabel.BackColor = System.Drawing.Color.Transparent;
            this.axisstatuslabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisstatuslabel.ForeColor = System.Drawing.Color.White;
            this.axisstatuslabel.Location = new System.Drawing.Point(76, 35);
            this.axisstatuslabel.Margin = new System.Windows.Forms.Padding(0);
            this.axisstatuslabel.Name = "axisstatuslabel";
            this.axisstatuslabel.Size = new System.Drawing.Size(95, 22);
            this.axisstatuslabel.TabIndex = 15;
            this.axisstatuslabel.Text = "Axis Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.moverightbutton);
            this.groupBox1.Controls.Add(this.moveupbutton);
            this.groupBox1.Controls.Add(this.moveleftbutton);
            this.groupBox1.Controls.Add(this.movedownbutton);
            this.groupBox1.Location = new System.Drawing.Point(42, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.groupBox1.Size = new System.Drawing.Size(221, 190);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // moverightbutton
            // 
            this.moverightbutton.BackColor = System.Drawing.Color.White;
            this.moverightbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moverightbutton.BackgroundImage")));
            this.moverightbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moverightbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.moverightbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.moverightbutton.Location = new System.Drawing.Point(137, 75);
            this.moverightbutton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.moverightbutton.Name = "moverightbutton";
            this.moverightbutton.Size = new System.Drawing.Size(41, 40);
            this.moverightbutton.TabIndex = 5;
            this.moverightbutton.UseVisualStyleBackColor = false;
            // 
            // moveupbutton
            // 
            this.moveupbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moveupbutton.BackgroundImage = global::GUIsf.Properties.Resources.uparrow1;
            this.moveupbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveupbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.moveupbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.moveupbutton.Location = new System.Drawing.Point(84, 20);
            this.moveupbutton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.moveupbutton.Name = "moveupbutton";
            this.moveupbutton.Size = new System.Drawing.Size(45, 40);
            this.moveupbutton.TabIndex = 2;
            this.moveupbutton.UseVisualStyleBackColor = false;
            // 
            // moveleftbutton
            // 
            this.moveleftbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moveleftbutton.BackgroundImage")));
            this.moveleftbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveleftbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.moveleftbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.moveleftbutton.Location = new System.Drawing.Point(31, 75);
            this.moveleftbutton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.moveleftbutton.Name = "moveleftbutton";
            this.moveleftbutton.Size = new System.Drawing.Size(42, 40);
            this.moveleftbutton.TabIndex = 3;
            this.moveleftbutton.UseVisualStyleBackColor = true;
            // 
            // movedownbutton
            // 
            this.movedownbutton.BackgroundImage = global::GUIsf.Properties.Resources.downarrow1;
            this.movedownbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movedownbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.movedownbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.movedownbutton.Location = new System.Drawing.Point(84, 123);
            this.movedownbutton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.movedownbutton.Name = "movedownbutton";
            this.movedownbutton.Size = new System.Drawing.Size(45, 40);
            this.movedownbutton.TabIndex = 4;
            this.movedownbutton.UseVisualStyleBackColor = true;
            // 
            // econtrols
            // 
            this.econtrols.Controls.Add(this.estopbutton);
            this.econtrols.Controls.Add(this.robotinitializebutton);
            this.econtrols.Controls.Add(this.allservooffbutton);
            this.econtrols.Controls.Add(this.allservoonbutton);
            this.econtrols.Location = new System.Drawing.Point(999, 45);
            this.econtrols.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.econtrols.Name = "econtrols";
            this.econtrols.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.econtrols.Size = new System.Drawing.Size(250, 208);
            this.econtrols.TabIndex = 20;
            this.econtrols.TabStop = false;
            // 
            // estopbutton
            // 
            this.estopbutton.Active = true;
            this.estopbutton.ButtonStyle = ColorButton.ColorButton.ButtonStyles.Rectangle;
            this.estopbutton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estopbutton.ForeColor = System.Drawing.Color.Black;
            this.estopbutton.GradientStyle = ColorButton.ColorButton.GradientStyles.Vertical;
            this.estopbutton.HoverBorderColor = System.Drawing.Color.DarkRed;
            this.estopbutton.HoverColorA = System.Drawing.Color.Red;
            this.estopbutton.HoverColorB = System.Drawing.Color.DarkRed;
            this.estopbutton.Location = new System.Drawing.Point(26, 138);
            this.estopbutton.Name = "estopbutton";
            this.estopbutton.NormalBorderColor = System.Drawing.Color.Red;
            this.estopbutton.NormalColorA = System.Drawing.Color.LightCoral;
            this.estopbutton.NormalColorB = System.Drawing.Color.DarkRed;
            this.estopbutton.Size = new System.Drawing.Size(196, 35);
            this.estopbutton.SmoothingQuality = ColorButton.ColorButton.SmoothingQualities.AntiAlias;
            this.estopbutton.TabIndex = 202;
            this.estopbutton.Text = "All Alarm Reset";
            this.estopbutton.Click += new System.EventHandler(this.estopbutton_Click_1);
            // 
            // robotinitializebutton
            // 
            this.robotinitializebutton.Active = true;
            this.robotinitializebutton.ButtonStyle = ColorButton.ColorButton.ButtonStyles.Rectangle;
            this.robotinitializebutton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robotinitializebutton.ForeColor = System.Drawing.Color.White;
            this.robotinitializebutton.GradientStyle = ColorButton.ColorButton.GradientStyles.Vertical;
            this.robotinitializebutton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.robotinitializebutton.HoverColorA = System.Drawing.Color.Gray;
            this.robotinitializebutton.HoverColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.robotinitializebutton.Location = new System.Drawing.Point(26, 98);
            this.robotinitializebutton.Name = "robotinitializebutton";
            this.robotinitializebutton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.robotinitializebutton.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.robotinitializebutton.NormalColorB = System.Drawing.Color.Gray;
            this.robotinitializebutton.Size = new System.Drawing.Size(196, 34);
            this.robotinitializebutton.SmoothingQuality = ColorButton.ColorButton.SmoothingQualities.AntiAlias;
            this.robotinitializebutton.TabIndex = 200;
            this.robotinitializebutton.Text = "Robot Initialize";
            this.robotinitializebutton.Click += new System.EventHandler(this.robotinitializebutton_Click);
            // 
            // allservooffbutton
            // 
            this.allservooffbutton.Active = true;
            this.allservooffbutton.ButtonStyle = ColorButton.ColorButton.ButtonStyles.Rectangle;
            this.allservooffbutton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allservooffbutton.ForeColor = System.Drawing.Color.White;
            this.allservooffbutton.GradientStyle = ColorButton.ColorButton.GradientStyles.Vertical;
            this.allservooffbutton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allservooffbutton.HoverColorA = System.Drawing.Color.Gray;
            this.allservooffbutton.HoverColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allservooffbutton.Location = new System.Drawing.Point(26, 58);
            this.allservooffbutton.Name = "allservooffbutton";
            this.allservooffbutton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allservooffbutton.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allservooffbutton.NormalColorB = System.Drawing.Color.Gray;
            this.allservooffbutton.Size = new System.Drawing.Size(196, 34);
            this.allservooffbutton.SmoothingQuality = ColorButton.ColorButton.SmoothingQualities.AntiAlias;
            this.allservooffbutton.TabIndex = 199;
            this.allservooffbutton.Text = "All Servo OFF";
            this.allservooffbutton.Click += new System.EventHandler(this.allservooffbutton_Click);
            // 
            // allservoonbutton
            // 
            this.allservoonbutton.Active = true;
            this.allservoonbutton.ButtonStyle = ColorButton.ColorButton.ButtonStyles.Rectangle;
            this.allservoonbutton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allservoonbutton.ForeColor = System.Drawing.Color.White;
            this.allservoonbutton.GradientStyle = ColorButton.ColorButton.GradientStyles.Vertical;
            this.allservoonbutton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allservoonbutton.HoverColorA = System.Drawing.Color.Gray;
            this.allservoonbutton.HoverColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allservoonbutton.Location = new System.Drawing.Point(26, 18);
            this.allservoonbutton.Name = "allservoonbutton";
            this.allservoonbutton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allservoonbutton.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allservoonbutton.NormalColorB = System.Drawing.Color.Gray;
            this.allservoonbutton.Size = new System.Drawing.Size(196, 34);
            this.allservoonbutton.SmoothingQuality = ColorButton.ColorButton.SmoothingQualities.AntiAlias;
            this.allservoonbutton.TabIndex = 198;
            this.allservoonbutton.Text = "All Servo ON";
            this.allservoonbutton.Click += new System.EventHandler(this.allservoonbutton_Click);
            // 
            // maincontrolspanel
            // 
            this.maincontrolspanel.Controls.Add(this.alarmrstbutton);
            this.maincontrolspanel.Controls.Add(this.initbutton);
            this.maincontrolspanel.Controls.Add(this.servooffbutton);
            this.maincontrolspanel.Controls.Add(this.servoonbutton);
            this.maincontrolspanel.Location = new System.Drawing.Point(362, 48);
            this.maincontrolspanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.maincontrolspanel.Name = "maincontrolspanel";
            this.maincontrolspanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.maincontrolspanel.Size = new System.Drawing.Size(608, 67);
            this.maincontrolspanel.TabIndex = 17;
            this.maincontrolspanel.TabStop = false;
            // 
            // alarmrstbutton
            // 
            this.alarmrstbutton.Active = true;
            this.alarmrstbutton.ButtonStyle = ColorButton.ColorButton.ButtonStyles.Rectangle;
            this.alarmrstbutton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmrstbutton.ForeColor = System.Drawing.Color.White;
            this.alarmrstbutton.GradientStyle = ColorButton.ColorButton.GradientStyles.Vertical;
            this.alarmrstbutton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alarmrstbutton.HoverColorA = System.Drawing.Color.Gray;
            this.alarmrstbutton.HoverColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alarmrstbutton.Location = new System.Drawing.Point(454, 19);
            this.alarmrstbutton.Name = "alarmrstbutton";
            this.alarmrstbutton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alarmrstbutton.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alarmrstbutton.NormalColorB = System.Drawing.Color.Gray;
            this.alarmrstbutton.Size = new System.Drawing.Size(138, 34);
            this.alarmrstbutton.SmoothingQuality = ColorButton.ColorButton.SmoothingQualities.AntiAlias;
            this.alarmrstbutton.TabIndex = 202;
            this.alarmrstbutton.Text = "Alarm Reset";
            // 
            // initbutton
            // 
            this.initbutton.Active = true;
            this.initbutton.ButtonStyle = ColorButton.ColorButton.ButtonStyles.Rectangle;
            this.initbutton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initbutton.ForeColor = System.Drawing.Color.White;
            this.initbutton.GradientStyle = ColorButton.ColorButton.GradientStyles.Vertical;
            this.initbutton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.initbutton.HoverColorA = System.Drawing.Color.Gray;
            this.initbutton.HoverColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.initbutton.Location = new System.Drawing.Point(301, 19);
            this.initbutton.Name = "initbutton";
            this.initbutton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.initbutton.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.initbutton.NormalColorB = System.Drawing.Color.Gray;
            this.initbutton.Size = new System.Drawing.Size(138, 34);
            this.initbutton.SmoothingQuality = ColorButton.ColorButton.SmoothingQualities.AntiAlias;
            this.initbutton.TabIndex = 201;
            this.initbutton.Text = "Initialize";
            this.initbutton.Click += new System.EventHandler(this.initbutton_Click);
            // 
            // servooffbutton
            // 
            this.servooffbutton.Active = true;
            this.servooffbutton.ButtonStyle = ColorButton.ColorButton.ButtonStyles.Rectangle;
            this.servooffbutton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servooffbutton.ForeColor = System.Drawing.Color.White;
            this.servooffbutton.GradientStyle = ColorButton.ColorButton.GradientStyles.Vertical;
            this.servooffbutton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.servooffbutton.HoverColorA = System.Drawing.Color.Gray;
            this.servooffbutton.HoverColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.servooffbutton.Location = new System.Drawing.Point(157, 19);
            this.servooffbutton.Name = "servooffbutton";
            this.servooffbutton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.servooffbutton.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.servooffbutton.NormalColorB = System.Drawing.Color.Gray;
            this.servooffbutton.Size = new System.Drawing.Size(138, 34);
            this.servooffbutton.SmoothingQuality = ColorButton.ColorButton.SmoothingQualities.AntiAlias;
            this.servooffbutton.TabIndex = 200;
            this.servooffbutton.Text = "Servo OFF";
            this.servooffbutton.Click += new System.EventHandler(this.servooffbutton_Click);
            // 
            // servoonbutton
            // 
            this.servoonbutton.Active = true;
            this.servoonbutton.ButtonStyle = ColorButton.ColorButton.ButtonStyles.Rectangle;
            this.servoonbutton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servoonbutton.ForeColor = System.Drawing.Color.White;
            this.servoonbutton.GradientStyle = ColorButton.ColorButton.GradientStyles.Vertical;
            this.servoonbutton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.servoonbutton.HoverColorA = System.Drawing.Color.Gray;
            this.servoonbutton.HoverColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.servoonbutton.Location = new System.Drawing.Point(13, 19);
            this.servoonbutton.Name = "servoonbutton";
            this.servoonbutton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.servoonbutton.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.servoonbutton.NormalColorB = System.Drawing.Color.Gray;
            this.servoonbutton.Size = new System.Drawing.Size(138, 34);
            this.servoonbutton.SmoothingQuality = ColorButton.ColorButton.SmoothingQualities.AntiAlias;
            this.servoonbutton.TabIndex = 199;
            this.servoonbutton.Text = "Servo ON";
            this.servoonbutton.Click += new System.EventHandler(this.servoonbutton_Click);
            // 
            // axesparameterlist
            // 
            this.axesparameterlist.AllowUserToAddRows = false;
            this.axesparameterlist.AllowUserToDeleteRows = false;
            this.axesparameterlist.AllowUserToResizeColumns = false;
            this.axesparameterlist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.axesparameterlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.axesparameterlist.BackgroundColor = System.Drawing.Color.SlateGray;
            this.axesparameterlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.axesparameterlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.axesparameterlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.axesparameterlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.axesparameterlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.axesparameterlist.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.axesparameterlist.Location = new System.Drawing.Point(7, -3);
            this.axesparameterlist.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.axesparameterlist.MultiSelect = false;
            this.axesparameterlist.Name = "axesparameterlist";
            this.axesparameterlist.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.axesparameterlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.axesparameterlist.RowHeadersWidth = 20;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.axesparameterlist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.axesparameterlist.Size = new System.Drawing.Size(1275, 378);
            this.axesparameterlist.TabIndex = 0;
            this.axesparameterlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Robot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.ControlBox = false;
            this.Controls.Add(this.robotcontrolpanel);
            this.Controls.Add(this.axesparameterlist);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::GUIsf.Properties.Settings.Default, "locate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = global::GUIsf.Properties.Settings.Default.locate;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Robot";
            this.Text = "00";
            this.Load += new System.EventHandler(this.Robot_Load);
            this.robotcontrolpanel.ResumeLayout(false);
            this.robotcontrolpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.jogpitchmovepanel.ResumeLayout(false);
            this.jogpitchmovepanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.econtrols.ResumeLayout(false);
            this.maincontrolspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axesparameterlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button moveupbutton;
        private System.Windows.Forms.Button moveleftbutton;
        private System.Windows.Forms.Button movedownbutton;
        private System.Windows.Forms.Button moverightbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button jogmoveincr;
        private System.Windows.Forms.TextBox jogspeedvalue;
        private System.Windows.Forms.TextBox pitchvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox robotcontrolpanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox maincontrolspanel;
        private System.Windows.Forms.GroupBox jogpitchmovepanel;
        private System.Windows.Forms.Label axisstatuslabel;
        private System.Windows.Forms.GroupBox econtrols;
        private System.Windows.Forms.DataGridView axesparameterlist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textComm;
        private System.Windows.Forms.Label Command;
        private ColorButton.ColorButton allservooffbutton;
        private ColorButton.ColorButton allservoonbutton;
        private ColorButton.ColorButton estopbutton;
        private ColorButton.ColorButton robotinitializebutton;
        private ColorButton.ColorButton servoonbutton;
        private ColorButton.ColorButton servooffbutton;
        private ColorButton.ColorButton initbutton;
        private ColorButton.ColorButton alarmrstbutton;
        private System.Windows.Forms.Button jogspeeddecr;
        private ColorButton.ColorButton jogmvbutton;
        private ColorButton.ColorButton pitchmovebutton;
    }
}