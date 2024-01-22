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
    public partial class frmLogin : Form
    {
        private int Modelo, Op, Caixote,Status_User,Adm;

        private string Matricula, nome, senha, setor, função, status_user, producao, op, pallet, Adm1;
        public frmLogin()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            rjMenuIcon1.ForeColor = Color.Orange;
            rjMenuIcon2.ForeColor = Color.Orange;
        }

        private void rjMenuIcon1_Click(object sender, EventArgs e)
        {
            InsertU();
        }

        private void NivelCad()
        {
            Modelo = 0;
            Op = 0;
            Caixote = 0;
            Status_User = 0;
            Adm = 0;

            if (cbProducao.Check.Equals(true)) Modelo = 1;
            if (cbOP.Check.Equals(true)) Op = 1;
            if (cbPallet.Check.Equals(true)) Caixote = 1;
            if (tbStatus.Checked.Equals(true)) Status_User = 1;
            if (cbAdm.Checked.Equals(true)) Adm = 1;

        }

        private void InsertU()
        {

            NivelCad();

            string Password = Cryptography.Encrypt(txtSenha.Text.Trim());

            SqlConnection con = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand("IF EXISTS(select * from [EPL].[dbo].[USERS_EPL] where matricula = @USUARIO)SELECT 1 ELSE SELECT 0", con);

            comande.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = txtMatricula.Text;

            con.Open();
            int USUARIO = Convert.ToInt32(comande.ExecuteScalar());
            con.Close();

            if (USUARIO == 1)
            {
                RJMessageBox.Show(this, "Usuário Já cadastrado", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                //INSERI NOVO USUARIO
                SqlConnection con1 = new SqlConnection(Conexao.ROTA);
                SqlCommand comande1 = new SqlCommand(@"
                INSERT INTO [EPL].[dbo].[USERS_EPL]
                ([matricula],[nome],[senha],[setor],[funcao],[status_user],[producao],[ckd],[caixote],[adm])
                VALUES (@MA,@NOME,@SENHA,@SETOR,@FUNCAO,@SU,@PRO,@CKD,@CA,@AD)"
               , con1);

                comande1.Parameters.Add("@MA", SqlDbType.VarChar).Value = txtMatricula.Text;
                comande1.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtNome.Text;
                comande1.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = Password;
                comande1.Parameters.Add("@SETOR", SqlDbType.VarChar).Value = txtSetor.Text;
                comande1.Parameters.Add("@FUNCAO", SqlDbType.VarChar).Value = txtFuncao.Text;
                comande1.Parameters.Add("@SU", SqlDbType.Int).Value = Status_User;
                comande1.Parameters.Add("@PRO", SqlDbType.Int).Value = Modelo;
                comande1.Parameters.Add("@CKD", SqlDbType.Int).Value = Op;
                comande1.Parameters.Add("@CA", SqlDbType.Int).Value = Caixote;
                comande1.Parameters.Add("@AD", SqlDbType.Int).Value = Adm;


                con1.Open();
                comande1.ExecuteScalar();
                con1.Close();

                RJMessageBox.Show(this, "Usuário cadastrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAll();
            }
        }

        private void Dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Matricula = Dgv1.CurrentRow.Cells[0].Value.ToString();
            nome = Dgv1.CurrentRow.Cells[1].Value.ToString();
            senha = Dgv1.CurrentRow.Cells[2].Value.ToString();
            setor = Dgv1.CurrentRow.Cells[3].Value.ToString();
            função = Dgv1.CurrentRow.Cells[4].Value.ToString();
            status_user = Dgv1.CurrentRow.Cells[5].Value.ToString();
            producao = Dgv1.CurrentRow.Cells[6].Value.ToString();
            op = Dgv1.CurrentRow.Cells[7].Value.ToString();
            pallet = Dgv1.CurrentRow.Cells[8].Value.ToString();
            Adm1 = Dgv1.CurrentRow.Cells[9].Value.ToString();

            txtMatricula.Text = Matricula;
            txtFuncao.Text = função;
            txtNome.Text = nome;
            txtSetor.Text = setor;
            txtSenha.Text = Cryptography.Decrypt(senha);

            if (producao == "SIM") cbProducao.Checked = true; else cbProducao.Checked = false;
            if (op == "SIM") cbOP.Checked = true; else cbOP.Checked = false;
            if (pallet== "SIM") cbPallet.Checked = true; else cbPallet.Checked = false;
            if (Adm1 == "SIM") cbAdm.Checked = true; else cbAdm.Checked = false;
        }

        private void rjMenuIcon2_Click(object sender, EventArgs e)
        {
            UpdateU();
        }

        private void UpdateU()
        {

            NivelCad();

            string Password = Cryptography.Encrypt(txtSenha.Text.Trim());

            SqlConnection con = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand("IF EXISTS(select * from [EPL].[dbo].[USERS_EPL] where matricula = @USUARIO)SELECT 1 ELSE SELECT 0", con);

            comande.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = txtMatricula.Text;

            con.Open();
            int USUARIO = Convert.ToInt32(comande.ExecuteScalar());
            con.Close();

            if (USUARIO == 1)
            {

                //INSERI NOVO USUARIO
                SqlConnection con1 = new SqlConnection(Conexao.ROTA);
                SqlCommand comande1 = new SqlCommand(@"

                UPDATE [EPL].[dbo].[USERS_EPL]
                SET 
                [nome] = @NOME
               ,[senha] = @SENHA
               ,[setor] = @SETOR
               ,[funcao] = @FUNCAO
               ,[status_user] = @SU
               ,[producao] = @PRO
               ,[ckd] = @CKD
               ,[caixote] = @CA
               ,[adm]=@AD

               WHERE matricula=@MA"
               , con1);

                comande1.Parameters.Add("@MA", SqlDbType.VarChar).Value = txtMatricula.Text;
                comande1.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtNome.Text;
                comande1.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = Password;
                comande1.Parameters.Add("@SETOR", SqlDbType.VarChar).Value = txtSetor.Text;
                comande1.Parameters.Add("@FUNCAO", SqlDbType.VarChar).Value = txtFuncao.Text;
                comande1.Parameters.Add("@SU", SqlDbType.Int).Value = Status_User;
                comande1.Parameters.Add("@PRO", SqlDbType.Int).Value = Modelo;
                comande1.Parameters.Add("@CKD", SqlDbType.Int).Value = Op;
                comande1.Parameters.Add("@CA", SqlDbType.Int).Value = Caixote;
                comande1.Parameters.Add("@AD", SqlDbType.Int).Value = Adm;


                con1.Open();
                comande1.ExecuteScalar();
                con1.Close();

                MessageBox.Show(this, "Usuário cadastrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAll();
            }
            else
            {
                RJMessageBox.Show(this, "Usuário cadastrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ClearAll()
        {

            txtMatricula.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSetor.Text = string.Empty;
            txtFuncao.Text = string.Empty;
            cbOP.Checked = false;
            cbPallet.Checked = false;
            cbProducao.Check = false;
            tbStatus.Checked = false;

            LoadUsers();

        }
        private void LoadUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection myConn = new SqlConnection(Conexao.ROTA);
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("[EPL].dbo.GetMatriculas_EPL", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            Dgv1.DataSource = dt;
            Dgv1.AutoResizeColumns();
        }
    }
}
