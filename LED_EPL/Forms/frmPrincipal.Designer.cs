
namespace LED_EPL.Forms
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjPanel2 = new LED_EPL.RJcontrols.RJPanel();
            this.lblFluxo = new System.Windows.Forms.Label();
            this.rjMenuIcon3 = new LED_EPL.RJcontrols.RJMenuIcon();
            this.rjDropdownMenu1 = new LED_EPL.RJcontrols.RJDropdownMenu(this.components);
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.rjMenuIconMenu = new LED_EPL.RJcontrols.RJMenuIcon();
            this.rjDropdownMenu2 = new LED_EPL.RJcontrols.RJDropdownMenu(this.components);
            this.iconMenuItemOP = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItemMod = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItemProdução = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItemLogin = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItemRel = new FontAwesome.Sharp.IconMenuItem();
            this.rjMenuIcon1 = new LED_EPL.RJcontrols.RJMenuIcon();
            this.rjPanel1 = new LED_EPL.RJcontrols.RJPanel();
            this.labelPausas = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblRE = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.rjButton1 = new LED_EPL.RJcontrols.RJButton();
            this.txtSenha = new LED_EPL.RJcontrols.RJTextBox2();
            this.txtUsuario = new LED_EPL.RJcontrols.RJTextBox2();
            this.labelData = new System.Windows.Forms.Label();
            this.labelAviso = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TmDownTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon3)).BeginInit();
            this.rjDropdownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIconMenu)).BeginInit();
            this.rjDropdownMenu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon1)).BeginInit();
            this.rjPanel1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rjPanel2);
            this.panel1.Controls.Add(this.rjMenuIcon3);
            this.panel1.Controls.Add(this.rjMenuIconMenu);
            this.panel1.Controls.Add(this.rjMenuIcon1);
            this.panel1.Controls.Add(this.rjPanel1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.lblRE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 54);
            this.panel1.TabIndex = 0;
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel2.BorderRadius = 15;
            this.rjPanel2.Controls.Add(this.lblFluxo);
            this.rjPanel2.Customizable = false;
            this.rjPanel2.Location = new System.Drawing.Point(108, 5);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(240, 45);
            this.rjPanel2.TabIndex = 25;
            // 
            // lblFluxo
            // 
            this.lblFluxo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFluxo.AutoSize = true;
            this.lblFluxo.BackColor = System.Drawing.Color.Transparent;
            this.lblFluxo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFluxo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFluxo.Location = new System.Drawing.Point(13, 10);
            this.lblFluxo.Name = "lblFluxo";
            this.lblFluxo.Size = new System.Drawing.Size(22, 21);
            this.lblFluxo.TabIndex = 19;
            this.lblFluxo.Text = "...";
            this.lblFluxo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rjMenuIcon3
            // 
            this.rjMenuIcon3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjMenuIcon3.BackColor = System.Drawing.Color.Transparent;
            this.rjMenuIcon3.BackIcon = false;
            this.rjMenuIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjMenuIcon3.Customizable = false;
            this.rjMenuIcon3.DropdownMenu = this.rjDropdownMenu1;
            this.rjMenuIcon3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon3.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            this.rjMenuIcon3.IconColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuIcon3.IconSize = 30;
            this.rjMenuIcon3.Location = new System.Drawing.Point(1051, 10);
            this.rjMenuIcon3.Name = "rjMenuIcon3";
            this.rjMenuIcon3.Size = new System.Drawing.Size(30, 30);
            this.rjMenuIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rjMenuIcon3.TabIndex = 24;
            this.rjMenuIcon3.TabStop = false;
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.ActiveMenuItem = false;
            this.rjDropdownMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem2});
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.OwnerIsMenuButton = false;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(120, 48);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconMenuItem1.IconColor = System.Drawing.Color.DarkGray;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.iconMenuItem1.Text = "Logout";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Red;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.iconMenuItem2.Text = "Sair";
            this.iconMenuItem2.Click += new System.EventHandler(this.iconMenuItem2_Click_1);
            // 
            // rjMenuIconMenu
            // 
            this.rjMenuIconMenu.BackColor = System.Drawing.Color.Transparent;
            this.rjMenuIconMenu.BackIcon = false;
            this.rjMenuIconMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjMenuIconMenu.Customizable = false;
            this.rjMenuIconMenu.DropdownMenu = this.rjDropdownMenu2;
            this.rjMenuIconMenu.Enabled = false;
            this.rjMenuIconMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIconMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.rjMenuIconMenu.IconColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIconMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuIconMenu.IconSize = 45;
            this.rjMenuIconMenu.Location = new System.Drawing.Point(40, 5);
            this.rjMenuIconMenu.Name = "rjMenuIconMenu";
            this.rjMenuIconMenu.Size = new System.Drawing.Size(45, 45);
            this.rjMenuIconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rjMenuIconMenu.TabIndex = 23;
            this.rjMenuIconMenu.TabStop = false;
            // 
            // rjDropdownMenu2
            // 
            this.rjDropdownMenu2.ActiveMenuItem = false;
            this.rjDropdownMenu2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownMenu2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.rjDropdownMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItemOP,
            this.iconMenuItemMod,
            this.iconMenuItemProdução,
            this.iconMenuItem3,
            this.iconMenuItemLogin,
            this.iconMenuItemRel});
            this.rjDropdownMenu2.Name = "rjDropdownMenu1";
            this.rjDropdownMenu2.OwnerIsMenuButton = false;
            this.rjDropdownMenu2.Size = new System.Drawing.Size(198, 232);
            // 
            // iconMenuItemOP
            // 
            this.iconMenuItemOP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconMenuItemOP.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.iconMenuItemOP.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconMenuItemOP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemOP.Name = "iconMenuItemOP";
            this.iconMenuItemOP.Size = new System.Drawing.Size(197, 38);
            this.iconMenuItemOP.Text = "OP";
            this.iconMenuItemOP.Click += new System.EventHandler(this.iconMenuItemOP_Click);
            // 
            // iconMenuItemMod
            // 
            this.iconMenuItemMod.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconMenuItemMod.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.iconMenuItemMod.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(30)))));
            this.iconMenuItemMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemMod.Name = "iconMenuItemMod";
            this.iconMenuItemMod.Size = new System.Drawing.Size(197, 38);
            this.iconMenuItemMod.Text = "Modelo";
            this.iconMenuItemMod.Click += new System.EventHandler(this.iconMenuItemMod_Click);
            // 
            // iconMenuItemProdução
            // 
            this.iconMenuItemProdução.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconMenuItemProdução.IconChar = FontAwesome.Sharp.IconChar.StepForward;
            this.iconMenuItemProdução.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconMenuItemProdução.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemProdução.Name = "iconMenuItemProdução";
            this.iconMenuItemProdução.Size = new System.Drawing.Size(197, 38);
            this.iconMenuItemProdução.Text = "Produção";
            this.iconMenuItemProdução.Click += new System.EventHandler(this.iconMenuItemProdução_Click);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconMenuItem3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(197, 38);
            this.iconMenuItem3.Text = "Gráficos ";
            this.iconMenuItem3.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // iconMenuItemLogin
            // 
            this.iconMenuItemLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconMenuItemLogin.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconMenuItemLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconMenuItemLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemLogin.Name = "iconMenuItemLogin";
            this.iconMenuItemLogin.Size = new System.Drawing.Size(197, 38);
            this.iconMenuItemLogin.Text = "Usuários";
            this.iconMenuItemLogin.Visible = false;
            this.iconMenuItemLogin.Click += new System.EventHandler(this.iconMenuItemLogin_Click);
            // 
            // iconMenuItemRel
            // 
            this.iconMenuItemRel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconMenuItemRel.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.iconMenuItemRel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconMenuItemRel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemRel.Name = "iconMenuItemRel";
            this.iconMenuItemRel.Size = new System.Drawing.Size(197, 38);
            this.iconMenuItemRel.Text = "Relatórios";
            this.iconMenuItemRel.Visible = false;
            this.iconMenuItemRel.Click += new System.EventHandler(this.iconMenuItemRel_Click);
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
            this.rjMenuIcon1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.rjMenuIcon1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuIcon1.IconSize = 35;
            this.rjMenuIcon1.Location = new System.Drawing.Point(611, 10);
            this.rjMenuIcon1.Name = "rjMenuIcon1";
            this.rjMenuIcon1.Size = new System.Drawing.Size(35, 35);
            this.rjMenuIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rjMenuIcon1.TabIndex = 22;
            this.rjMenuIcon1.TabStop = false;
            // 
            // rjPanel1
            // 
            this.rjPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel1.BorderRadius = 15;
            this.rjPanel1.Controls.Add(this.labelPausas);
            this.rjPanel1.Controls.Add(this.lblTimer);
            this.rjPanel1.Customizable = false;
            this.rjPanel1.Location = new System.Drawing.Point(652, 3);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(240, 45);
            this.rjPanel1.TabIndex = 21;
            // 
            // labelPausas
            // 
            this.labelPausas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPausas.AutoSize = true;
            this.labelPausas.BackColor = System.Drawing.Color.Transparent;
            this.labelPausas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPausas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPausas.Location = new System.Drawing.Point(16, 11);
            this.labelPausas.Name = "labelPausas";
            this.labelPausas.Size = new System.Drawing.Size(94, 21);
            this.labelPausas.TabIndex = 19;
            this.labelPausas.Text = "Disponivel :";
            this.labelPausas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTimer.Location = new System.Drawing.Point(131, 7);
            this.lblTimer.MaximumSize = new System.Drawing.Size(100, 33);
            this.lblTimer.MinimumSize = new System.Drawing.Size(100, 33);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 33);
            this.lblTimer.TabIndex = 20;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(912, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 21);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login:";
            // 
            // lblRE
            // 
            this.lblRE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRE.AutoSize = true;
            this.lblRE.BackColor = System.Drawing.Color.White;
            this.lblRE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRE.Location = new System.Drawing.Point(967, 15);
            this.lblRE.Name = "lblRE";
            this.lblRE.Size = new System.Drawing.Size(22, 21);
            this.lblRE.TabIndex = 18;
            this.lblRE.Text = "...";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panel2);
            this.panelPrincipal.Controls.Add(this.panel19);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 54);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1084, 557);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackgroundImage = global::LED_EPL.Properties.Resources.logoLed;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(349, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 112);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 47);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(109, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 47);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "LED PAINTING Extrema";
            // 
            // panel19
            // 
            this.panel19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel19.Controls.Add(this.rjButton1);
            this.panel19.Controls.Add(this.txtSenha);
            this.panel19.Controls.Add(this.txtUsuario);
            this.panel19.Controls.Add(this.labelData);
            this.panel19.Controls.Add(this.labelAviso);
            this.panel19.Controls.Add(this.label5);
            this.panel19.Controls.Add(this.label4);
            this.panel19.Location = new System.Drawing.Point(301, 130);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(480, 276);
            this.panel19.TabIndex = 4;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 34;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(119, 186);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(247, 47);
            this.rjButton1.TabIndex = 14;
            this.rjButton1.Text = "Login";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // txtSenha
            // 
            this.txtSenha._Customizable = false;
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtSenha.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.txtSenha.BorderRadius = 5;
            this.txtSenha.BorderSize = 2;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtSenha.Location = new System.Drawing.Point(117, 102);
            this.txtSenha.MultiLine = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSenha.PasswordChar = true;
            this.txtSenha.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtSenha.PlaceHolderText = null;
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.Size = new System.Drawing.Size(250, 35);
            this.txtSenha.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.txtSenha.TabIndex = 13;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario._Customizable = false;
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.txtUsuario.BorderRadius = 5;
            this.txtUsuario.BorderSize = 2;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtUsuario.Location = new System.Drawing.Point(117, 42);
            this.txtUsuario.MultiLine = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceHolderText = null;
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.Size = new System.Drawing.Size(250, 35);
            this.txtUsuario.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.txtUsuario.TabIndex = 12;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelData.Location = new System.Drawing.Point(115, 236);
            this.labelData.MinimumSize = new System.Drawing.Size(255, 21);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(255, 21);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "..";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAviso.ForeColor = System.Drawing.Color.Red;
            this.labelAviso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAviso.Location = new System.Drawing.Point(115, 149);
            this.labelAviso.MinimumSize = new System.Drawing.Size(253, 21);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(253, 21);
            this.labelAviso.TabIndex = 10;
            this.labelAviso.Text = "...";
            this.labelAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAviso.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(113, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(113, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuário";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TmDownTime
            // 
            this.TmDownTime.Interval = 1000;
            this.TmDownTime.Tick += new System.EventHandler(this.TmDownTime_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LED PAINTING 1.0.2.33";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon3)).EndInit();
            this.rjDropdownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIconMenu)).EndInit();
            this.rjDropdownMenu2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon1)).EndInit();
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJcontrols.RJMenuIcon rjMenuIcon3;
        private RJcontrols.RJDropdownMenu rjDropdownMenu1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private RJcontrols.RJMenuIcon rjMenuIconMenu;
        private RJcontrols.RJMenuIcon rjMenuIcon1;
        private RJcontrols.RJPanel rjPanel1;
        private System.Windows.Forms.Label labelPausas;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblRE;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel19;
        private RJcontrols.RJButton rjButton1;
        private RJcontrols.RJTextBox2 txtSenha;
        private RJcontrols.RJTextBox2 txtUsuario;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private RJcontrols.RJDropdownMenu rjDropdownMenu2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemOP;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemMod;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemProdução;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private System.Windows.Forms.Timer timer1;
        private RJcontrols.RJPanel rjPanel2;
        private System.Windows.Forms.Label lblFluxo;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemLogin;
        private System.Windows.Forms.Timer TmDownTime;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemRel;
    }
}