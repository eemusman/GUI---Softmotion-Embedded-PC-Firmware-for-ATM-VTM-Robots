namespace GUIsf
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.visualProgressIndicator1 = new VisualPlus.Toolkit.Controls.DataVisualization.VisualProgressIndicator();
            this.reichGradientPanel1 = new ReichUI.Controls.ReichGradientPanel();
            this.xuiCustomPictureBox1 = new XanderUI.XUICustomPictureBox();
            this.ProgressBar2 = new XanderUI.XUIFlatProgressBar();
            this.reichGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Loading";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 37);
            this.label2.TabIndex = 37;
            this.label2.Text = "Softmotion GUI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // visualProgressIndicator1
            // 
            this.visualProgressIndicator1.AnimationColor = System.Drawing.Color.SteelBlue;
            this.visualProgressIndicator1.AnimationSpeed = 100;
            this.visualProgressIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.visualProgressIndicator1.BaseColor = System.Drawing.Color.Gray;
            this.visualProgressIndicator1.CircleSize = new System.Drawing.Size(8, 8);
            this.visualProgressIndicator1.Location = new System.Drawing.Point(108, 143);
            this.visualProgressIndicator1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualProgressIndicator1.Name = "visualProgressIndicator1";
            this.visualProgressIndicator1.Size = new System.Drawing.Size(59, 59);
            this.visualProgressIndicator1.TabIndex = 41;
            this.visualProgressIndicator1.Text = "visualProgressIndicator1";
            this.visualProgressIndicator1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualProgressIndicator1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualProgressIndicator1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualProgressIndicator1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualProgressIndicator1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualProgressIndicator1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualProgressIndicator1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // reichGradientPanel1
            // 
            this.reichGradientPanel1.Color1 = System.Drawing.Color.SteelBlue;
            this.reichGradientPanel1.Color2 = System.Drawing.Color.White;
            this.reichGradientPanel1.Controls.Add(this.xuiCustomPictureBox1);
            this.reichGradientPanel1.Controls.Add(this.label2);
            this.reichGradientPanel1.CustomCursor = false;
            this.reichGradientPanel1.DraggableForm = false;
            this.reichGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.reichGradientPanel1.Location = new System.Drawing.Point(0, -1);
            this.reichGradientPanel1.Name = "reichGradientPanel1";
            this.reichGradientPanel1.Size = new System.Drawing.Size(872, 143);
            this.reichGradientPanel1.TabIndex = 44;
            // 
            // xuiCustomPictureBox1
            // 
            this.xuiCustomPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.xuiCustomPictureBox1.BackgroundImage = global::GUIsf.Properties.Resources.ninebell_logo;
            this.xuiCustomPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.xuiCustomPictureBox1.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCustomPictureBox1.Color2 = System.Drawing.Color.DodgerBlue;
            this.xuiCustomPictureBox1.FilterAlpha = 200;
            this.xuiCustomPictureBox1.FilterEnabled = true;
            this.xuiCustomPictureBox1.Image = null;
            this.xuiCustomPictureBox1.IsElipse = false;
            this.xuiCustomPictureBox1.IsParallax = false;
            this.xuiCustomPictureBox1.Location = new System.Drawing.Point(658, 76);
            this.xuiCustomPictureBox1.Name = "xuiCustomPictureBox1";
            this.xuiCustomPictureBox1.Size = new System.Drawing.Size(213, 66);
            this.xuiCustomPictureBox1.TabIndex = 38;
            this.xuiCustomPictureBox1.Text = "xuiCustomPictureBox1";
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.BarStyle = XanderUI.XUIFlatProgressBar.Style.Flat;
            this.ProgressBar2.BorderColor = System.Drawing.Color.White;
            this.ProgressBar2.CompleteColor = System.Drawing.Color.SteelBlue;
            this.ProgressBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar2.InocmpletedColor = System.Drawing.Color.White;
            this.ProgressBar2.Location = new System.Drawing.Point(0, 194);
            this.ProgressBar2.MaxValue = 100;
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.ShowBorder = true;
            this.ProgressBar2.Size = new System.Drawing.Size(873, 27);
            this.ProgressBar2.TabIndex = 45;
            this.ProgressBar2.Text = "xuiFlatProgressBar1";
            this.ProgressBar2.Value = 50;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(873, 221);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressBar2);
            this.Controls.Add(this.reichGradientPanel1);
            this.Controls.Add(this.visualProgressIndicator1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(540, 540);
            this.Name = "Form1";
            this.Text = "d";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.reichGradientPanel1.ResumeLayout(false);
            this.reichGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private VisualPlus.Toolkit.Controls.DataVisualization.VisualProgressIndicator visualProgressIndicator1;
        private ReichUI.Controls.ReichGradientPanel reichGradientPanel1;
        private XanderUI.XUICustomPictureBox xuiCustomPictureBox1;
        private XanderUI.XUIFlatProgressBar ProgressBar2;
    }
}

