using LED_EPL.Class;
using LiveCharts;
using LiveCharts.Wpf;
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

namespace LED_EPL.Forms.Chats
{
    public partial class frmChartDia_Mes_Ano : Form
    {
        public frmChartDia_Mes_Ano()
        {
            InitializeComponent();

            DTP1.Value = DateTime.Now;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            rjPanel1.BackColor = Color.FromArgb(255, 152, 104);
            rjRadioButton1.ForeColor = Color.White;
            rjRadioButton2.ForeColor = Color.White;
            rjRadioButton3.ForeColor = Color.White;
        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmChartDia_Mes_Ano_SizeChanged(object sender, EventArgs e)
        {
            rjPanel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadChar()
        {
           
                cartesianChart4.Series.Clear();
                cartesianChart4.AxisX.Clear();
                cartesianChart4.AxisY.Clear();

                SqlConnection conecta1 = new SqlConnection(Conexao.ROTA);
                SqlCommand comande1 = new SqlCommand(@"
SELECT DATEPART(DAY,datahora) as DIA,count(sn) as TOTAL
FROM [EPL].[dbo].[CAIXOTE_EPL]
where DATEPART(YEAR, datahora) =@YEAR and
DATEPART(MONTH, datahora) = @MONTH
group by day([datahora]),YEAR ([datahora])
order by day([datahora])ASC", conecta1);

                comande1.Parameters.Add("@MONTH", SqlDbType.VarChar).Value = DTP1.Value.Month;
                comande1.Parameters.Add("@YEAR", SqlDbType.VarChar).Value = DTP1.Value.Year;
                comande1.Parameters.Add("@DAY", SqlDbType.VarChar).Value = DTP1.Value.Day;
                conecta1.Open();
                SqlDataReader dr1 = comande1.ExecuteReader();




            ColumnSeries col = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<int>(),
                LabelPoint = Point => Point.Y.ToString(),
                StrokeThickness = 30,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 128, 0)),
                Title = "Quantidade",
                //Fill = System.Windows.Media.Brushes.LightSteelBlue,
                //LineSmoothness = 10,
                //PointGeometrySize = 12,
                FontSize = 14,
                Foreground = System.Windows.Media.Brushes.Black


            };
            Axis ax = new Axis()
            {
                FontSize = 18,

                Title = "DIAS",
                //   LabelsRotation = 20,
                Foreground = System.Windows.Media.Brushes.Black,
                Separator = new Separator()
                {

                    Step = 1,
                    IsEnabled = false,

                }
            };

            ax.Labels = new List<string>();

            ax.Labels = new List<string>();
                while (dr1.Read())
                {


                    col.Values.Add(Convert.ToInt32(dr1["TOTAL"].ToString()));
                    ax.Labels.Add(dr1["DIA"].ToString());

                }



            cartesianChart4.Series.Add(col);
            cartesianChart4.AxisX.Add(ax);
            cartesianChart4.AxisY.Add(new Axis
            {

                FontSize = 18,
                Foreground = System.Windows.Media.Brushes.Black,
                Title = "QUANTIDADE",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
            }

            );
            conecta1.Close();
        }
        private void LoadCharHora()
        {

            cartesianChart4.Series.Clear();
            cartesianChart4.AxisX.Clear();
            cartesianChart4.AxisY.Clear();

            SqlConnection conecta1 = new SqlConnection(Conexao.ROTA);
            SqlCommand comande1 = new SqlCommand(@"
SELECT DATEPART(HOUR,datahora) as HORA,count(sn) as TOTAL
FROM [EPL].[dbo].[CAIXOTE_EPL]
where DATEPART(YEAR, datahora) =@YEAR and
DATEPART(MONTH, datahora) = @MONTH and
DATEPART(DAY, datahora) = @DAY
group by day([datahora]),YEAR ([datahora]),DATEPART(HOUR,datahora)
order by day([datahora])ASC", conecta1);

            comande1.Parameters.Add("@MONTH", SqlDbType.VarChar).Value = DTP1.Value.Month;
            comande1.Parameters.Add("@YEAR", SqlDbType.VarChar).Value = DTP1.Value.Year;
            comande1.Parameters.Add("@DAY", SqlDbType.VarChar).Value = DTP1.Value.Day;
            conecta1.Open();
            SqlDataReader dr1 = comande1.ExecuteReader();



            ColumnSeries col = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<int>(),
                LabelPoint = Point => Point.Y.ToString(),
                StrokeThickness = 30,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 128, 0)),
                Title = "Quantidade",
                //Fill = System.Windows.Media.Brushes.LightSteelBlue,
                //LineSmoothness = 10,
                //PointGeometrySize = 12,
                FontSize = 14,
                Foreground = System.Windows.Media.Brushes.Black


            };
            Axis ax = new Axis()
            {
                FontSize = 18,

                Title = "HORAS",
                //   LabelsRotation = 20,
                Foreground = System.Windows.Media.Brushes.Black,
                Separator = new Separator()
                {

                    Step = 1,
                    IsEnabled = false,

                }
            };

