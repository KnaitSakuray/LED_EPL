
namespace LED_EPL.Forms.Chats
{
    partial class frmChartDia_Mes_Ano
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cartesianChart4 = new LiveCharts.WinForms.CartesianChart();
            this.rjPanel1 = new LED_EPL.RJcontrols.RJPanel();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.rjRadioButton3 = new LED_EPL.RJcontrols.RJRadioButton();
            this.rjRadioButton2 = new LED_EPL.RJcontrols.RJRadioButton();
            this.rjRadioButton1 = new LED_EPL.RJcontrols.RJRadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(943, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 397);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 8);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 8);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cartesianChart4
            // 
            this.cartesianChart4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart4.Location = new System.Drawing.Point(0, 8);
            this.cartesianChart4.Name = "cartesianChart4";
            this.cartesianChart4.Size = new System.Drawing.Size(808, 381);
            this.cartesianChart4.TabIndex = 4;
            this.cartesianChart4.Text = "cartesianChart1";
            this.cartesianChart4.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart4_ChildChanged);
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel1.BorderRadius = 10;
            this.rjPanel1.Controls.Add(this.DTP1);
            this.rjPanel1.Controls.Add(this.rjRadioButton3);
            this.rjPanel1.Controls.Add(this.rjRadioButton2);
            this.rjPanel1.Controls.Add(this.rjRadioButton1);
            this.rjPanel1.Controls.Add(this.panel6);
            this.rjPanel1.Controls.Add(this.panel5);
            this.rjPanel1.Controls.Add(this.panel4);
            this.rjPanel1.Customizable = false;
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rjPanel1.Location = new System.Drawing.Point(808, 8);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(135, 381);
            this.rjPanel1.TabIndex = 3;
            this.rjPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel1_Paint);
            // 
            // DTP1
            // 
            this.DTP1.Dock = System.Windows.Forms.DockStyle.Top;
            this.DTP1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP1.Location = new System.Drawing.Point(8, 142);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(118, 33);
            this.DTP1.TabIndex = 15;
            this.DTP1.ValueChanged += new System.EventHandler(this.DTP1_ValueChanged);
            // 
            // rjRadioButton3
            // 
            this.rjRadioButton3.AutoSize = true;
            this.rjRadioButton3.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjRadioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjRadioButton3.Customizable = false;
            this.rjRadioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjRadioButton3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjRadioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjRadioButton3.Location = new System.Drawing.Point(8, 113);
            this.rjRadioButton3.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton3.Name = "rjRadioButton3";
            this.rjRadioButton3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton3.Size = new System.Drawing.Size(118, 29);
            this.rjRadioButton3.TabIndex = 14;
            this.rjRadioButton3.Text = "Ano ";
            this.rjRadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rjRadioButton3.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.rjRadioButton3.UseVisualStyleBackColor = true;
            this.rjRadioButton3.CheckedChanged += new System.EventHandler(this.rjRadioButton3_CheckedChanged);
            // 
            // rjRadioButton2
            // 
            this.rjRadioButton2.AutoSize = true;
            this.rjRadioButton2.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjRadioButton2.Customizable = false;
            this.rjRadioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjRadioButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjRadioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjRadioButton2.Location = new System.Drawing.Point(8, 84);
            this.rjRadioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton2.Name = "rjRadioButton2";
            this.rjRadioButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton2.Size = new System.Drawing.Size(118, 29);
            this.rjRadioButton2.TabIndex = 13;
            this.rjRadioButton2.Text = "Mês";
            this.rjRadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rjRadioButton2.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.rjRadioButton2.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton1
            // 
            this.rjRadioButton1.AutoSize = true;
            this.rjRadioButton1.Checked = true;
            this.rjRadioButton1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjRadioButton1.Customizable = false;
            this.rjRadioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjRadioButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjRadioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjRadioButton1.Location = new System.Drawing.Point(8, 55);
            this.rjRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton1.Name = "rjRadioButton1";
            this.rjRadioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton1.Size = new System.Drawing.Size(118, 29);
            this.rjRadioButton1.TabIndex = 12;
            this.rjRadioButton1.TabStop = true;
            this.rjRadioButton1.Text = "Dia";
            this.rjRadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rjRadioButton1.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.rjRadioButton1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(126, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(9, 326);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(8, 326);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 55);
            this.panel4.TabIndex = 0;
            // 
            // frmChartDia_Mes_Ano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 397);
            this.Controls.Add(this.cartesianChart4);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChartDia_Mes_Ano";
            this.Text = "frmChartDia_Mes_Ano";
            this.SizeChanged += new System.EventHandler(this.frmChartDia_Mes_Ano_SizeChanged);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private RJcontrols.RJPanel rjPanel1;
        private System.Windows.Forms.Panel panel4;
        private LiveCharts.WinForms.CartesianChart cartesianChart4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private RJcontrols.RJRadioButton rjRadioButton3;
        private RJcontrols.RJRadioButton rjRadioButton2;
        private RJcontrols.RJRadioButton rjRadioButton1;
        private System.Windows.Forms.DateTimePicker DTP1;
    }
}