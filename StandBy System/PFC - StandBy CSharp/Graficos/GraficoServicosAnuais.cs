using PFC___StandBy_CSharp.SqlDbConnect;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Globalization;
using Bunifu.DataViz.WinForms;
using DataPoint = Bunifu.DataViz.WinForms.DataPoint;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using Guna.UI.WinForms;

namespace PFC___StandBy_CSharp.Graficos
{
    class GraficoServicosAnuais : conexao
    {
        public void Preencher(BunifuDataViz bunifuDataViz1, int lblAno, GunaLabel lblJan, GunaLabel lblFev, GunaLabel lblMar,
            GunaLabel lblAbr, GunaLabel lblMai, GunaLabel lblJun, GunaLabel lblJul, GunaLabel lblAgo, GunaLabel lblSet, GunaLabel lblOut,
            GunaLabel lblNov, GunaLabel lblDez, int[] corRgb)
        {
            SqlDataReader dr;
            DataPoint graficoArea, graficoLinha;
            //graficoArea = new DataPoint(BunifuDataViz._type.Bunifu_splineArea);
            //graficoLinha = new DataPoint(BunifuDataViz._type.Bunifu_spline);
            graficoArea = new DataPoint(BunifuDataViz._type.Bunifu_stackedColumn);
            //graficoLinha = new DataPoint(BunifuDataViz._type.Bunifu_spline);
            var canvas = new Canvas();
            //int qntServicosAnuais = 0;
            int[] qntServicosPorMes = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            using (SqlConnection con = OpenConnection())
            {
                string procedure = "ServicosUltimoAno";

                SqlCommand cmd = new SqlCommand(procedure, con);
                cmd.Parameters.AddWithValue("@Ano", lblAno);
                cmd.CommandType = CommandType.StoredProcedure;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //MessageBox.Show(""+dr.GetInt32(0) + " --- "+ dr.GetDateTime(1), "");
                    switch (dr.GetString(2))
                    {
                        case "Janeiro":
                            qntServicosPorMes[0] += 1;
                            break;

                        case "Fevereiro":
                            qntServicosPorMes[1] += 1;
                            break;

                        case "Março":
                            qntServicosPorMes[2] += 1;
                            break;

                        case "Abril":
                            qntServicosPorMes[3] += 1;
                            break;

                        case "Maio":
                            qntServicosPorMes[4] += 1;
                            break;

                        case "Junho":
                            qntServicosPorMes[5] += 1;
                            break;

                        case "Julho":
                            qntServicosPorMes[6] += 1;
                            break;

                        case "Agosto":
                            qntServicosPorMes[7] += 1;
                            break;

                        case "Setembro":
                            qntServicosPorMes[8] += 1;
                            break;

                        case "Outubro":
                            qntServicosPorMes[9] += 1;
                            break;

                        case "Novembro":
                            qntServicosPorMes[10] += 1;
                            break;

                        case "Dezembro":
                            qntServicosPorMes[11] += 1;
                            break;
                    }
                }

                if (dr.HasRows)
                {
                    lblJan.Visible = true;
                    lblFev.Visible = true;
                    lblMar.Visible = true;
                    lblAbr.Visible = true;
                    lblMai.Visible = true;
                    lblJun.Visible = true;
                    lblJul.Visible = true;
                    lblAgo.Visible = true;
                    lblSet.Visible = true;
                    lblOut.Visible = true;
                    lblNov.Visible = true;
                    lblDez.Visible = true;
                    lblJan.Text = qntServicosPorMes[0].ToString();
                    lblFev.Text = qntServicosPorMes[1].ToString();
                    lblMar.Text = qntServicosPorMes[2].ToString();
                    lblAbr.Text = qntServicosPorMes[3].ToString();
                    lblMai.Text = qntServicosPorMes[4].ToString();
                    lblJun.Text = qntServicosPorMes[5].ToString();
                    lblJul.Text = qntServicosPorMes[6].ToString();
                    lblAgo.Text = qntServicosPorMes[7].ToString();
                    lblSet.Text = qntServicosPorMes[8].ToString();
                    lblOut.Text = qntServicosPorMes[9].ToString();
                    lblNov.Text = qntServicosPorMes[10].ToString();
                    lblDez.Text = qntServicosPorMes[11].ToString();
                }
                else
                {
                    lblJan.Visible = false;
                    lblFev.Visible = false;
                    lblMar.Visible = false;
                    lblAbr.Visible = false;
                    lblMai.Visible = false;
                    lblJun.Visible = false;
                    lblJul.Visible = false;
                    lblAgo.Visible = false;
                    lblSet.Visible = false;
                    lblOut.Visible = false;
                    lblNov.Visible = false;
                    lblDez.Visible = false;
                }
                
                graficoArea.addLabely("JAN".ToUpper(), qntServicosPorMes[0]);
                graficoArea.addLabely("FEV".ToUpper(), qntServicosPorMes[1]);
                graficoArea.addLabely("MAR".ToUpper(), qntServicosPorMes[2]);
                graficoArea.addLabely("ABR".ToUpper(), qntServicosPorMes[3]);
                graficoArea.addLabely("MAI".ToUpper(), qntServicosPorMes[4]);
                graficoArea.addLabely("JUN".ToUpper(), qntServicosPorMes[5]);
                graficoArea.addLabely("JUL".ToUpper(), qntServicosPorMes[6]);
                graficoArea.addLabely("AGO".ToUpper(), qntServicosPorMes[7]);
                graficoArea.addLabely("SET".ToUpper(), qntServicosPorMes[8]);
                graficoArea.addLabely("OUT".ToUpper(), qntServicosPorMes[9]);
                graficoArea.addLabely("NOV".ToUpper(), qntServicosPorMes[10]);
                graficoArea.addLabely("DEZ".ToUpper(), qntServicosPorMes[11]);
                

                //bunifuDataViz1.colorSet.Add(Color.FromArgb(0, 168, 235));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(corRgb[0], corRgb[1], corRgb[2]));
                bunifuDataViz1.colorSet.Add(Color.White);
                canvas.addData(graficoArea);

                //graficoLinha.addLabely(vetNomeDiaSemana[0].ToUpper(), vetDiaSemana[0]);
                //graficoLinha.addLabely("JAN".ToUpper(), qntServicosPorMes[0]);
                //graficoLinha.addLabely("FEV".ToUpper(), qntServicosPorMes[1]);
                //graficoLinha.addLabely("MAR".ToUpper(), qntServicosPorMes[2]);
                //graficoLinha.addLabely("ABR".ToUpper(), qntServicosPorMes[3]);
                //graficoLinha.addLabely("MAI".ToUpper(), qntServicosPorMes[4]);
                //graficoLinha.addLabely("JUN".ToUpper(), qntServicosPorMes[5]);
                //graficoLinha.addLabely("JUL".ToUpper(), qntServicosPorMes[6]);
                //graficoLinha.addLabely("AGO".ToUpper(), qntServicosPorMes[7]);
                //graficoLinha.addLabely("SET".ToUpper(), qntServicosPorMes[8]);
                //graficoLinha.addLabely("OUT".ToUpper(), qntServicosPorMes[9]);
                //graficoLinha.addLabely("NOV".ToUpper(), qntServicosPorMes[10]);
                //graficoLinha.addLabely("DEZ".ToUpper(), qntServicosPorMes[11]);
                //canvas.addData(graficoLinha);

                bunifuDataViz1.Render(canvas);
                
                //bunifuDataViz1.Update();
            }
        }
    }
}
