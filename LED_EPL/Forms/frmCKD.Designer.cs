
namespace LED_EPL.Forms
{
    partial class frmCKD
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
            this.lblName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rjTextBox21 = new LED_EPL.RJcontrols.RJTextBox2();
            this.rjDatePicker1 = new LED_EPL.RJcontrols.RJDatePicker();
            this.lblOP = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rjToggleButton1 = new LED_EPL.RJcontrols.RJToggleButton();
            this.DgvConsulta = new LED_EPL.RJcontrols.RJDataGridView();
            this.rjButton1 = new LED_EPL.RJcontrols.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rjPanel1 = new LED_EPL.RJcontrols.RJPanel();
            this.rjButton3 = new LED_EPL.RJcontrols.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFamilia = new System.Windows.Forms.ComboBox();
            this.txtQtd = new LED_EPL.RJcontrols.RJTextBox2();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNop = new LED_EPL.RJcontrols.RJTextBox2();
            this.label2 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.rjButton2 = new LED_EPL.RJcontrols.RJButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.Location = new System.Drawing.Point(18, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 21);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Data";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rjTextBox21);
            this.panel4.Controls.Add(this.rjDatePicker1);
            this.panel4.Location = new System.Drawing.Point(17, 35);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 72);
            this.panel4.TabIndex = 17;
            // 
            // rjTextBox21
            // 
            this.rjTextBox21._Customizable = false;
            this.rjTextBox21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.rjTextBox21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjTextBox21.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.rjTextBox21.BorderRadius = 5;
            this.rjTextBox21.BorderSize = 2;
            this.rjTextBox21.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjTextBox21.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rjTextBox21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjTextBox21.Location = new System.Drawing.Point(0, 29);
            this.rjTextBox21.MultiLine = false;
            this.rjTextBox21.Name = "rjTextBox21";
            this.rjTextBox21.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox21.PasswordChar = false;
            this.rjTextBox21.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox21.PlaceHolderText = null;
            this.rjTextBox21.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjTextBox21.Size = new System.Drawing.Size(395, 35);
            this.rjTextBox21.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.rjTextBox21.TabIndex = 1;
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.rjDatePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjDatePicker1.BorderRadius = 5;
            this.rjDatePicker1.BorderSize = 2;
            this.rjDatePicker1.CustomFormat = null;
            this.rjDatePicker1.Customizable = false;
            this.rjDatePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.rjDatePicker1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjDatePicker1.Location = new System.Drawing.Point(0, 0);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(120, 25);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Padding = new System.Windows.Forms.Padding(3);
            this.rjDatePicker1.Size = new System.Drawing.Size(395, 29);
            this.rjDatePicker1.Style = LED_EPL.RJcontrols.ControlStyle.Glass;
            this.rjDatePicker1.TabIndex = 0;
            this.rjDatePicker1.Value = new System.DateTime(2021, 9, 22, 14, 45, 26, 156);
            // 
            // lblOP
            // 
            this.lblOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOP.AutoSize = true;
            this.lblOP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOP.Location = new System.Drawing.Point(781, 67);
            this.lblOP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(50, 21);
            this.lblOP.TabIndex = 16;
            this.lblOP.Text = "NºOP";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblData.Location = new System.Drawing.Point(696, 67);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(43, 21);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "Data";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(696, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Opções de Busca";
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(731, 42);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 0;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.AllowUserToResizeRows = false;
            this.DgvConsulta.AlternatingRowsColor = System.Drawing.Color.Empty;
            this.DgvConsulta.AlternatingRowsColorApply = false;
            this.DgvConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.DgvConsulta.BorderRadius = 13;
            this.DgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvConsulta.ColumnHeaderColor = System.Drawing.Color.Orange;
            this.DgvConsulta.ColumnHeaderFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvConsulta.ColumnHeaderHeight = 40;
            this.DgvConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvConsulta.ColumnHeadersHeight = 40;
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvConsulta.ColumnHeaderTextColor = System.Drawing.Color.White;
            this.DgvConsulta.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvConsulta.Customizable = false;
            this.DgvConsulta.DgvBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.DgvConsulta.EnableHeadersVisualStyles = false;
            this.DgvConsulta.GridColor = System.Drawing.Color.Gainsboro;
            this.DgvConsulta.Location = new System.Drawing.Point(17, 219);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.ReadOnly = true;
            this.DgvConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgvConsulta.RowHeaderColor = System.Drawing.Color.WhiteSmoke;
            this.DgvConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvConsulta.RowHeadersVisible = false;
            this.DgvConsulta.RowHeadersWidth = 30;
            this.DgvConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvConsulta.RowHeight = 40;
            this.DgvConsulta.RowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            this.DgvConsulta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvConsulta.RowsTextColor = System.Drawing.Color.Gray;
            this.DgvConsulta.RowTemplate.Height = 40;
            this.DgvConsulta.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            this.DgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvConsulta.SelectionTextColor = System.Drawing.Color.Gray;
            this.DgvConsulta.Size = new System.Drawing.Size(843, 266);
            this.DgvConsulta.TabIndex = 19;
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(681, 45);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 20;
            this.rjButton1.Text = "Envio Manual";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "N°OP";
            // 
            // rjPanel1
            // 
            this.rjPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel1.BorderRadius = 15;
            this.rjPanel1.Controls.Add(this.rjButton3);
            this.rjPanel1.Controls.Add(this.label5);
            this.rjPanel1.Controls.Add(this.cbFamilia);
            this.rjPanel1.Controls.Add(this.txtQtd);
            this.rjPanel1.Controls.Add(this.label4);
            this.rjPanel1.Controls.Add(this.TxtNop);
            this.rjPanel1.Controls.Add(this.label2);
            this.rjPanel1.Controls.Add(this.cbModelo);
            this.rjPanel1.Controls.Add(this.label1);
            this.rjPanel1.Controls.Add(this.rjButton1);
            this.rjPanel1.Customizable = false;
            this.rjPanel1.Location = new System.Drawing.Point(17, 118);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(843, 95);
            this.rjPanel1.TabIndex = 23;
            // 
            // rjButton3
            // 
            this.rjButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 15;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(681, 4);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(150, 40);
            this.rjButton3.TabIndex = 30;
            this.rjButton3.Text = "Consulta OP";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(9, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Família";
            // 
            // cbFamilia
            // 
            this.cbFamilia.FormattingEnabled = true;
            this.cbFamilia.Location = new System.Drawing.Point(79, 56);
            this.cbFamilia.Name = "cbFamilia";
            this.cbFamilia.Size = new System.Drawing.Size(231, 29);
            this.cbFamilia.TabIndex = 28;
            this.cbFamilia.SelectedIndexChanged += new System.EventHandler(this.cbFamilia_SelectedIndexChanged);
            // 
            // txtQtd
            // 
            this.txtQtd._Customizable = false;
            this.txtQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtQtd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtQtd.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.txtQtd.BorderRadius = 5;
            this.txtQtd.BorderSize = 2;
            this.txtQtd.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtQtd.Location = new System.Drawing.Point(396, 9);
            this.txtQtd.MultiLine = false;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQtd.PasswordChar = false;
            this.txtQtd.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtQtd.PlaceHolderText = null;
            this.txtQtd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQtd.Size = new System.Drawing.Size(108, 35);
            this.txtQtd.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.txtQtd.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(323, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "QTD OP";
            // 
            // TxtNop
            // 
            this.TxtNop._Customizable = false;
            this.TxtNop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.TxtNop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.TxtNop.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.TxtNop.BorderRadius = 5;
            this.TxtNop.BorderSize = 2;
            this.TxtNop.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TxtNop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.TxtNop.Location = new System.Drawing.Point(79, 9);
            this.TxtNop.MultiLine = false;
            this.TxtNop.Name = "TxtNop";
            this.TxtNop.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtNop.PasswordChar = false;
            this.TxtNop.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.TxtNop.PlaceHolderText = null;
            this.TxtNop.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNop.Size = new System.Drawing.Size(231, 35);
            this.TxtNop.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.TxtNop.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(326, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Modelo";
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(396, 56);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(231, 29);
            this.cbModelo.TabIndex = 23;
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 15;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(462, 67);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 40);
            this.rjButton2.TabIndex = 24;
            this.rjButton2.Text = "Cadastro Manual";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // frmCKD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 497);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.DgvConsulta);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblOP);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCKD";
            this.Text = "frmCKD";
            this.Load += new System.EventHandler(this.frmCKD_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label3;
        private RJcontrols.RJTextBox2 rjTextBox21;
        private RJcontrols.RJDatePicker rjDatePicker1;
        private RJcontrols.RJToggleButton rjToggleButton1;
        private RJcontrols.RJDataGridView DgvConsulta;
        private RJcontrols.RJButton rjButton1;
        private System.Windows.Forms.Label label1;
        private RJcontrols.RJPanel rjPanel1;
        private RJcontrols.RJTextBox2 TxtNop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbModelo;
        private RJcontrols.RJButton rjButton2;
        private RJcontrols.RJTextBox2 txtQtd;
        private System.Windows.Forms.Label label4;
        private RJcontrols.RJButton rjButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFamilia;
    }
}