            ax.Labels = new List<string>();
            while (dr1.Read())
            {


                col.Values.Add(Convert.ToInt32(dr1["TOTAL"].ToString()));
                ax.Labels.Add(dr1["HORA"].ToString());

            }



            cartesianChart4.Series.Add(col);
            cartesianChart4.AxisX.Add(ax);
            cartesianChart4.AxisY.Add(new Axis
            {

                FontSize = 18,
                Foreground = System.Windows.Media.Brushes.Black,
                Title = "QUANTIDADE",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
            }

            );
            conecta1.Close();
        }
        private void LoadCharAnos()
        {

            cartesianChart4.Series.Clear();
            cartesianChart4.AxisX.Clear();
            cartesianChart4.AxisY.Clear();

            SqlConnection conecta1 = new SqlConnection(Conexao.ROTA);
            SqlCommand comande1 = new SqlCommand(@"
SELECT DATEPART(MONTH,datahora) as MES,count(sn) as TOTAL
FROM [EPL].[dbo].[CAIXOTE_EPL]
where DATEPART(YEAR, datahora) =@YEAR
group by MONTH([datahora]),YEAR ([datahora])
order by MONTH([datahora])ASC", conecta1);

            comande1.Parameters.Add("@Mes", SqlDbType.VarChar).Value = DTP1.Value.Month;
            comande1.Parameters.Add("@YEAR", SqlDbType.VarChar).Value = DTP1.Value.Year;
            comande1.Parameters.Add("@DAY", SqlDbType.VarChar).Value = DTP1.Value.Day;
            conecta1.Open();
            SqlDataReader dr1 = comande1.ExecuteReader();




            ColumnSeries col = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<int>(),
                LabelPoint = Point => Point.Y.ToString(),
                StrokeThickness = 30,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 128, 0)),
                Title = "Quantidade",
                //Fill = System.Windows.Media.Brushes.LightSteelBlue,
                //LineSmoothness = 10,
                //PointGeometrySize = 12,
                FontSize = 14,
                Foreground = System.Windows.Media.Brushes.Black


            };
            Axis ax = new Axis()
            {
                FontSize = 18,

                Title = "MES",
                //   LabelsRotation = 20,
                Foreground = System.Windows.Media.Brushes.Black,
                Separator = new Separator()
                {

                    Step = 1,
                    IsEnabled = false,

                }
            };

            ax.Labels = new List<string>();
            while (dr1.Read())
            {


                col.Values.Add(Convert.ToInt32(dr1["TOTAL"].ToString()));
                ax.Labels.Add(dr1["MES"].ToString());

            }


            cartesianChart4.Series.Add(col);
            cartesianChart4.AxisX.Add(ax);
            cartesianChart4.AxisY.Add(new Axis
            {

                FontSize = 18,
                Foreground = System.Windows.Media.Brushes.Black,
                Title = "QUANTIDADE",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
            }

            );
            conecta1.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTP1_OnValueChanged(object sender, EventArgs e)
        {
            if (rjRadioButton1.Checked==true) LoadCharHora();
            else if (rjRadioButton2.Checked == true) LoadChar();
            else if (rjRadioButton3.Checked == true) LoadCharAnos();
        }

        private void cartesianChart4_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void DTP1_ValueChanged(object sender, EventArgs e)
        {
            if (rjRadioButton1.Checked == true) LoadCharHora();
            else if (rjRadioButton2.Checked == true) LoadChar();
            else if (rjRadioButton3.Checked == true) LoadCharAnos();
        }

        private void rjRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
