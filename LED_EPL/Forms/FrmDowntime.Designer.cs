
namespace LED_EPL.Forms
{
    partial class FrmDowntime
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
            this.labelAvisos = new System.Windows.Forms.Label();
            this.lblIDdowntime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSs = new System.Windows.Forms.Label();
            this.lblMs = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBmotivo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBsetor = new System.Windows.Forms.ComboBox();
            this.txtObs = new LED_EPL.RJcontrols.RJTextBox2();
            this.button1 = new LED_EPL.RJcontrols.RJButton();
            this.button2 = new LED_EPL.RJcontrols.RJButton();
            this.rjMenuIcon1 = new LED_EPL.RJcontrols.RJMenuIcon();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAvisos
            // 
            this.labelAvisos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAvisos.AutoSize = true;
            this.labelAvisos.BackColor = System.Drawing.Color.White;
            this.labelAvisos.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisos.ForeColor = System.Drawing.Color.Red;
            this.labelAvisos.Location = new System.Drawing.Point(373, 48);
            this.labelAvisos.Name = "labelAvisos";
            this.labelAvisos.Size = new System.Drawing.Size(282, 40);
            this.labelAvisos.TabIndex = 57;
            this.labelAvisos.Text = "Parada já solicitada";
            this.labelAvisos.Visible = false;
            // 
            // lblIDdowntime
            // 
            this.lblIDdowntime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDdowntime.AutoSize = true;
            this.lblIDdowntime.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDdowntime.Location = new System.Drawing.Point(713, 8);
            this.lblIDdowntime.Name = "lblIDdowntime";
            this.lblIDdowntime.Size = new System.Drawing.Size(33, 30);
            this.lblIDdowntime.TabIndex = 71;
            this.lblIDdowntime.Text = "....";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(600, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 70;
            this.label7.Text = "DownTime ID:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 69;
            this.label6.Text = "Motivo";
            // 
            // lblSs
            // 
            this.lblSs.AutoSize = true;
            this.lblSs.BackColor = System.Drawing.Color.Transparent;
            this.lblSs.Font = new System.Drawing.Font("Segoe UI Semibold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSs.Location = new System.Drawing.Point(529, 239);
            this.lblSs.Name = "lblSs";
            this.lblSs.Size = new System.Drawing.Size(161, 128);
            this.lblSs.TabIndex = 68;
            this.lblSs.Text = "00";
            this.lblSs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMs
            // 
            this.lblMs.AutoSize = true;
            this.lblMs.BackColor = System.Drawing.Color.Transparent;
            this.lblMs.Font = new System.Drawing.Font("Segoe UI Semibold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMs.Location = new System.Drawing.Point(297, 239);
            this.lblMs.Name = "lblMs";
            this.lblMs.Size = new System.Drawing.Size(161, 128);
            this.lblMs.TabIndex = 67;
            this.lblMs.Text = "00";
            this.lblMs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.BackColor = System.Drawing.Color.Transparent;
            this.lblH.Font = new System.Drawing.Font("Segoe UI Semibold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(76, 239);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(161, 128);
            this.lblH.TabIndex = 62;
            this.lblH.Text = "00";
            this.lblH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 128);
            this.label2.TabIndex = 65;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.BackColor = System.Drawing.Color.Transparent;
            this.lblM.Font = new System.Drawing.Font("Segoe UI Semibold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(76, 239);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(161, 128);
            this.lblM.TabIndex = 63;
            this.lblM.Text = "00";
            this.lblM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.BackColor = System.Drawing.Color.Transparent;
            this.lblS.Font = new System.Drawing.Font("Segoe UI Semibold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(76, 239);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(161, 128);
            this.lblS.TabIndex = 64;
            this.lblS.Text = "00";
            this.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 128);
            this.label3.TabIndex = 66;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 61;
            this.label1.Text = "Motivo";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(44, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 21);
            this.label16.TabIndex = 60;
            this.label16.Text = "Setor";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.CBmotivo);
            this.panel2.Location = new System.Drawing.Point(45, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 35);
            this.panel2.TabIndex = 59;
            // 
            // CBmotivo
            // 
            this.CBmotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBmotivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBmotivo.FormattingEnabled = true;
            this.CBmotivo.Location = new System.Drawing.Point(3, 3);
            this.CBmotivo.Name = "CBmotivo";
            this.CBmotivo.Size = new System.Drawing.Size(694, 29);
            this.CBmotivo.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.CBsetor);
            this.panel1.Location = new System.Drawing.Point(45, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 35);
            this.panel1.TabIndex = 58;
            // 
            // CBsetor
            // 
            this.CBsetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBsetor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBsetor.FormattingEnabled = true;
            this.CBsetor.Items.AddRange(new object[] {
            "PRODUÇÃO",
            "ENGENHARIA",
            "QUALIDADE",
            "MANUTENÇÃO"});
            this.CBsetor.Location = new System.Drawing.Point(3, 3);
            this.CBsetor.Name = "CBsetor";
            this.CBsetor.Size = new System.Drawing.Size(260, 29);
            this.CBsetor.TabIndex = 36;
            this.CBsetor.SelectedIndexChanged += new System.EventHandler(this.CBsetor_SelectedIndexChanged);
            // 
            // txtObs
            // 
            this.txtObs._Customizable = false;
            this.txtObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtObs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtObs.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.txtObs.BorderRadius = 5;
            this.txtObs.BorderSize = 2;
            this.txtObs.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtObs.Location = new System.Drawing.Point(45, 166);
            this.txtObs.MultiLine = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtObs.PasswordChar = false;
            this.txtObs.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtObs.PlaceHolderText = null;
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObs.Size = new System.Drawing.Size(700, 70);
            this.txtObs.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.txtObs.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(252)))), ((int)(((byte)(151)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(252)))), ((int)(((byte)(151)))));
            this.button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button1.BorderRadius = 15;
            this.button1.BorderSize = 0;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(79, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 76);
            this.button1.TabIndex = 73;
            this.button1.Text = "&INICIAR";
            this.button1.TextColor = System.Drawing.Color.Black;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundColor = System.Drawing.Color.Red;
            this.button2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button2.BorderRadius = 15;
            this.button2.BorderSize = 0;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(408, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 76);
            this.button2.TabIndex = 74;
            this.button2.Text = "&FINALIZAR";
            this.button2.TextColor = System.Drawing.Color.Black;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjMenuIcon1
            // 
            this.rjMenuIcon1.BackColor = System.Drawing.Color.Transparent;
            this.rjMenuIcon1.BackIcon = false;
            this.rjMenuIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjMenuIcon1.Customizable = false;
            this.rjMenuIcon1.DropdownMenu = null;
            this.rjMenuIcon1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.rjMenuIcon1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuIcon1.IconSize = 70;
            this.rjMenuIcon1.Location = new System.Drawing.Point(704, 370);
            this.rjMenuIcon1.Name = "rjMenuIcon1";
            this.rjMenuIcon1.Size = new System.Drawing.Size(70, 70);
            this.rjMenuIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rjMenuIcon1.TabIndex = 75;
            this.rjMenuIcon1.TabStop = false;
            this.rjMenuIcon1.Click += new System.EventHandler(this.rjMenuIcon1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmDowntime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rjMenuIcon1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.labelAvisos);
            this.Controls.Add(this.lblIDdowntime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSs);
            this.Controls.Add(this.lblMs);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDowntime";
            this.Text = "FrmDowntime";
            this.Load += new System.EventHandler(this.FrmDowntime_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAvisos;
        private System.Windows.Forms.Label lblIDdowntime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSs;
        private System.Windows.Forms.Label lblMs;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBmotivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBsetor;
        private RJcontrols.RJTextBox2 txtObs;
        private RJcontrols.RJButton button1;
        private RJcontrols.RJButton button2;
        private RJcontrols.RJMenuIcon rjMenuIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}