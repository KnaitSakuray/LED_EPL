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
    public partial class frmModelo : Form
    {
        public frmModelo()
        {
            InitializeComponent();
            LoadFamily();
            LoadFamilyCad();
            LoadMod();
        }

        private void frmModelo_Load(object sender, EventArgs e)
        {
            rjMenuIcon1.ForeColor = Color.Orange;
            rjMenuIcon2.ForeColor = Color.Orange;
            rjMenuIcon3.ForeColor = Color.Orange;
        }

        private void rjMenuIcon1_Click(object sender, EventArgs e)
        {
            InsertMod();
            LoadFamily();
            LoadFamilyCad();
            LoadMod();
        }
        private void LoadFamily()
        {

            SqlConnection conB = new SqlConnection(Conexao.ROTA);
            SqlCommand comandeB = new SqlCommand("select DISTINCT(familia) from [EPL].[dbo].[MODELO_EPL] order by familia", conB);
            conB.Open();
            SqlDataReader dr = comandeB.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);


            cbFamiliaCon.DisplayMember = "familia";
            cbFamiliaCon.DataSource = dt;
            cbFamiliaCon.SelectedIndex = -1;

            SqlDataReader dr2 = comandeB.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);

            cbFamiliaCon.DisplayMember = "familia";
            cbFamiliaCon.DataSource = dt2;

        }
        private void LoadFamilyCad()
        {

            SqlConnection conB = new SqlConnection(Conexao.ROTA);
            SqlCommand comandeB = new SqlCommand("select DISTINCT(familia) from [EPL].[dbo].[MODELO_EPL] order by familia", conB);
            conB.Open();
            SqlDataReader dr = comandeB.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            CBfamilyCad.DisplayMember = "familia";
            CBfamilyCad.DataSource = dt;
            CBfamilyCad.DropDownHeight = CBfamilyCad.ItemHeight * 18;
            CBfamilyCad.SelectedIndex = -1;

            SqlDataReader dr2 = comandeB.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);

            CBfamilyCad.DisplayMember = "familia";
            CBfamilyCad.DataSource = dt2;

        }

        private void LoadMod()
        {
            SqlConnection conB = new SqlConnection(Conexao.ROTA);
            SqlCommand comandeB = new SqlCommand("select DISTINCT(modelo) from [EPL].[dbo].[MODELO_EPL] order by modelo", conB);
            conB.Open();
            SqlDataReader dr = comandeB.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cbModelo.DisplayMember = "codigo";
            cbModelo.DataSource = dt;
            cbModelo.SelectedIndex = -1;


            SqlDataReader dr2 = comandeB.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);

            cbModelo.DisplayMember = "codigo";
            cbModelo.DataSource = dt2;

        }
        private void LoadModWherFamy()
        {
            SqlConnection conB = new SqlConnection(Conexao.ROTA);
            SqlCommand comandeB = new SqlCommand("select DISTINCT(modelo) from [EPL].[dbo].[MODELO_EPL] where familia=@F order by modelo", conB);
            comandeB.Parameters.Add("@F", SqlDbType.VarChar).Value = cbFamiliaCon.Text;
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
        private void ClearALL()
        {
            txtMod.Text = "";
            TxtDesc.Text = "";
            TxtQtd.Text = "";
            CBfamilyCad.Text = "";
        }
        private void InsertMod()
        {
            //If exist Mod

            SqlConnection conn1 = new SqlConnection(Conexao.ROTA);
            SqlCommand comande1 = new SqlCommand("IF EXISTS(SELECT *  FROM [EPL].[dbo].[MODELO_EPL] where modelo=@PA)SELECT 1 ELSE SELECT 0", conn1);

            comande1.Parameters.Add("@PA", SqlDbType.VarChar).Value = txtMod.Text;

            conn1.Open();
            int x1 = Convert.ToInt32(comande1.ExecuteScalar());
            conn1.Close();
            if (x1 != 1)
            {
                //Insert Mod
                SqlConnection conecta12 = new SqlConnection(Conexao.ROTA);
                SqlCommand comande12 = new SqlCommand(@"
                INSERT INTO [EPL].[dbo].[MODELO_EPL]
                ([modelo],[descricao],[qtd_painel],[familia])
                VALUES (@codigo,@descricao,@qtd,@familia)
                ", conecta12);
                comande12.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtMod.Text.Trim();
                comande12.Parameters.Add("@descricao", SqlDbType.VarChar).Value = TxtDesc.Text;
                comande12.Parameters.Add("@qtd", SqlDbType.VarChar).Value = TxtQtd.Text;
                comande12.Parameters.Add("@familia", SqlDbType.VarChar).Value = CBfamilyCad.Text;
                conecta12.Open();
                comande12.ExecuteReader();
                conecta12.Close();
                ClearALL();
            }
        }

        private void UpdateBd()
        {

            //IF exist Mod

            SqlConnection conn1 = new SqlConnection(Conexao.ROTA);
            SqlCommand comande1 = new SqlCommand("IF EXISTS(SELECT *  FROM [EPL].[dbo].[MODELO_EPL] where modelo=@PA)SELECT 1 ELSE SELECT 0", conn1);

            comande1.Parameters.Add("@PA", SqlDbType.VarChar).Value = cbModelo.Text.Trim();

            conn1.Open();
            int x1 = Convert.ToInt32(comande1.ExecuteScalar());
            conn1.Close();
            if (x1 == 1)
            {
                //Insert Mod
                SqlConnection conecta12 = new SqlConnection(Conexao.ROTA);
                SqlCommand comande12 = new SqlCommand(@"
       UPDATE [EPL].[dbo].[MODELO_EPL]
       SET [modelo] = @codigo,[descricao] = @descricao,[qtd_painel] = @qtd,[familia] = @familia
       where modelo=@codigo
      ", conecta12);


                comande12.Parameters.Add("@codigo", SqlDbType.VarChar).Value = cbModelo.Text.Trim();
                comande12.Parameters.Add("@descricao", SqlDbType.VarChar).Value = TxtDesc.Text;
                comande12.Parameters.Add("@qtd", SqlDbType.VarChar).Value = TxtQtd.Text;
                comande12.Parameters.Add("@familia", SqlDbType.VarChar).Value = CBfamilyCad.Text;

                conecta12.Open();
                comande12.ExecuteReader();
                conecta12.Close();

                RJMessageBox.Show("Atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void SelectMod()
        {
            if (Conexao.filial == "06")
            {
                using (EPLEntitiesModel_User entities = new EPLEntitiesModel_User())
                {
                    //Criterio de consulta do EF que acessa o banco
                    var DB = entities.MODELO_EPL.Where(e => e.modelo == cbModelo.Text).ToList();

                    foreach (var ResponseMod in DB)
                    {
                        txtMod.Text = ResponseMod.modelo;
                        TxtDesc.Text = ResponseMod.descricao;
                        TxtQtd.Text = ResponseMod.qtd_painel.ToString();
                        CBfamilyCad.Text = ResponseMod.familia;
                    }
                }
            }
        }
        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SelectMod();
        }

        private void rjMenuIcon2_Click(object sender, EventArgs e)
        {
            UpdateBd();
        }

        private void cbFamiliaCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadModWherFamy();
        }
    }
}
