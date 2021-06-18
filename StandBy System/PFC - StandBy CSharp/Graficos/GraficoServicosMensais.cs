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

namespace PFC___StandBy_CSharp.Graficos
{
    class GraficoServicosMensais : conexao
    {

        public void Preencher(BunifuDataViz bunifuDataViz2, int _mes, Label lblQntServicosMensais)
        {
            int contadorServicosMes = 0;
            try
            {
                DataPoint graficoArea, graficoLinha;
                graficoArea = new DataPoint(BunifuDataViz._type.Bunifu_area);
                graficoLinha = new DataPoint(BunifuDataViz._type.Bunifu_line);
                var canvas = new Canvas();
                int[] vetServicosMes = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                //string[] vetNomeMes = new string[12] { "JAN", "FEV", "MAR", "ABR", "MAI", "JUN", "JUL", "AGO", "SET", "OUT", "NOV", "DEZ" };
                string[] vetNomeMes = new string[12] { "JANEIRO", "FEVEREIRO", "MARÇO", "ABRIL", "MAIO", "JUNHO", "JULHO", "AGOSTO", "SETEMBRO", "OUTUBRO", "NOVEMBRO", "DEZEMBRO" };

                using (SqlConnection con = OpenConnection())
                {
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("SelecionarIdData_Servicos", con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add("@Mes", SqlDbType.Int).Value = _mes;
                    dr = cmd.ExecuteReader();

                    dr.Read();
                    do
                    {
                        //contadorServicosMes++;
                        DateTime dateValue = dr.GetDateTime(1);
                        string mesNumero = dateValue.ToString("MM", new CultureInfo("en-US"));

                        //Somente vai mostrar no grafico, dados do ano atual
                        if (dateValue.Year == DateTime.Now.Year)
                        {
                            contadorServicosMes++;
                            switch (mesNumero)
                            {
                                case "01": // Janeiro
                                    vetServicosMes[0] += +1;
                                    break;

                                case "02": // Fevereiro
                                    vetServicosMes[1] += +1;
                                    break;

                                case "03": // Marco
                                    vetServicosMes[2] += +1;
                                    break;

                                case "04": // Abril
                                    vetServicosMes[3] += +1;
                                    break;

                                case "05": // Maio
                                    vetServicosMes[4] += +1;
                                    break;

                                case "06": // Junho
                                    vetServicosMes[5] += +1;
                                    break;

                                case "07": // Julho
                                    vetServicosMes[6] += +1;
                                    break;

                                case "08": // Agosto
                                    vetServicosMes[7] += +1;
                                    break;

                                case "09": // Setembro
                                    vetServicosMes[8] += +1;
                                    break;

                                case "10": // Outubro
                                    vetServicosMes[9] += +1;
                                    break;

                                case "11": // Novembro
                                    vetServicosMes[10] += +1;
                                    break;

                                case "12": // Dezembro
                                    vetServicosMes[11] += +1;
                                    break;
                            }
                        }
                    } while (dr.Read());

                    for (int i = 0; i < 12; i++)
                    {
                        graficoArea.addLabely(vetNomeMes[i].ToUpper(), vetServicosMes[i]);
                    }


                    //bunifuDataViz2.colorSet.Add(Color.FromArgb(0, 168, 235));
                    bunifuDataViz2.colorSet.Add(Color.FromArgb(0, 168, 235));
                    bunifuDataViz2.colorSet.Add(Color.White);

                    canvas.addData(graficoArea);

                    for (int i = 0; i < 12; i++)
                    {
                        graficoLinha.addLabely(vetNomeMes[i].ToUpper(), vetServicosMes[i]);
                    }

                    canvas.addData(graficoLinha);

                    lblQntServicosMensais.Text = contadorServicosMes.ToString();
                    bunifuDataViz2.Render(canvas);
                    //bunifuDataViz2.Render(canvas);
                    dr.Close();
                    //con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: Nao foi possivel carregar graficos pois nao existem dados! \n\n\n" + ex,"Sem Dados!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } //procedure
    }
}
