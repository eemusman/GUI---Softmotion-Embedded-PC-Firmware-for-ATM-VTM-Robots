namespace GUIsf
{
    partial class RS232Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputGroup = new System.Windows.Forms.GroupBox();
            this.senddatatxtbox = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.PortCombo = new System.Windows.Forms.ComboBox();
            this.BaudCombo = new System.Windows.Forms.ComboBox();
            this.DataCombo = new System.Windows.Forms.ComboBox();
            this.ParityCombo = new System.Windows.Forms.ComboBox();
            this.StopCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendata = new ColorButton.ColorButton();
            this.ConnectButton = new ColorButton.ColorButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrecvcomm = new System.Windows.Forms.TextBox();
            this.OutputGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputGroup
            // 
            this.OutputGroup.Controls.Add(this.senddatatxtbox);
            this.OutputGroup.Controls.Add(this.OutputText);
            this.OutputGroup.Enabled = false;
            this.OutputGroup.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputGroup.Location = new System.Drawing.Point(593, 65);
            this.OutputGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputGroup.Name = "OutputGroup";
            this.OutputGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputGroup.Size = new System.Drawing.Size(337, 459);
            this.OutputGroup.TabIndex = 2;
            this.OutputGroup.TabStop = false;
            this.OutputGroup.Text = "Output";
            // 
            // senddatatxtbox
            // 
            this.senddatatxtbox.Location = new System.Drawing.Point(8, 409);
            this.senddatatxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.senddatatxtbox.MaxLength = 1500;
            this.senddatatxtbox.Multiline = true;
            this.senddatatxtbox.Name = "senddatatxtbox";
            this.senddatatxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.senddatatxtbox.Size = new System.Drawing.Size(323, 33);
            this.senddatatxtbox.TabIndex = 1;
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(8, 22);
            this.OutputText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputText.MaxLength = 1500;
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputText.Size = new System.Drawing.Size(323, 378);
            this.OutputText.TabIndex = 0;
            // 
            // PortCombo
            // 
            this.PortCombo.FormattingEnabled = true;
            this.PortCombo.Location = new System.Drawing.Point(167, 38);
            this.PortCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PortCombo.Name = "PortCombo";
            this.PortCombo.Size = new System.Drawing.Size(140, 29);
            this.PortCombo.TabIndex = 0;
            // 
            // BaudCombo
            // 
            this.BaudCombo.FormattingEnabled = true;
            this.BaudCombo.Location = new System.Drawing.Point(167, 91);
            this.BaudCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BaudCombo.Name = "BaudCombo";
            this.BaudCombo.Size = new System.Drawing.Size(140, 29);
            this.BaudCombo.TabIndex = 1;
            // 
            // DataCombo
            // 
            this.DataCombo.FormattingEnabled = true;
            this.DataCombo.Location = new System.Drawing.Point(167, 146);
            this.DataCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataCombo.Name = "DataCombo";
            this.DataCombo.Size = new System.Drawing.Size(140, 29);
            this.DataCombo.TabIndex = 2;
            // 
            // ParityCombo
            // 
            this.ParityCombo.FormattingEnabled = true;
            this.ParityCombo.Location = new System.Drawing.Point(167, 204);
            this.ParityCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParityCombo.Name = "ParityCombo";
            this.ParityCombo.Size = new System.Drawing.Size(140, 29);
            this.ParityCombo.TabIndex = 3;
            // 
            // StopCombo
            // 
            this.StopCombo.FormattingEnabled = true;
            this.StopCombo.Location = new System.Drawing.Point(167, 262);
            this.StopCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopCombo.Name = "StopCombo";
            this.StopCombo.Size = new System.Drawing.Size(140, 29);
            this.StopCombo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Baudrate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Parity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stop bits:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendata);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PortCombo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.StopCombo);
            this.groupBox1.Controls.Add(this.BaudCombo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ParityCombo);
            this.groupBox1.Controls.Add(this.DataCombo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(261, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(324, 459);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Configuration";
            // 
            // sendata
            // 
            this.sendata.Active = true;
            this.sendata.ButtonStyle = ColorButton.ColorButton.ButtonStyles.Rectangle;
            this.sendata.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendata.ForeColor = System.Drawing.Color.Black;
            this.sendata.GradientStyle = ColorButton.ColorButton.GradientStyles.Vertical;
            this.sendata.HoverBorderColor = System.Drawing.Color.White;
            this.sendata.HoverColorA = System.Drawing.Color.White;
            this.sendata.HoverColorB = System.Drawing.Color.DarkKhaki;
            this.sendata.Location = new System.Drawing.Point(186, 348);
            this.sendata.Name = "sendata";
            this.sendata.NormalBorderColor = System.Drawing.Color.DarkKhaki;
            this.sendata.NormalColorA = System.Drawing.Color.DarkKhaki;
            this.sendata.NormalColorB = System.Drawing.Color.Honeydew;
            this.sendata.Size = new System.Drawing.Size(103, 74);
            this.sendata.SmoothingQuality = ColorButton.ColorButton.SmoothingQualities.AntiAlias;
            this.sendata.TabIndex = 20;
            this.sendata.Text = "Send";
            this.sendata.Click += new System.EventHandler(this.sendata_Click_1);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Active = true;
            this.ConnectButton.ButtonStyle = ColorButton.ColorButton.ButtonStyles.Rectangle;
            this.ConnectButton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.Color.Black;
            this.ConnectButton.GradientStyle = ColorButton.ColorButton.GradientStyles.Vertical;
            this.ConnectButton.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.ConnectButton.HoverColorA = System.Drawing.Color.LightBlue;
            this.ConnectButton.HoverColorB = System.Drawing.Color.SteelBlue;
            this.ConnectButton.Location = new System.Drawing.Point(25, 348);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.NormalBorderColor = System.Drawing.Color.SteelBlue;
            this.ConnectButton.NormalColorA = System.Drawing.Color.SteelBlue;
            this.ConnectButton.NormalColorB = System.Drawing.Color.LightBlue;
            this.ConnectButton.Size = new System.Drawing.Size(110, 74);
            this.ConnectButton.SmoothingQuality = ColorButton.ColorButton.SmoothingQualities.AntiAlias;
            this.ConnectButton.TabIndex = 201;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Received Command";
            // 
            // txtrecvcomm
            // 
            this.txtrecvcomm.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecvcomm.Location = new System.Drawing.Point(772, 538);
            this.txtrecvcomm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtrecvcomm.Name = "txtrecvcomm";
            this.txtrecvcomm.Size = new System.Drawing.Size(152, 29);
            this.txtrecvcomm.TabIndex = 5;
            // 
            // RS232Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.ControlBox = false;
            this.Controls.Add(this.txtrecvcomm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OutputGroup);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::GUIsf.Properties.Settings.Default, "locate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = global::GUIsf.Properties.Settings.Default.locate;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RS232Form";
            this.Text = "RS232";
            this.OutputGroup.ResumeLayout(false);
            this.OutputGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox OutputGroup;
        private System.Windows.Forms.ComboBox PortCombo;
        private System.Windows.Forms.ComboBox BaudCombo;
        private System.Windows.Forms.ComboBox DataCombo;
        private System.Windows.Forms.ComboBox ParityCombo;
        private System.Windows.Forms.ComboBox StopCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.TextBox senddatatxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrecvcomm;
        private ColorButton.ColorButton ConnectButton;
        private ColorButton.ColorButton sendata;
    }
}

