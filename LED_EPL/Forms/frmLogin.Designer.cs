
namespace LED_EPL.Forms
{
    partial class frmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStatus = new LED_EPL.RJcontrols.RJToggleButton();
            this.txtSenha = new LED_EPL.RJcontrols.RJTextBox2();
            this.txtSetor = new LED_EPL.RJcontrols.RJTextBox2();
            this.txtFuncao = new LED_EPL.RJcontrols.RJTextBox2();
            this.txtNome = new LED_EPL.RJcontrols.RJTextBox2();
            this.cbProducao = new LED_EPL.RJcontrols.RJCheckBox();
            this.cbOP = new LED_EPL.RJcontrols.RJCheckBox();
            this.cbPallet = new LED_EPL.RJcontrols.RJCheckBox();
            this.Dgv1 = new LED_EPL.RJcontrols.RJDataGridView();
            this.rjMenuIcon2 = new LED_EPL.RJcontrols.RJMenuIcon();
            this.rjMenuIcon1 = new LED_EPL.RJcontrols.RJMenuIcon();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatricula = new LED_EPL.RJcontrols.RJTextBox2();
            this.cbAdm = new LED_EPL.RJcontrols.RJCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(61, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(61, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Senha";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(61, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Setor";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(61, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Função";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(65, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status do usuário";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(119, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ativo";
            // 
            // tbStatus
            // 
            this.tbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbStatus.AutoSize = true;
            this.tbStatus.Location = new System.Drawing.Point(68, 322);
            this.tbStatus.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.OffBackColor = System.Drawing.Color.Gray;
            this.tbStatus.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbStatus.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbStatus.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbStatus.Size = new System.Drawing.Size(45, 22);
            this.tbStatus.TabIndex = 10;
            this.tbStatus.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha._Customizable = false;
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtSenha.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.txtSenha.BorderRadius = 5;
            this.txtSenha.BorderSize = 2;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtSenha.Location = new System.Drawing.Point(64, 145);
            this.txtSenha.MultiLine = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSenha.PasswordChar = true;
            this.txtSenha.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtSenha.PlaceHolderText = null;
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.Size = new System.Drawing.Size(250, 35);
            this.txtSenha.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.txtSenha.TabIndex = 3;
            // 
            // txtSetor
            // 
            this.txtSetor._Customizable = false;
            this.txtSetor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSetor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtSetor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtSetor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.txtSetor.BorderRadius = 5;
            this.txtSetor.BorderSize = 2;
            this.txtSetor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSetor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtSetor.Location = new System.Drawing.Point(64, 200);
            this.txtSetor.MultiLine = false;
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSetor.PasswordChar = false;
            this.txtSetor.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtSetor.PlaceHolderText = null;
            this.txtSetor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSetor.Size = new System.Drawing.Size(250, 35);
            this.txtSetor.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.txtSetor.TabIndex = 2;
            // 
            // txtFuncao
            // 
            this.txtFuncao._Customizable = false;
            this.txtFuncao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFuncao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtFuncao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtFuncao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.txtFuncao.BorderRadius = 5;
            this.txtFuncao.BorderSize = 2;
            this.txtFuncao.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFuncao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtFuncao.Location = new System.Drawing.Point(64, 256);
            this.txtFuncao.MultiLine = false;
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFuncao.PasswordChar = false;
            this.txtFuncao.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtFuncao.PlaceHolderText = null;
            this.txtFuncao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFuncao.Size = new System.Drawing.Size(250, 35);
            this.txtFuncao.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.txtFuncao.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome._Customizable = false;
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtNome.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.txtNome.BorderRadius = 5;
            this.txtNome.BorderSize = 2;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtNome.Location = new System.Drawing.Point(64, 89);
            this.txtNome.MultiLine = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtNome.PlaceHolderText = null;
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.Size = new System.Drawing.Size(250, 35);
            this.txtNome.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.txtNome.TabIndex = 0;
            // 
            // cbProducao
            // 
            this.cbProducao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbProducao.AutoSize = true;
            this.cbProducao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbProducao.BorderSize = 1;
            this.cbProducao.Check = false;
            this.cbProducao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProducao.Customizable = false;
            this.cbProducao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.cbProducao.IconColor = System.Drawing.Color.White;
            this.cbProducao.Location = new System.Drawing.Point(68, 353);
            this.cbProducao.MinimumSize = new System.Drawing.Size(0, 21);
            this.cbProducao.Name = "cbProducao";
            this.cbProducao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cbProducao.Size = new System.Drawing.Size(101, 24);
            this.cbProducao.Style = LED_EPL.RJcontrols.ControlStyle.Solid;
            this.cbProducao.TabIndex = 13;
            this.cbProducao.Text = "Produção";
            this.cbProducao.UseVisualStyleBackColor = true;
            // 
            // cbOP
            // 
            this.cbOP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbOP.AutoSize = true;
            this.cbOP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbOP.BorderSize = 1;
            this.cbOP.Check = false;
            this.cbOP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOP.Customizable = false;
            this.cbOP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.cbOP.IconColor = System.Drawing.Color.White;
            this.cbOP.Location = new System.Drawing.Point(68, 383);
            this.cbOP.MinimumSize = new System.Drawing.Size(0, 21);
            this.cbOP.Name = "cbOP";
            this.cbOP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cbOP.Size = new System.Drawing.Size(57, 24);
            this.cbOP.Style = LED_EPL.RJcontrols.ControlStyle.Solid;
            this.cbOP.TabIndex = 14;
            this.cbOP.Text = "OP";
            this.cbOP.UseVisualStyleBackColor = true;
            // 
            // cbPallet
            // 
            this.cbPallet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbPallet.AutoSize = true;
            this.cbPallet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbPallet.BorderSize = 1;
            this.cbPallet.Check = false;
            this.cbPallet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPallet.Customizable = false;
            this.cbPallet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.cbPallet.IconColor = System.Drawing.Color.White;
            this.cbPallet.Location = new System.Drawing.Point(68, 414);
            this.cbPallet.MinimumSize = new System.Drawing.Size(0, 21);
            this.cbPallet.Name = "cbPallet";
            this.cbPallet.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cbPallet.Size = new System.Drawing.Size(74, 24);
            this.cbPallet.Style = LED_EPL.RJcontrols.ControlStyle.Solid;
            this.cbPallet.TabIndex = 15;
            this.cbPallet.Text = "Pallet";
            this.cbPallet.UseVisualStyleBackColor = true;
            // 
            // Dgv1
            // 
            this.Dgv1.AllowUserToResizeRows = false;
            this.Dgv1.AlternatingRowsColor = System.Drawing.Color.Empty;
            this.Dgv1.AlternatingRowsColorApply = false;
            this.Dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv1.BorderRadius = 15;
            this.Dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv1.ColumnHeaderColor = System.Drawing.Color.Orange;
            this.Dgv1.ColumnHeaderFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv1.ColumnHeaderHeight = 40;
            this.Dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv1.ColumnHeadersHeight = 40;
            this.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv1.ColumnHeaderTextColor = System.Drawing.Color.White;
            this.Dgv1.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv1.Customizable = false;
            this.Dgv1.DgvBackColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv1.EnableHeadersVisualStyles = false;
            this.Dgv1.GridColor = System.Drawing.Color.Gainsboro;
            this.Dgv1.Location = new System.Drawing.Point(372, 31);
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.ReadOnly = true;
            this.Dgv1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dgv1.RowHeaderColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv1.RowHeadersVisible = false;
            this.Dgv1.RowHeadersWidth = 30;
            this.Dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv1.RowHeight = 40;
            this.Dgv1.RowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            this.Dgv1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv1.RowsTextColor = System.Drawing.Color.Gray;
            this.Dgv1.RowTemplate.Height = 40;
            this.Dgv1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            this.Dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv1.SelectionTextColor = System.Drawing.Color.Gray;
            this.Dgv1.Size = new System.Drawing.Size(459, 431);
            this.Dgv1.TabIndex = 16;
            this.Dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv1_CellClick);
            // 
            // rjMenuIcon2
            // 
            this.rjMenuIcon2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjMenuIcon2.BackColor = System.Drawing.Color.Transparent;
            this.rjMenuIcon2.BackIcon = false;
            this.rjMenuIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjMenuIcon2.Customizable = false;
            this.rjMenuIcon2.DropdownMenu = null;
            this.rjMenuIcon2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon2.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.rjMenuIcon2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuIcon2.IconSize = 70;
            this.rjMenuIcon2.Location = new System.Drawing.Point(274, 368);
            this.rjMenuIcon2.Name = "rjMenuIcon2";
            this.rjMenuIcon2.Size = new System.Drawing.Size(70, 70);
            this.rjMenuIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rjMenuIcon2.TabIndex = 58;
            this.rjMenuIcon2.TabStop = false;
            this.rjMenuIcon2.Click += new System.EventHandler(this.rjMenuIcon2_Click);
            // 
            // rjMenuIcon1
            // 
            this.rjMenuIcon1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjMenuIcon1.BackColor = System.Drawing.Color.Transparent;
            this.rjMenuIcon1.BackIcon = false;
            this.rjMenuIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjMenuIcon1.Customizable = false;
            this.rjMenuIcon1.DropdownMenu = null;
            this.rjMenuIcon1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.rjMenuIcon1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.rjMenuIcon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuIcon1.IconSize = 70;
            this.rjMenuIcon1.Location = new System.Drawing.Point(185, 368);
            this.rjMenuIcon1.Name = "rjMenuIcon1";
            this.rjMenuIcon1.Size = new System.Drawing.Size(70, 70);
            this.rjMenuIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rjMenuIcon1.TabIndex = 57;
            this.rjMenuIcon1.TabStop = false;
            this.rjMenuIcon1.Click += new System.EventHandler(this.rjMenuIcon1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(61, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula._Customizable = false;
            this.txtMatricula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtMatricula.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtMatricula.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.txtMatricula.BorderRadius = 5;
            this.txtMatricula.BorderSize = 2;
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtMatricula.Location = new System.Drawing.Point(64, 31);
            this.txtMatricula.MultiLine = false;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMatricula.PasswordChar = false;
            this.txtMatricula.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtMatricula.PlaceHolderText = null;
            this.txtMatricula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatricula.Size = new System.Drawing.Size(250, 35);
            this.txtMatricula.Style = LED_EPL.RJcontrols.Desing.TextBoxStyle.MatteBorder;
            this.txtMatricula.TabIndex = 59;
            // 
            // cbAdm
            // 
            this.cbAdm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAdm.AutoSize = true;
            this.cbAdm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbAdm.BorderSize = 1;
            this.cbAdm.Check = false;
            this.cbAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAdm.Customizable = false;
            this.cbAdm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.cbAdm.IconColor = System.Drawing.Color.White;
            this.cbAdm.Location = new System.Drawing.Point(68, 442);
            this.cbAdm.MinimumSize = new System.Drawing.Size(0, 21);
            this.cbAdm.Name = "cbAdm";
            this.cbAdm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cbAdm.Size = new System.Drawing.Size(72, 24);
            this.cbAdm.Style = LED_EPL.RJcontrols.ControlStyle.Solid;
            this.cbAdm.TabIndex = 61;
            this.cbAdm.Text = "ADM";
            this.cbAdm.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 475);
            this.Controls.Add(this.cbAdm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.rjMenuIcon2);
            this.Controls.Add(this.rjMenuIcon1);
            this.Controls.Add(this.Dgv1);
            this.Controls.Add(this.cbPallet);
            this.Controls.Add(this.cbOP);
            this.Controls.Add(this.cbProducao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.txtNome);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjMenuIcon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJcontrols.RJTextBox2 txtNome;
        private RJcontrols.RJTextBox2 txtFuncao;
        private RJcontrols.RJTextBox2 txtSetor;
        private RJcontrols.RJTextBox2 txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RJcontrols.RJToggleButton tbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private RJcontrols.RJCheckBox cbProducao;
        private RJcontrols.RJCheckBox cbOP;
        private RJcontrols.RJCheckBox cbPallet;
        private RJcontrols.RJDataGridView Dgv1;
        private RJcontrols.RJMenuIcon rjMenuIcon2;
        private RJcontrols.RJMenuIcon rjMenuIcon1;
        private System.Windows.Forms.Label label7;
        private RJcontrols.RJTextBox2 txtMatricula;
        private RJcontrols.RJCheckBox cbAdm;
    }
}