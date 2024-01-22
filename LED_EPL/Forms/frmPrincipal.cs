using LED_EPL.Class;
using LED_EPL.RJcontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_EPL.Forms
{
    public partial class frmPrincipal : Form
    {
        private DateTime dataDownTime;
        private int sec = 0;
        private int min = 0;
        private int hor = 0;

        private string localSenhaDescrip = string.Empty;

        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem2_Click_1(object sender, EventArgs e)
        {
            var res = RJMessageBox.Show(this, "Você deseja fechar o sistema?", "Exit",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res != DialogResult.Yes)
            {
                return;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            rjMenuIcon1.ForeColor = Color.Orange;
            rjMenuIconMenu.ForeColor = Color.Orange;
            rjMenuIcon3.ForeColor = Color.Orange;

            txtSenha.Text = "Senha";
            txtUsuario.Text = "Usuário";

            this.Text = this.Text + " | 1.0.1.31";
            //iconMenuItemOP.Visible = false;

 

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            LoginUser();
        }
        private void LoginUser()
        {

            //Verifica se existe
            SqlConnection con = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand("IF EXISTS(select * from [EPL].[dbo].[USERS_EPL] where matricula = @USUARIO and status_user = 1 )SELECT 1 ELSE SELECT 0", con);

            comande.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = txtUsuario.Text.Trim();

            con.Open();
            int USUARIO = Convert.ToInt32(comande.ExecuteScalar());
            con.Close();

            if (USUARIO == 1)
            {

                //Matricula pro UI
                lblRE.Text = txtUsuario.Text;
                //Senha do UI
                localSenhaDescrip = txtSenha.Text.Trim();
                //EF de acesso
                Global.Id_User = Convert.ToInt32(txtUsuario.Text.Trim());
                if (Conexao.filial == "06")
                {

                    using (EPLEntitiesModel_User entities = new EPLEntitiesModel_User())
                    {
                        //Criterio de consulta do EF que acessa o banco
                        var BD = entities.USERS_EPL.Where(e => e.matricula == Global.Id_User).ToList();
                        //separação da lista
                        foreach (var ResponseBD in BD)
                        {
                            Global.Nome = ResponseBD.nome;
                            localSenhaDescrip = ResponseBD.senha;
                            Global.Setor = ResponseBD.setor;
                            Global.Funcao = ResponseBD.funcao;
                            Global.Status_User = Convert.ToInt32(ResponseBD.status_user);
                            Global.Producao = Convert.ToInt32(ResponseBD.producao);
                            Global.Ckd = Convert.ToInt32(ResponseBD.ckd);
                            Global.Caixote = Convert.ToInt32(ResponseBD.caixote);
                            Global.Adm = Convert.ToInt32(ResponseBD.adm);
                        }
                    }
                }

                //usa a classe de criptografia para identificar a senha retornada pelo banco
                if (Cryptography.Decrypt(localSenhaDescrip).Equals(txtSenha.Text.Trim()))
                {
                    rjMenuIconMenu.Enabled = true;
                    //Reseta bloqueios
                    //DisableAll();
                    //desbloqueios
                    if (Global.Caixote == 1)
                    {
                        iconMenuItemProdução.Visible = true;
                    }
                    if (Global.Ckd == 1)
                    {
                        iconMenuItemOP.Visible = true;
                    }
                    if (Global.Producao == 1)
                    {
                        iconMenuItemMod.Visible = true;
                    }
                    if (Global.Adm == 1)
                    {
                        iconMenuItemLogin.Visible = true;
                    }

                    iconMenuItemRel.Visible = true;
                    labelAviso.Visible = true;
                    labelAviso.Text = "LOGIN REALIZADO!";
                    labelAviso.ForeColor = Color.Green;

                }
                else
                {
                    labelAviso.Visible = true;
                    labelAviso.Text = "SENHA INCORRETA";
                }
            }
            else
            {
                labelAviso.Visible = true;
                labelAviso.Text = "USUÁRIO INCORRETO";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dddd, MMMM HH:mm:ss");
            ContHoras();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoginUser();
            }
        }

        private void iconMenuItemOP_Click(object sender, EventArgs e)
        {

            lblFluxo.Text = "OP";


            panelPrincipal.Controls.Clear();

            frmCKD frm = new frmCKD();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(frm);
            this.panelPrincipal.Tag = frm;
            frm.BringToFront();
            frm.Show();

        }

        private void iconMenuItemMod_Click(object sender, EventArgs e)
        {
            lblFluxo.Text = "MODELO";


            panelPrincipal.Controls.Clear();

            frmModelo frm = new frmModelo();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(frm);
            this.panelPrincipal.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void iconMenuItemProdução_Click(object sender, EventArgs e)
        {
            lblFluxo.Text = "PRODUÇÃO";


            panelPrincipal.Controls.Clear();

            frmSelectOP frm = new frmSelectOP();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(frm);
            this.panelPrincipal.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            lblFluxo.Text = "na";


            panelPrincipal.Controls.Clear();

            frmGraficos frm = new frmGraficos();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(frm);
            this.panelPrincipal.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void iconMenuItemLogin_Click(object sender, EventArgs e)
        {

            lblFluxo.Text = "Usuários";


            panelPrincipal.Controls.Clear();

            frmLogin frm = new frmLogin();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(frm);
            this.panelPrincipal.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void TmDownTime_Tick(object sender, EventArgs e)
        {
            TimerDownTime();
        }
        private void DataDowntime()
        {
            SqlConnection conn1 = new SqlConnection(Conexao.ROTA);
            SqlCommand comande1 = new SqlCommand(" SELECT [data_hora] FROM [EPL].[dbo].[STATUS_LINHA] WHERE linha=@L and motivo='DOWNTIME' and status='PENDENTE' ", conn1);

            comande1.Parameters.Add("@L", SqlDbType.VarChar).Value = Global.Linha;

            conn1.Open();
            dataDownTime = Convert.ToDateTime(comande1.ExecuteScalar());
            conn1.Close();

            TimeSpan total = DateTime.Now.Subtract(dataDownTime);
            hor = total.Hours;
            min = total.Minutes;
            sec = total.Seconds;



        }

        private void ContHoras()
        {

            /**/
            SqlConnection conn = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand("IF EXISTS ( SELECT [id] FROM [EPL].[dbo].[STATUS_LINHA] WHERE linha=@L and status='PENDENTE') SELECT 1 ELSE SELECT 0", conn);

            comande.Parameters.Add("@L", SqlDbType.VarChar).Value = Global.Linha;

            conn.Open();
            int x = Convert.ToInt32(comande.ExecuteScalar());
            conn.Close();

            if (x == 1)
            {


                SqlConnection conn1 = new SqlConnection(Conexao.ROTA);
                SqlCommand comande1 = new SqlCommand("IF EXISTS ( SELECT [id] FROM [EPL].[dbo].[STATUS_LINHA] WHERE linha=@L and motivo='DOWNTIME' and status='PENDENTE') SELECT 1 ELSE SELECT 0", conn1);

                comande1.Parameters.Add("@L", SqlDbType.VarChar).Value = Global.Linha;

                conn1.Open();
                int x1 = Convert.ToInt32(comande1.ExecuteScalar());
                conn1.Close();
                if (x1 == 1)
                {
                    //DowntimeH
                    timer1.Stop();
                    DataDowntime();
                    TmDownTime.Start();
                    Global.statusParada = "DOWNTIME";
                    labelPausas.Text = "DOWNTIME";
                    labelPausas.ForeColor = Color.Red;
                }


                else
                {
                    labelPausas.Text = "Disponível";
                    labelPausas.ForeColor = Color.Black;
                    Global.statusParada = "LIVRE";
                    hor = 0;
                    min = 0;
                    sec = 0;
                    lblTimer.Text = String.Format("{0}:{1}:{2}", hor.ToString().PadLeft(2, '0'), min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
                }

            }

            else
            {
                labelPausas.Text = "Disponível";
                labelPausas.ForeColor = Color.Black;
                Global.statusParada = "LIVRE";
                hor = 0;
                min = 0;
                sec = 0;
                lblTimer.Text = String.Format("{0}:{1}:{2}", hor.ToString().PadLeft(2, '0'), min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
            }
            //  }
        }
        private void TimerDownTime()
        {
            SqlConnection conn1 = new SqlConnection(Conexao.ROTA);
            SqlCommand comande1 = new SqlCommand("IF EXISTS ( SELECT [id] FROM [EPL].[dbo].[STATUS_LINHA] WHERE linha=@L and motivo='DOWNTIME' and status='PENDENTE' ) SELECT 1 ELSE SELECT 0", conn1);

            comande1.Parameters.Add("@L", SqlDbType.VarChar).Value = Global.Linha;

            conn1.Open();
            int x1 = Convert.ToInt32(comande1.ExecuteScalar());
            conn1.Close();

            if (x1 == 0)
            {
                //DowntimeH
                TmDownTime.Stop();
                timer1.Start();
                sec = 0; min = 0; hor = 0;
            }
            else
            {
                labelPausas.Text = "DownTime";
                labelPausas.ForeColor = Color.Red;

                if (sec == 59)
                {
                    sec = 0;
                    min++;
                }
                else
                {
                    sec++;
                }
                if (min == 59)
                {
                    min = 0;
                    hor++;
                }

                lblTimer.Text = String.Format("{0}:{1}:{2}", hor.ToString().PadLeft(2, '0'), min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
            }

        }

        private void iconMenuItemRel_Click(object sender, EventArgs e)
        {

            lblFluxo.Text = "Relatório";

            panelPrincipal.Controls.Clear();

            FrmRelatorio frm = new FrmRelatorio();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(frm);
            this.panelPrincipal.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
    }
}
