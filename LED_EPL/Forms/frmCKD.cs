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
    // TESTE...
    public partial class frmCKD : Form
    {
        private string DataD;
        public frmCKD()
        {
            InitializeComponent();
            LoadFamily();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            InsertU();
            LoadOP();
        }
 

        private void GetDateServer()
        {
            SqlConnection con = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand("SELECT GETDATE() AS DATE", con);

            con.Open();
            DataD = comande.ExecuteScalar().ToString();
            con.Close();
        }
        private void LoadFamily()
        {

            SqlConnection conB = new SqlConnection(Conexao.ROTA);
            SqlCommand comandeB = new SqlCommand("select DISTINCT(familia) from [EPL].[dbo].[MODELO_EPL] order by familia", conB);
            conB.Open();
            SqlDataReader dr = comandeB.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);


            cbFamilia.DisplayMember = "familia";
            cbFamilia.DataSource = dt;
            cbFamilia.SelectedIndex = -1;

            SqlDataReader dr2 = comandeB.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);

            cbFamilia.DisplayMember = "familia";
            cbFamilia.DataSource = dt2;

        }
        private void LoadModWherFamy()
        {
            SqlConnection conB = new SqlConnection(Conexao.ROTA);
            SqlCommand comandeB = new SqlCommand("select DISTINCT(modelo) from [EPL].[dbo].[MODELO_EPL] where familia=@F order by modelo", conB);
            comandeB.Parameters.Add("@F", SqlDbType.VarChar).Value = cbFamilia.Text;
            conB.Open();
            SqlDataReader dr = comandeB.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cbModelo.DisplayMember = "modelo";
            cbModelo.DataSource = dt;
            cbModelo.SelectedIndex = -1;


            SqlDataReader dr2 = comandeB.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);

            cbModelo.DisplayMember = "modelo";
            cbModelo.DataSource = dt2;
        }
        private void InsertU()
        {

            GetDateServer();

            SqlConnection con = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand("IF EXISTS(select * from [EPL].[dbo].[OP_EPL] where [ckd] = @CKD)SELECT 1 ELSE SELECT 0", con);
            comande.Parameters.Add("@CKD", SqlDbType.VarChar).Value = TxtNop.Text;
            con.Open();
            int USUARIO = Convert.ToInt32(comande.ExecuteScalar());
            con.Close();

            if (USUARIO == 1)
            {
                RJMessageBox.Show(this, "OP Já cadastrada", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //INSERI NOVO USUARIO
                SqlConnection con1 = new SqlConnection(Conexao.ROTA);
                SqlCommand comande1 = new SqlCommand(@"
            DECLARE @ID_MOD int;
            SET  @ID_MOD = (SELECT [id] FROM [EPL].[dbo].[MODELO_EPL] where [modelo]=@modelo)
            INSERT INTO [EPL].[dbo].[OP_EPL]
            ([ckd],[modelo_id_fk],[status_op],[data],[data_hora],[qtd],[user_id],[filial])
            VALUES (@ckd,@ID_MOD,'PENDENTE',@data,@data_hora,@qtd,@user_id,@filia)"
               , con1);

                comande1.Parameters.Add("@ckd", SqlDbType.VarChar).Value = TxtNop.Text;
                comande1.Parameters.Add("@qtd", SqlDbType.VarChar).Value = txtQtd.Text;
                comande1.Parameters.Add("@user_id", SqlDbType.VarChar).Value = Global.Id_User;
                comande1.Parameters.Add("@data", SqlDbType.VarChar).Value = DataD.Substring(0,10);
                comande1.Parameters.Add("@data_hora", SqlDbType.VarChar).Value = DataD;
                comande1.Parameters.Add("@filia", SqlDbType.VarChar).Value = Conexao.filial;
                comande1.Parameters.Add("@modelo", SqlDbType.VarChar).Value = cbModelo.Text;


                con1.Open();
                comande1.ExecuteScalar();
                con1.Close();

                RJMessageBox.Show(this, "OP cadastrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAll();
            }
        }
        private void LoadOP()
        {
            //carrega datagridview cliente
            SqlConnection con6 = new SqlConnection(Conexao.ROTA);
            SqlCommand comande6 = new SqlCommand(@" 
         SELECT [ckd] AS OP
         ,M.[modelo] AS Modelo
         ,[status_op]
         ,[data]
         ,[data_hora]
         ,[qtd]
         ,[qtd_atual]
         ,[ordem]
         ,[user_id] AS Usuário
         ,[filial]
         ,[description]
         FROM [EPL].[dbo].[OP_EPL] as O
         INNER JOIN [EPL].[dbo].[MODELO_EPL] AS M ON O.modelo_id_fk=M.id
         order by op desc
            ", con6);

            con6.Open();
            SqlDataReader dr = comande6.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DgvConsulta.DataSource = dt;
            con6.Close();
        }
        private void ClearAll()
        {

        }
        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            LoadOP();
        }

        private void cbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadModWherFamy();
        }

        private void frmCKD_Load(object sender, EventArgs e)
        {

        }
    }
}
