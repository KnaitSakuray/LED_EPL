using LED_EPL.Class;
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
    public partial class FrmRelatorio : Form
    {
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            rjMenuIcon1.ForeColor = Color.ForestGreen;
            rjMenuIcon2.ForeColor = Color.Orange;
            DTP1.BorderColor = Color.Orange;
            DTP1.Value = DateTime.Now;
        }

        private void rjMenuIcon2_Click(object sender, EventArgs e)
        {
            if (rjCheckBox1.Check == true) ConsultaMonth();
            else ConsultaDay();
        }
        private void ConsultaDay()
        {

            SqlConnection conecta1 = new SqlConnection(Conexao.ROTA);
            SqlCommand comande1 = new SqlCommand(@"
             SELECT [id] as ID
            ,[data] as [Data]
            ,[data_hora] as [Hora Inicial]
            ,[linha] as Linha
            ,[turno] as Turno
            ,[duracao] as Duração
            ,[cod_categoria] as [Cod Categoria]
            ,[tipo_categoria] as [Categoria]
            ,[descricao] as Descrição
            ,[status] as [Status]
            ,[data_horaF] as [Hora Final]
            ,[duracaoM] as [Time]
            ,[setor] as [Setor]
             FROM EPL.[dbo].[DOWNTIME_LED]
             where DATEPART(YEAR, [data_hora]) =@YEAR and
             DATEPART(MONTH, [data_hora]) = @Mes and
             DATEPART(DAY, [data_hora]) = @DAY
             ORDER BY id DESC"

           , conecta1);

            comande1.Parameters.Add("@Mes", SqlDbType.VarChar).Value = DTP1.Value.Month;
            comande1.Parameters.Add("@YEAR", SqlDbType.VarChar).Value = DTP1.Value.Year;
            comande1.Parameters.Add("@DAY", SqlDbType.VarChar).Value = DTP1.Value.Day;

            conecta1.Open();
            SqlDataReader dr = comande1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            rjDataGridView1.DataSource = dt;
            rjDataGridView1.Refresh();
        }
        private void ConsultaMonth()
        {

            SqlConnection conecta1 = new SqlConnection(Conexao.ROTA);
            SqlCommand comande1 = new SqlCommand(@"
       SELECT [id] as ID
      ,[data] as [Data]
      ,[data_hora] as [Hora Inicial]
      ,[linha] as Linha
      ,[turno] as Turno
      ,[duracao] as Duração
      ,[cod_categoria] as [Cod Categoria]
      ,[tipo_categoria] as [Categoria]
      ,[descricao] as Descrição
      ,[status] as [Status]
      ,[data_horaF] as [Hora Final]
      ,[duracaoM] as [Time]
      ,[setor] as [Setor]
       FROM EPL.[dbo].[DOWNTIME_LED]
       where DATEPART(YEAR, [data_hora]) =@YEAR and
       DATEPART(MONTH, [data_hora]) = @Mes 
       ORDER BY id DESC"

           , conecta1);

            comande1.Parameters.Add("@Mes", SqlDbType.VarChar).Value = DTP1.Value.Month;
            comande1.Parameters.Add("@YEAR", SqlDbType.VarChar).Value = DTP1.Value.Year;

            conecta1.Open();
            SqlDataReader dr = comande1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            rjDataGridView1.DataSource = dt;
            rjDataGridView1.Refresh();
        }

        private void DTP1_OnValueChanged(object sender, EventArgs e)
        {
            if (rjCheckBox1.Check == true) ConsultaMonth();
            else ConsultaDay();
        }
       
        private void rjMenuIcon1_Click(object sender, EventArgs e)
        {




            if (rjDataGridView1.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < rjDataGridView1.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = rjDataGridView1.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < rjDataGridView1.Rows.Count-1; i++)
                    {
                        for (int j = 0; j < rjDataGridView1.Columns.Count; j++)
                        {
                            XcelApp.Columns.NumberFormat = "@";
                            XcelApp.Cells[i + 2, j + 1] = rjDataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }
    }
}
