using LED_EPL.Class;
using LED_EPL.Forms.Chats;
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
    public partial class frmGraficos : Form
    {
        public frmGraficos()
        {
            InitializeComponent();
            LoadProducao();
        }

        private void rjMenuIcon1_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();

            frmChartDia_Mes_Ano frm = new frmChartDia_Mes_Ano();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(frm);
            this.panelPrincipal.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void frmGraficos_Load(object sender, EventArgs e)
        {
            rjPanel1.BackColor= Color.FromArgb(255, 152, 104);
            rjPanel2.BackColor = Color.FromArgb(255, 152, 104);
            rjPanel3.BackColor = Color.FromArgb(255, 152, 104);
            rjPanel4.BackColor = Color.FromArgb(255, 152, 104);
            rjPanel5.BackColor = Color.FromArgb(255, 152, 104);
        }

        private void frmGraficos_SizeChanged(object sender, EventArgs e)
        {
            rjPanel1.Refresh();
        }
        private void LoadProducao()
        {

            SqlConnection conm = new SqlConnection(Conexao.ROTA);

            SqlCommand cmdom = new SqlCommand(@"
SELECT count(sn) as total
FROM [EPL].[dbo].[CAIXOTE_EPL]
where 
DATEPART(YEAR, datahora) =(SELECT DATEPART(YEAR, (select GETDATE()))) and
DATEPART(MONTH, datahora) = (SELECT DATEPART(MONTH, (select GETDATE()))) and
DATEPART(DAY, datahora) = (SELECT DATEPART(DAY, (select GETDATE())))
", conm);

            SqlCommand cmdomq = new SqlCommand(@"
SELECT count(sn) as total
FROM [EPL].[dbo].[CAIXOTE_EPL]
where DATEPART(YEAR, datahora) =(SELECT DATEPART(YEAR, (select GETDATE()))) and
DATEPART(MONTH, datahora) = (SELECT DATEPART(MONTH, (select GETDATE())))"
, conm);

            SqlCommand cmdor = new SqlCommand(@"
SELECT count(sn) as total
FROM [EPL].[dbo].[CAIXOTE_EPL]
where DATEPART(YEAR, datahora) =(SELECT DATEPART(YEAR, (select GETDATE()))) 
", conm);

            conm.Open();

            lblDia.Text = cmdom.ExecuteScalar().ToString();
            lblMes.Text = cmdomq.ExecuteScalar().ToString();
            lblAno.Text = cmdor.ExecuteScalar().ToString();

            conm.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadProducao();
        }
    }
}
