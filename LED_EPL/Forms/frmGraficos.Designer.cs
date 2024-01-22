
namespace LED_EPL.Forms
{
    partial class frmGraficos
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
            this.rjPanel1 = new LED_EPL.RJcontrols.RJPanel();
            this.rjMenuIcon1 = new LED_EPL.RJcontrols.RJMenuIcon();
            this.rjPanel2 = new LED_EPL.RJcontrols.RJPanel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjPanel5 = new LED_EPL.RJcontrols.RJPanel();
            this.lblAno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjPanel4 = new LED_EPL.RJcontrols.RJPanel();
            this.lblMes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjPanel3 = new LED_EPL.RJcontrols.RJPanel();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rjPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon1)).BeginInit();
            this.rjPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rjPanel5.SuspendLayout();
            this.rjPanel4.SuspendLayout();
            this.rjPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel1.BorderRadius = 0;
            this.rjPanel1.Controls.Add(this.rjMenuIcon1);
            this.rjPanel1.Controls.Add(this.rjPanel2);
            this.rjPanel1.Customizable = false;
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjPanel1.Location = new System.Drawing.Point(0, 0);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(117, 518);
            this.rjPanel1.TabIndex = 0;
            // 
            // rjMenuIcon1
            // 
            this.rjMenuIcon1.BackColor = System.Drawing.Color.Transparent;
            this.rjMenuIcon1.BackIcon = false;
            this.rjMenuIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjMenuIcon1.Customizable = false;
            this.rjMenuIcon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjMenuIcon1.DropdownMenu = null;
            this.rjMenuIcon1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon1.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.rjMenuIcon1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuIcon1.IconSize = 51;
            this.rjMenuIcon1.Location = new System.Drawing.Point(0, 119);
            this.rjMenuIcon1.Name = "rjMenuIcon1";
            this.rjMenuIcon1.Size = new System.Drawing.Size(117, 51);
            this.rjMenuIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rjMenuIcon1.TabIndex = 1;
            this.rjMenuIcon1.TabStop = false;
            this.rjMenuIcon1.Tag = "op";
            this.rjMenuIcon1.Click += new System.EventHandler(this.rjMenuIcon1_Click);
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel2.BorderRadius = 0;
            this.rjPanel2.Controls.Add(this.pieChart1);
            this.rjPanel2.Customizable = false;
            this.rjPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjPanel2.Location = new System.Drawing.Point(0, 0);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(117, 119);
            this.rjPanel2.TabIndex = 0;
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(0, 0);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(117, 119);
            this.pieChart1.TabIndex = 1;
            this.pieChart1.Text = "pieChart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rjPanel5);
            this.panel1.Controls.Add(this.rjPanel4);
            this.panel1.Controls.Add(this.rjPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(117, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 121);
            this.panel1.TabIndex = 2;
            // 
            // rjPanel5
            // 
            this.rjPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel5.BorderRadius = 10;
            this.rjPanel5.Controls.Add(this.lblAno);
            this.rjPanel5.Controls.Add(this.label2);
            this.rjPanel5.Customizable = false;
            this.rjPanel5.Location = new System.Drawing.Point(732, 2);
            this.rjPanel5.Name = "rjPanel5";
            this.rjPanel5.Size = new System.Drawing.Size(208, 117);
            this.rjPanel5.TabIndex = 2;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.Color.White;
            this.lblAno.Location = new System.Drawing.Point(29, 41);
            this.lblAno.MinimumSize = new System.Drawing.Size(163, 65);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(163, 65);
            this.lblAno.TabIndex = 9;
            this.lblAno.Text = "00000";
            this.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Produzindo no Ano";
            // 
            // rjPanel4
            // 
            this.rjPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel4.BorderRadius = 10;
            this.rjPanel4.Controls.Add(this.lblMes);
            this.rjPanel4.Controls.Add(this.label1);
            this.rjPanel4.Customizable = false;
            this.rjPanel4.Location = new System.Drawing.Point(367, 2);
            this.rjPanel4.Name = "rjPanel4";
            this.rjPanel4.Size = new System.Drawing.Size(208, 117);
            this.rjPanel4.TabIndex = 1;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.White;
            this.lblMes.Location = new System.Drawing.Point(29, 41);
            this.lblMes.MinimumSize = new System.Drawing.Size(163, 65);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(163, 65);
            this.lblMes.TabIndex = 9;
            this.lblMes.Text = "00000";
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Produzindo no Mês";
            // 
            // rjPanel3
            // 
            this.rjPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel3.BorderRadius = 10;
            this.rjPanel3.Controls.Add(this.lblDia);
            this.rjPanel3.Controls.Add(this.lblModelo);
            this.rjPanel3.Customizable = false;
            this.rjPanel3.Location = new System.Drawing.Point(9, 2);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(208, 117);
            this.rjPanel3.TabIndex = 0;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.White;
            this.lblDia.Location = new System.Drawing.Point(23, 41);
            this.lblDia.MinimumSize = new System.Drawing.Size(163, 65);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(163, 65);
            this.lblDia.TabIndex = 8;
            this.lblDia.Text = "00000";
            this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(30, 11);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(144, 21);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Produzindo no Dia";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(117, 121);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(951, 397);
            this.panelPrincipal.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 518);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rjPanel1);
            this.Name = "frmGraficos";
            this.Text = "frmGraficos";
            this.Load += new System.EventHandler(this.frmGraficos_Load);
            this.SizeChanged += new System.EventHandler(this.frmGraficos_SizeChanged);
            this.rjPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon1)).EndInit();
            this.rjPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rjPanel5.ResumeLayout(false);
            this.rjPanel5.PerformLayout();
            this.rjPanel4.ResumeLayout(false);
            this.rjPanel4.PerformLayout();
            this.rjPanel3.ResumeLayout(false);
            this.rjPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RJcontrols.RJPanel rjPanel1;
        private RJcontrols.RJMenuIcon rjMenuIcon1;
        private RJcontrols.RJPanel rjPanel2;
        private System.Windows.Forms.Panel panel1;
        private RJcontrols.RJPanel rjPanel5;
        private RJcontrols.RJPanel rjPanel4;
        private RJcontrols.RJPanel rjPanel3;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblModelo;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Timer timer1;
    }
}