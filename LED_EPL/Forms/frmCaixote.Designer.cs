
namespace LED_EPL
{
    partial class frmCaixote
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixote));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSn = new System.Windows.Forms.TextBox();
            this.rjProgressBar1 = new LED_EPL.RJcontrols.RJProgressBar();
            this.rjMenuIcon1 = new LED_EPL.RJcontrols.RJMenuIcon();
            this.rjPanel3 = new LED_EPL.RJcontrols.RJPanel();
            this.rjMenuIcon2 = new LED_EPL.RJcontrols.RJMenuIcon();
            this.txtMult = new LED_EPL.RJcontrols.RJTextBox2();
            this.label20 = new System.Windows.Forms.Label();
            this.rjPanel2 = new LED_EPL.RJcontrols.RJPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblProduzido = new System.Windows.Forms.Label();
            this.lblTdia = new System.Windows.Forms.Label();
            this.lblPendente = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.rjPanel1 = new LED_EPL.RJcontrols.RJPanel();
            this.lblOP = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCamadas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPallet = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjDataGridView1 = new LED_EPL.RJcontrols.RJDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon1)).BeginInit();
            this.rjPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon2)).BeginInit();
            this.rjPanel2.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "QR MASTER";
            // 
            // TxtSn
            // 
            this.TxtSn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSn.Location = new System.Drawing.Point(15, 42);
            this.TxtSn.Name = "TxtSn";
            this.TxtSn.Size = new System.Drawing.Size(311, 33);
            this.TxtSn.TabIndex = 9;
            this.TxtSn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSn_KeyPress_1);
            // 
            // rjProgressBar1
            // 
            this.rjProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjProgressBar1.BackColor = System.Drawing.Color.White;
            this.rjProgressBar1.ChannelColor = System.Drawing.SystemColors.ControlLight;
            this.rjProgressBar1.ChannelHeight = 15;
            this.rjProgressBar1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjProgressBar1.ForeBackColor = System.Drawing.Color.Transparent;
            this.rjProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjProgressBar1.Location = new System.Drawing.Point(332, 7);
            this.rjProgressBar1.Maximum = 1000;
            this.rjProgressBar1.Name = "rjProgressBar1";
            this.rjProgressBar1.ShowMaximun = true;
            this.rjProgressBar1.ShowValue = LED_EPL.RJcontrols.TextPosition.None;
            this.rjProgressBar1.Size = new System.Drawing.Size(472, 31);
            this.rjProgressBar1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rjProgressBar1.SliderHeight = 30;
            this.rjProgressBar1.Step = 1;
            this.rjProgressBar1.SymbolAfter = "";
            this.rjProgressBar1.SymbolBefore = "";
            this.rjProgressBar1.TabIndex = 8;
            this.rjProgressBar1.Value = 1;
            // 
            // rjMenuIcon1
            // 
            this.rjMenuIcon1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjMenuIcon1.BackColor = System.Drawing.Color.Transparent;
            this.rjMenuIcon1.BackIcon = false;
            this.rjMenuIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjMenuIcon1.Customizable = false;
            this.rjMenuIcon1.DropdownMenu = null;
            this.rjMenuIcon1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon1.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.rjMenuIcon1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuIcon1.IconSize = 70;
            this.rjMenuIcon1.Location = new System.Drawing.Point(831, 7);
            this.rjMenuIcon1.Name = "rjMenuIcon1";
            this.rjMenuIcon1.Size = new System.Drawing.Size(70, 70);
            this.rjMenuIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rjMenuIcon1.TabIndex = 7;
            this.rjMenuIcon1.TabStop = false;
            this.rjMenuIcon1.Click += new System.EventHandler(this.rjMenuIcon1_Click);
            // 
            // rjPanel3
            // 
            this.rjPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel3.BorderRadius = 0;
            this.rjPanel3.Controls.Add(this.rjMenuIcon2);
            this.rjPanel3.Controls.Add(this.txtMult);
            this.rjPanel3.Controls.Add(this.label20);
            this.rjPanel3.Customizable = false;
            this.rjPanel3.Location = new System.Drawing.Point(332, 179);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(470, 74);
            this.rjPanel3.TabIndex = 6;
            // 
            // rjMenuIcon2
            // 
            this.rjMenuIcon2.BackColor = System.Drawing.Color.Transparent;
            this.rjMenuIcon2.BackIcon = false;
            this.rjMenuIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjMenuIcon2.Customizable = false;
            this.rjMenuIcon2.DropdownMenu = null;
            this.rjMenuIcon2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon2.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.rjMenuIcon2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuIcon2.IconSize = 35;
            this.rjMenuIcon2.Location = new System.Drawing.Point(311, 21);
            this.rjMenuIcon2.Name = "rjMenuIcon2";
            this.rjMenuIcon2.Size = new System.Drawing.Size(35, 35);
            this.rjMenuIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rjMenuIcon2.TabIndex = 8;
            this.rjMenuIcon2.TabStop = false;
            this.rjMenuIcon2.Click += new System.EventHandler(this.rjMenuIcon2_Click);
            // 
            // txtMult
            // 
            this.txtMult._Customizable = false;
            this.txtMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtMult.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtMult.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.txtMult.BorderRadius = 15;
            this.txtMult.BorderSize = 2;
            this.txtMult.Enabled = false;
            this.txtMult.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtMult.Location = new System.Drawing.Point(177, 5);
            this.txtMult.MultiLine = false;
            this.txtMult.Name = "txtMult";
            this.txtMult.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMult.PasswordChar = false;
            this.txtMult.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtMult.PlaceHolderText = null;
            this.txtMult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMult.Size = new System.Drawing.Size(128, 65);
            this.txtMult.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.txtMult.TabIndex = 7;
            this.txtMult.onTextChanged += new System.EventHandler(this.txtMult_onTextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(65, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 17);
            this.label20.TabIndex = 6;
            this.label20.Text = "Multiplicador   x";
            // 
            // rjPanel2
            // 
            this.rjPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel2.BorderRadius = 10;
            this.rjPanel2.Controls.Add(this.label17);
            this.rjPanel2.Controls.Add(this.label16);
            this.rjPanel2.Controls.Add(this.label15);
            this.rjPanel2.Controls.Add(this.label14);
            this.rjPanel2.Controls.Add(this.lblProduzido);
            this.rjPanel2.Controls.Add(this.lblTdia);
            this.rjPanel2.Controls.Add(this.lblPendente);
            this.rjPanel2.Controls.Add(this.lblTop);
            this.rjPanel2.Customizable = false;
            this.rjPanel2.Location = new System.Drawing.Point(332, 267);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(471, 233);
            this.rjPanel2.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(46, 142);
            this.label17.MinimumSize = new System.Drawing.Size(140, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 21);
            this.label17.TabIndex = 20;
            this.label17.Text = "Total Pendente";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(288, 142);
            this.label16.MinimumSize = new System.Drawing.Size(140, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 21);
            this.label16.TabIndex = 19;
            this.label16.Text = "Produzido";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(288, 0);
            this.label15.MinimumSize = new System.Drawing.Size(140, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 21);
            this.label15.TabIndex = 18;
            this.label15.Text = "Total Dia";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(46, 0);
            this.label14.MinimumSize = new System.Drawing.Size(140, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 21);
            this.label14.TabIndex = 17;
            this.label14.Text = "Total OP";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProduzido
            // 
            this.lblProduzido.AutoSize = true;
            this.lblProduzido.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduzido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProduzido.Location = new System.Drawing.Point(292, 163);
            this.lblProduzido.Name = "lblProduzido";
            this.lblProduzido.Size = new System.Drawing.Size(136, 65);
            this.lblProduzido.TabIndex = 16;
            this.lblProduzido.Text = "0000";
            // 
            // lblTdia
            // 
            this.lblTdia.AutoSize = true;
            this.lblTdia.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTdia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTdia.Location = new System.Drawing.Point(292, 21);
            this.lblTdia.Name = "lblTdia";
            this.lblTdia.Size = new System.Drawing.Size(136, 65);
            this.lblTdia.TabIndex = 15;
            this.lblTdia.Text = "0000";
            // 
            // lblPendente
            // 
            this.lblPendente.AutoSize = true;
            this.lblPendente.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPendente.Location = new System.Drawing.Point(50, 163);
            this.lblPendente.Name = "lblPendente";
            this.lblPendente.Size = new System.Drawing.Size(136, 65);
            this.lblPendente.TabIndex = 14;
            this.lblPendente.Text = "0000";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTop.Location = new System.Drawing.Point(50, 21);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(136, 65);
            this.lblTop.TabIndex = 13;
            this.lblTop.Text = "0000";
            // 
            // rjPanel1
            // 
            this.rjPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel1.BorderRadius = 10;
            this.rjPanel1.Controls.Add(this.lblOP);
            this.rjPanel1.Controls.Add(this.label19);
            this.rjPanel1.Controls.Add(this.lblCamadas);
            this.rjPanel1.Controls.Add(this.label9);
            this.rjPanel1.Controls.Add(this.lblPallet);
            this.rjPanel1.Controls.Add(this.label7);
            this.rjPanel1.Controls.Add(this.lblDesc);
            this.rjPanel1.Controls.Add(this.label5);
            this.rjPanel1.Controls.Add(this.lblModelo);
            this.rjPanel1.Controls.Add(this.label2);
            this.rjPanel1.Customizable = false;
            this.rjPanel1.Location = new System.Drawing.Point(332, 42);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(472, 123);
            this.rjPanel1.TabIndex = 3;
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOP.Location = new System.Drawing.Point(365, 8);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(86, 21);
            this.lblOP.TabIndex = 14;
            this.lblOP.Text = "000000/01";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(335, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 17);
            this.label19.TabIndex = 13;
            this.label19.Text = "OP";
            // 
            // lblCamadas
            // 
            this.lblCamadas.AutoSize = true;
            this.lblCamadas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamadas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCamadas.Location = new System.Drawing.Point(173, 91);
            this.lblCamadas.Name = "lblCamadas";
            this.lblCamadas.Size = new System.Drawing.Size(39, 21);
            this.lblCamadas.TabIndex = 12;
            this.lblCamadas.Text = "QTY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(12, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Quantidade de camadas";
            // 
            // lblPallet
            // 
            this.lblPallet.AutoSize = true;
            this.lblPallet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPallet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPallet.Location = new System.Drawing.Point(159, 66);
            this.lblPallet.Name = "lblPallet";
            this.lblPallet.Size = new System.Drawing.Size(39, 21);
            this.lblPallet.TabIndex = 10;
            this.lblPallet.Text = "QTY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(12, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quantidade por Pallet";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDesc.Location = new System.Drawing.Point(83, 36);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(45, 21);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Desc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descrição";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblModelo.Location = new System.Drawing.Point(73, 9);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(68, 21);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modelo";
            // 
            // rjDataGridView1
            // 
            this.rjDataGridView1.AllowUserToResizeRows = false;
            this.rjDataGridView1.AlternatingRowsColor = System.Drawing.Color.Empty;
            this.rjDataGridView1.AlternatingRowsColorApply = false;
            this.rjDataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rjDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjDataGridView1.BorderRadius = 13;
            this.rjDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rjDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.rjDataGridView1.ColumnHeaderColor = System.Drawing.Color.Orange;
            this.rjDataGridView1.ColumnHeaderFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDataGridView1.ColumnHeaderHeight = 40;
            this.rjDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rjDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rjDataGridView1.ColumnHeadersHeight = 40;
            this.rjDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rjDataGridView1.ColumnHeaderTextColor = System.Drawing.Color.White;
            this.rjDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.rjDataGridView1.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rjDataGridView1.Customizable = false;
            this.rjDataGridView1.DgvBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjDataGridView1.EnableHeadersVisualStyles = false;
            this.rjDataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.rjDataGridView1.Location = new System.Drawing.Point(12, 96);
            this.rjDataGridView1.Name = "rjDataGridView1";
            this.rjDataGridView1.ReadOnly = true;
            this.rjDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rjDataGridView1.RowHeaderColor = System.Drawing.Color.WhiteSmoke;
            this.rjDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rjDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rjDataGridView1.RowHeadersVisible = false;
            this.rjDataGridView1.RowHeadersWidth = 30;
            this.rjDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rjDataGridView1.RowHeight = 40;
            this.rjDataGridView1.RowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            this.rjDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.rjDataGridView1.RowsTextColor = System.Drawing.Color.Gray;
            this.rjDataGridView1.RowTemplate.Height = 40;
            this.rjDataGridView1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            this.rjDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rjDataGridView1.SelectionTextColor = System.Drawing.Color.Gray;
            this.rjDataGridView1.Size = new System.Drawing.Size(292, 408);
            this.rjDataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 91.37056F;
            this.Column1.HeaderText = "Pallet";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 108.6294F;
            this.Column2.HeaderText = "SNs";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmCaixote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 520);
            this.Controls.Add(this.TxtSn);
            this.Controls.Add(this.rjProgressBar1);
            this.Controls.Add(this.rjMenuIcon1);
            this.Controls.Add(this.rjPanel3);
            this.Controls.Add(this.rjPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.rjDataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(929, 559);
            this.Name = "frmCaixote";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCaixote_Load);
            this.SizeChanged += new System.EventHandler(this.frmCaixote_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon1)).EndInit();
            this.rjPanel3.ResumeLayout(false);
            this.rjPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon2)).EndInit();
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RJcontrols.RJDataGridView rjDataGridView1;
        private RJcontrols.RJPanel rjPanel1;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblCamadas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPallet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJcontrols.RJPanel rjPanel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblProduzido;
        private System.Windows.Forms.Label lblTdia;
        private System.Windows.Forms.Label lblPendente;
        private System.Windows.Forms.Label lblTop;
        private RJcontrols.RJPanel rjPanel3;
        private RJcontrols.RJTextBox2 txtMult;
        private System.Windows.Forms.Label label20;
        private RJcontrols.RJMenuIcon rjMenuIcon1;
        private RJcontrols.RJMenuIcon rjMenuIcon2;
        private RJcontrols.RJProgressBar rjProgressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox TxtSn;
    }
}

