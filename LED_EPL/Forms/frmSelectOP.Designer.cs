
namespace LED_EPL.Forms
{
    partial class frmSelectOP
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
            this.lblModelo = new System.Windows.Forms.Label();
            this.cbCKD = new System.Windows.Forms.ComboBox();
            this.rjButton1 = new LED_EPL.RJcontrols.RJButton();
            this.txtMod = new LED_EPL.RJcontrols.RJTextBox2();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblModelo.Location = new System.Drawing.Point(226, 30);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(313, 45);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Ordem de produção";
            // 
            // cbCKD
            // 
            this.cbCKD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCKD.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCKD.FormattingEnabled = true;
            this.cbCKD.Location = new System.Drawing.Point(234, 95);
            this.cbCKD.Name = "cbCKD";
            this.cbCKD.Size = new System.Drawing.Size(291, 38);
            this.cbCKD.TabIndex = 8;
            this.cbCKD.SelectedIndexChanged += new System.EventHandler(this.cbCKD_SelectedIndexChanged);
            this.cbCKD.SelectedValueChanged += new System.EventHandler(this.cbCKD_SelectedValueChanged);
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(104)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(104)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 40;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(234, 283);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(291, 121);
            this.rjButton1.TabIndex = 9;
            this.rjButton1.Text = "LINHA1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // txtMod
            // 
            this.txtMod._Customizable = false;
            this.txtMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtMod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtMod.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.txtMod.BorderRadius = 5;
            this.txtMod.BorderSize = 2;
            this.txtMod.Enabled = false;
            this.txtMod.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtMod.Location = new System.Drawing.Point(234, 186);
            this.txtMod.MultiLine = false;
            this.txtMod.Name = "txtMod";
            this.txtMod.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMod.PasswordChar = false;
            this.txtMod.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtMod.PlaceHolderText = null;
            this.txtMod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMod.Size = new System.Drawing.Size(291, 45);
            this.txtMod.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.txtMod.TabIndex = 13;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.txtMod);
            this.panelPrincipal.Controls.Add(this.rjButton1);
            this.panelPrincipal.Controls.Add(this.cbCKD);
            this.panelPrincipal.Controls.Add(this.lblModelo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(800, 450);
            this.panelPrincipal.TabIndex = 14;
            // 
            // frmSelectOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "frmSelectOP";
            this.Text = "frmSelectOP";
            this.Load += new System.EventHandler(this.frmSelectOP_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cbCKD;
        private RJcontrols.RJButton rjButton1;
        private RJcontrols.RJTextBox2 txtMod;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}