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
    public partial class FrmDowntime : Form
    {
        private int sec = 0, Vs = 0;
        private int min = 0, Vm = 0;
        private int hor = 0, Vh = 0;
        private int turno = 0;
        private DateTime data;
        private int ID = 0;
        private string CodCat = "";

        public FrmDowntime()
        {
            InitializeComponent();
            rjMenuIcon1.Visible = false;
        }
        private void HaveDownTimeActive()
        {
            int exist = 0;
            // CARREGA A  DATA HORA
            SqlConnection cona = new SqlConnection(Conexao.ROTA);
            SqlCommand comandea = new SqlCommand(@"
            IF EXISTS(select top 1 * from [EPL].[dbo].[DOWNTIME_LED] where status='PENDENTE' and linha=@L)SELECT 1 ELSE SELECT 0", cona);
            comandea.Parameters.Add("@L", SqlDbType.VarChar).Value = Global.Linha;
            cona.Open();
            exist = (int)comandea.ExecuteScalar();
            cona.Close();
            if (exist == 1) Existe();
            else
            {

                button1.Visible = true;
                button2.Visible = true;

                if (!(RJMessageBox.Show("Confirmar parada do posto embalagem.", "Aviso [Downtime]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.Close();
                }
                else
                {
                    timer1.Start();
                    button1.Visible = false;
                    Insert();
                }
            }
        }
        private void FrmDowntime_Load(object sender, EventArgs e)
        {
            rjMenuIcon1.ForeColor = Color.Green;
            HaveDownTimeActive();
        }
        private void Cont()
        {
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
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            rjMenuIcon1.Visible = true;
            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon1.ForeColor = Color.Green;
        }
        private void LoadDataHora()
        {
            // CARREGA A  DATA HORA
            SqlConnection cona = new SqlConnection(Conexao.ROTA);
            SqlCommand comandea = new SqlCommand("Select getdate()", cona);
            cona.Open();
            data = Convert.ToDateTime(comandea.ExecuteScalar());
            cona.Close();

        }
        private void Existe()
        {
            LoadDataHora();
            TimeSpan total;
            DateTime dataConsulta, dataNow;

            dataNow = data;
            dataConsulta = data;


            SqlConnection cona = new SqlConnection(Conexao.ROTA);
            SqlCommand comandea = new SqlCommand(@"
            SELECT top 1 [data_hora],[id]
            FROM [EPL].[dbo].[DOWNTIME_LED]
            where status='PENDENTE' and linha=@L", cona);

            comandea.Parameters.Add("@L", SqlDbType.VarChar).Value = Global.Linha;

            cona.Open();
            SqlDataReader dr = comandea.ExecuteReader();
            DataTable dt = new DataTable();

            while (dr.Read())
            {
                ID = Convert.ToInt32(dr["id"]);
                dataConsulta = Convert.ToDateTime(dr["data_hora"]);

                break;
            }
            cona.Close();

            lblIDdowntime.Text = ID.ToString();

            total = data.Subtract(dataConsulta);
            hor = total.Hours;
            min = total.Minutes;
            sec = total.Seconds;

            lblH.Text = hor.ToString().PadLeft(2, '0');
            lblM.Text = min.ToString().PadLeft(2, '0');
            lblS.Text = sec.ToString().PadLeft(2, '0');

            timer1.Start();

            labelAvisos.Text = "Parada já solicitada";
            labelAvisos.ForeColor = Color.Red;

            button2.Visible = true;

        }
        private void Turno()
        {
            if (data.Hour >= 4 && data.Hour < 16)
            {
                turno = 1;
            }
            else
            {
                turno = 2;
            }
        }
        private void Conversor()
        {
            Vh = (Convert.ToInt32(lblH.Text.Trim()) * 60) * 60;
            Vm = (Convert.ToInt32(lblM.Text.Trim()) * 60);
            Vs = (Convert.ToInt32(lblS.Text.Trim()));
        }
        private void ConsultaCodCat()
        {
            // CARREGA A  DATA HORA
            SqlConnection cona = new SqlConnection(Conexao.ROTA);
            SqlCommand comandea = new SqlCommand(@"
            SELECT [Id]
            FROM [EPL].[dbo].[C_DOWNTIME]
            where nome = @Tipo and setor = @setor", cona);
            comandea.Parameters.Add("@setor", SqlDbType.VarChar).Value = CBsetor.Text;
            comandea.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = CBmotivo.Text;
            cona.Open();
            CodCat = comandea.ExecuteScalar().ToString();
            cona.Close();
        }
        private void Insert()
        {
            LoadDataHora();
            Turno();

            SqlConnection conecta1 = new SqlConnection(Conexao.ROTA);
            SqlCommand comande1 = new SqlCommand(@" 
         
            INSERT INTO [EPL].[dbo].[DOWNTIME_LED]
            ([data],[data_hora],[linha],[turno],[duracao],[descricao],[status],[duracaoM],[pausa])
		    VALUES(@data,@datahora,@linha,@turno,'','','PENDENTE','','NPROGRAMADA')SELECT SCOPE_IDENTITY()

            INSERT INTO [EPL].[dbo].[STATUS_LINHA] ([status],[motivo],[linha],[data_hora]) VALUES ('PENDENTE','DOWNTIME',@linha,@datahora)
            ", conecta1);
            comande1.Parameters.Add("@data", SqlDbType.VarChar).Value = data.ToString().Substring(0, 10);
            comande1.Parameters.Add("@datahora", SqlDbType.VarChar).Value = data.ToString();
            comande1.Parameters.Add("@linha", SqlDbType.VarChar).Value = Global.Linha;
            comande1.Parameters.Add("@turno", SqlDbType.VarChar).Value = turno;

            conecta1.Open();
            ID = Convert.ToInt32(comande1.ExecuteScalar());
            conecta1.Close();
            lblIDdowntime.Text = ID.ToString();

       

        }
        private void Update1()
        {
            if (CBmotivo.Text == "")
            {
                labelAvisos.Text = "Preencher todos os campos";
                labelAvisos.ForeColor = Color.Red;
            }

            {
                ConsultaCodCat();
                LoadDataHora();
                Conversor();

                SqlConnection conecta1 = new SqlConnection(Conexao.ROTA);
                SqlCommand comande1 = new SqlCommand(@"
       UPDATE [EPL].[dbo].[DOWNTIME_LED] SET 
       [duracao] = @Segundos
      ,[tipo_categoria] = @TipoCat
      ,[status] = 'FINALIZADO'
      ,[data_horaF] = @datahora
      ,[cod_categoria] = @CodC
      ,[duracaoM] = @dataTime
      ,[setor] = @setor
      ,[descricao] = @desc
       WHERE id=@IDD 

       DELETE FROM [EPL].[dbo].[STATUS_LINHA] WHERE motivo='DOWNTIME' and linha=@L

       ", conecta1);
                comande1.Parameters.Add("@L", SqlDbType.VarChar).Value = Global.Linha;
                comande1.Parameters.Add("@IDD", SqlDbType.VarChar).Value = ID.ToString();
                comande1.Parameters.Add("@desc", SqlDbType.VarChar).Value = txtObs.Text;
                comande1.Parameters.Add("@datahora", SqlDbType.VarChar).Value = data.ToString();
                comande1.Parameters.Add("@Segundos", SqlDbType.VarChar).Value = (Vh + Vm + Vs);
                comande1.Parameters.Add("@CodC", SqlDbType.VarChar).Value = CodCat.ToString();
                comande1.Parameters.Add("@setor", SqlDbType.VarChar).Value = CBsetor.Text;
                comande1.Parameters.Add("@TipoCat", SqlDbType.VarChar).Value = CBmotivo.Text;
                comande1.Parameters.Add("@dataTime", SqlDbType.VarChar).Value = lblH.Text.Trim() + ":" + lblM.Text.Trim() + ":" + lblS.Text.Trim();
                conecta1.Open();
                comande1.ExecuteScalar();
                conecta1.Close();
            }
        }
        private void CBsetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCbBoxMotivo();
        }
        private void loadCbBoxSetor()
        {

            SqlConnection cn10 = new SqlConnection(Conexao.ROTA);
            SqlCommand cmd10 = new SqlCommand("select distinct setor FROM [EPL].[dbo].C_DOWNTIME order by setor", cn10);

            cn10.Open();

            SqlDataReader dr10 = cmd10.ExecuteReader();
            DataTable dt10 = new DataTable();
            dt10.Load(dr10);
            CBsetor.DisplayMember = "setor";
            CBsetor.DataSource = dt10;
            cn10.Close();
            CBsetor.SelectedIndex = -1;



        }
        private void loadCbBoxMotivo()
        {
            SqlConnection cn10 = new SqlConnection(Conexao.ROTA);
            SqlCommand cmd101 = new SqlCommand("select  nome   FROM [EPL].[dbo].C_DOWNTIME where setor=@Setor order by nome", cn10);

            cmd101.Parameters.Add("@Setor", SqlDbType.VarChar).Value = CBsetor.Text;

            cn10.Open();

            SqlDataReader dr101 = cmd101.ExecuteReader();
            DataTable dt101 = new DataTable();
            dt101.Load(dr101);
            CBmotivo.DisplayMember = "nome";
            CBmotivo.DataSource = dt101;
            cn10.Close();
            CBmotivo.SelectedIndex = -1;

        }
        private void rjMenuIcon1_Click(object sender, EventArgs e)
        {
            Update1();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cont();
            lblH.Text = hor.ToString().PadLeft(2, '0');
            lblMs.Text = min.ToString().PadLeft(2, '0');
            lblSs.Text = sec.ToString().PadLeft(2, '0');
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Global.statusParada == "LIVRE")
            {
                this.Close();
            }
        }
        //INSERT INTO table2
        //SELECT* FROM table1;
    }
}
