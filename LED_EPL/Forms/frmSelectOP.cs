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
    public partial class frmSelectOP : Form
    {
        public frmSelectOP()
        {
            InitializeComponent();
        }

        private void frmSelectOP_Load(object sender, EventArgs e)
        {
            LoadOP();
        }
        private void LoadOP()
        {
            SqlConnection cn10 = new SqlConnection(Conexao.ROTA);
            SqlCommand cmd10 = new SqlCommand("select ckd, COUNT(*) from [EPL].[dbo].[OP_EPL] WHERE status_op = 'PENDENTE' group by ckd order by ckd desc", cn10);

            cn10.Open();
            SqlDataReader dr = cmd10.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cbCKD.DisplayMember = "ckd";
            cbCKD.DataSource = dt;
            cbCKD.SelectedIndex = -1;


            SqlDataReader dr2 = cmd10.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);

            cbCKD.DisplayMember = "ckd";
            cbCKD.DataSource = dt2;
            cn10.Close();


        }


        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (cbCKD.Text == "")
            {
                RJMessageBox.Show("Selecionar uma OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Global.CkdInfo = cbCKD.Text;

                panelPrincipal.Controls.Clear();

                frmCaixote frm = new frmCaixote();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                this.panelPrincipal.Controls.Add(frm);
                this.panelPrincipal.Tag = frm;
                frm.BringToFront();
                frm.Show();
            }
        }
        private void SelectMod()
        {
            int v1=0;

            using (EPLEntitiesModel_User entities = new EPLEntitiesModel_User())
            {
                //Criterio de consulta do EF que acessa o banco
                var DB = entities.OP_EPL.Where(e => e.ckd == cbCKD.Text).ToList();

                foreach (var ResponseMod in DB)
                {
                    v1 = ResponseMod.modelo_id_fk;
                }
            }

            using (EPLEntitiesModel_User entities = new EPLEntitiesModel_User())
            {
                //Criterio de consulta do EF que acessa o banco
                var DB = entities.MODELO_EPL.Where(e => e.id == v1).ToList();

                foreach (var ResponseMod in DB)
                {
                    txtMod.Text = ResponseMod.modelo;
                }
            }
        }
        private void cbCKD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbCKD_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectMod();
        }
    }
}
