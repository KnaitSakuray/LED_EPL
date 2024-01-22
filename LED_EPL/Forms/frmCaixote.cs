using LED_EPL.Class;
using LED_EPL.Forms;
using LED_EPL.RJcontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_EPL
{
    public partial class frmCaixote : Form
    {
        private string SN_painting,SN_Pallet;
        DateTime DATET;
        int v2 = 0;
        public frmCaixote()
        {
            InitializeComponent();
            LoadInfoOP();
            v2 = Convert.ToInt16(lblPallet.Text);
            rjProgressBar1.Maximum = v2;
            rjProgressBar1.Value = 0;
            calculos();
        }

        private void frmCaixote_SizeChanged(object sender, EventArgs e)
        {
            rjDataGridView1.Refresh();
        }

        private void frmCaixote_Load(object sender, EventArgs e)
        {
      
            rjMenuIcon1.ForeColor = Color.Red;
            rjMenuIcon2.ForeColor = Color.Orange;
            
        }
        private void LoadInfoOP()
        {
            SqlConnection conecta = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand(@"
            SELECT [id]
            ,[modelo] as Modelo
            ,[descricao] 
            ,[qtd_painel] as Qtd_Pallet
            ,[familia]
	        ,O.qtd as qtd
	        ,O.filial as filial
            FROM [EPL].[dbo].[MODELO_EPL] AS M
            INNER JOIN [EPL].[dbo].[OP_EPL] AS O ON O.modelo_id_fk=M.id
            where O.ckd=@Ckd
            ", conecta);

            comande.Parameters.Add("@Ckd", SqlDbType.VarChar).Value = Global.CkdInfo;
            conecta.Open();
            SqlDataReader dr = comande.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conecta.Close();
            lblOP.Text = Global.CkdInfo;
            lblModelo.Text = dt.Rows[0]["Modelo"].ToString().Trim();
            lblDesc.Text = dt.Rows[0]["descricao"].ToString().Trim();
            lblPallet.Text = dt.Rows[0]["Qtd_Pallet"].ToString().Trim();
            lblCamadas.Text = dt.Rows[0]["familia"].ToString().Trim();
            lblTop.Text = dt.Rows[0]["qtd"].ToString().Trim();
            txtMult.Text = lblPallet.Text;
        }
        private void calculos()
        {
            SqlConnection con1 = new SqlConnection(Conexao.ROTA);
            SqlCommand comande1 = new SqlCommand(@"
            SELECT count(sn) as total
            FROM [EPL].[dbo].[CAIXOTE_EPL]
            where ckd=@Ckd
            ", con1);
            comande1.Parameters.Add("@Ckd", SqlDbType.VarChar).Value = Global.CkdInfo;
            con1.Open();
            int v1  = Convert.ToInt32(comande1.ExecuteScalar());
            con1.Close();

            lblProduzido.Text = v1.ToString();

            lblPendente.Text = (v1 - Convert.ToInt32(lblTop.Text)).ToString();

            SqlConnection con = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand(@"
            SELECT count(sn) as total
            FROM [EPL].[dbo].[CAIXOTE_EPL]
            where 
            DATEPART(YEAR, datahora) =(SELECT DATEPART(YEAR, (select GETDATE()))) and
            DATEPART(MONTH, datahora) = (SELECT DATEPART(MONTH, (select GETDATE()))) and
            DATEPART(DAY, datahora) = (SELECT DATEPART(DAY, (select GETDATE())))
            ", con);
            con.Open();
            int v2 = Convert.ToInt32(comande.ExecuteScalar());
            con.Close();

            lblTdia.Text = v2.ToString();

        }

        private void rjMenuIcon1_Click(object sender, EventArgs e)
        {
            FrmDowntime Frm = new FrmDowntime();
            Frm.Show();
        }

        private void rjMenuIcon2_Click(object sender, EventArgs e)
        {
            if (txtMult.Enabled == true) { txtMult.Enabled = false; lblPallet.Text = txtMult.Text.ToString(); }
            else txtMult.Enabled = true;
        }
        Thread threadPrincipal;
        private void TxtSn_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void DateServer()
        {
            SqlConnection con = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand("SELECT GETDATE()", con);

            con.Open();
             DATET = Convert.ToDateTime(comande.ExecuteScalar());
            con.Close();
        }

        private void txtMult_onTextChanged(object sender, EventArgs e)
        {
          //  lblPallet.Text = txtMult.Text;
        }

        private void TxtSn_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                SqlConnection conn1 = new SqlConnection(Conexao.ROTA);
                SqlCommand comande1 = new SqlCommand("IF EXISTS(SELECT *  FROM [EPL].[dbo].[CAIXOTE_EPL] where id_pallet=@PA)SELECT 1 ELSE SELECT 0", conn1);

                comande1.Parameters.Add("@PA", SqlDbType.VarChar).Value = TxtSn.Text.Trim();

                conn1.Open();
                int x1 = Convert.ToInt32(comande1.ExecuteScalar());
                conn1.Close();

                if (x1 == 1)
                {
                    RJMessageBox.Show("SN Pallet já scaneado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (TxtSn.Text.Substring(TxtSn.Text.Length - 6) != lblOP.Text.Substring(0, 6))
                    {
                        RJMessageBox.Show("SN não pertence a essa OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {

                        if (TxtSn.Text.Length.Equals(15))
                        {
                            SN_Pallet = TxtSn.Text.Trim();

                            Generate_Inserts_SNs();

                            TxtSn.Text = "";
                        }
                        else
                        {
                            RJMessageBox.Show("SN Pallet Incorreto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                calculos();
            }
        }

        private void Generate_Inserts_SNs()
        {
            
            DateServer();
            SqlConnection con1 = new SqlConnection(Conexao.ROTA);
            con1.Open();

            rjProgressBar1.Maximum = v2;
            rjProgressBar1.Value = 0;
            rjProgressBar1.Step = 1;
          
            for (long i = 1; i <= Convert.ToInt64(lblPallet.Text.Trim()); i++)
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(rjDataGridView1);

                item.Cells[0].Value = SN_Pallet;
               
                rjProgressBar1.PerformStep();
                // cria uma linha
                SN_painting = SN_Pallet + DATET.ToString("ddMMyy")+i.ToString().PadLeft(4,'0');
                // seta os valores
                item.Cells[1].Value = SN_painting;

                SqlCommand comande1 = new SqlCommand(@"
                INSERT INTO EPL.[dbo].[CAIXOTE_EPL]
               ([id_pallet],[sn],[modelo],[ckd],[linha],[data],[datahora],[filial])
               VALUES (@id_pallet,@sn,@modelo,@ckd,@linha,@data,@datahora,@filial)"
               , con1);
                comande1.Parameters.Add("@id_pallet", SqlDbType.VarChar).Value = SN_Pallet;
                comande1.Parameters.Add("@sn", SqlDbType.VarChar).Value = SN_painting;
                comande1.Parameters.Add("@modelo", SqlDbType.VarChar).Value = lblModelo.Text;
                comande1.Parameters.Add("@ckd", SqlDbType.VarChar).Value = Global.CkdInfo;
                comande1.Parameters.Add("@linha", SqlDbType.VarChar).Value = Global.Linha;
                comande1.Parameters.Add("@data", SqlDbType.Date).Value = DATET.ToString().Substring(0,10);
                comande1.Parameters.Add("@datahora", SqlDbType.DateTime).Value = DATET.ToString();
                comande1.Parameters.Add("@filial", SqlDbType.VarChar).Value = Conexao.filial;
                comande1.ExecuteScalar();
                rjDataGridView1.Rows.Add(item);
                SN_painting = string.Empty;
            }

            con1.Close();
           
            TxtSn.Focus();
        }
    }
}
