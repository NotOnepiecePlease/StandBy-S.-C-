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
using Microsoft.SqlServer.Server;

namespace PFC___StandBy_CSharp.Graficos
{
    class GraficoServicosSemanais : conexao
    {
        public void PreencherUltimos7Dias(BunifuDataViz bunifuDataViz1, Label lblservico)
        {
            DataPoint graficoArea, graficoLinha;
            graficoArea = new DataPoint(BunifuDataViz._type.Bunifu_area);
            graficoLinha = new DataPoint(BunifuDataViz._type.Bunifu_line);
            var canvas = new Canvas();
            int qntServicosSemanais = 0;
            int[] qntServicos = { 0, 0, 0, 0, 0, 0, 0 };

            using (SqlConnection con = OpenConnection())
            {
                string procedure = "ServicosUltimos7Dias";
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand(procedure, con);
                cmd.CommandType = CommandType.StoredProcedure;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    qntServicosSemanais += 1;
                    switch (dr.GetString(2))
                    {
                        case "Segunda-Feira":
                            qntServicos[0] = qntServicos[0] + 1;
                            break;

                        case "Terça-Feira":
                            qntServicos[1] = qntServicos[1] + 1;
                            break;

                        case "Quarta-Feira":
                            qntServicos[2] = qntServicos[2] + 1;
                            break;

                        case "Quinta-Feira":
                            qntServicos[3] = qntServicos[3] + 1;
                            break;

                        case "Sexta-Feira":
                            qntServicos[4] = qntServicos[4] + 1;
                            break;

                        case "Sábado":
                            qntServicos[5] = qntServicos[5] + 1;
                            break;

                        case "Domingo":
                            qntServicos[6] = qntServicos[6] + 1;
                            break;
                    }
                }

                lblservico.Text = Convert.ToString(qntServicosSemanais);

                graficoArea.addLabely("Segunda".ToUpper(), qntServicos[0]);
                graficoArea.addLabely("Terca".ToUpper(), qntServicos[1]);
                graficoArea.addLabely("Quarta".ToUpper(), qntServicos[2]);
                graficoArea.addLabely("Quinta".ToUpper(), qntServicos[3]);
                graficoArea.addLabely("Sexta".ToUpper(), qntServicos[4]);
                graficoArea.addLabely("Sabado".ToUpper(), qntServicos[5]);
                graficoArea.addLabely("Domingo".ToUpper(), qntServicos[6]);

                bunifuDataViz1.colorSet.Add(Color.FromArgb(0, 168, 235));
                bunifuDataViz1.colorSet.Add(Color.White);

                canvas.addData(graficoArea);

                //graficoLinha.addLabely(vetNomeDiaSemana[0].ToUpper(), vetDiaSemana[0]);
                graficoLinha.addLabely("Segunda".ToUpper(), qntServicos[0]);
                graficoLinha.addLabely("Terca".ToUpper(), qntServicos[1]);
                graficoLinha.addLabely("Quarta".ToUpper(), qntServicos[2]);
                graficoLinha.addLabely("Quinta".ToUpper(), qntServicos[3]);
                graficoLinha.addLabely("Sexta".ToUpper(), qntServicos[4]);
                graficoLinha.addLabely("Sabado".ToUpper(), qntServicos[5]);
                graficoLinha.addLabely("Domingo".ToUpper(), qntServicos[6]);
                canvas.addData(graficoLinha);

                bunifuDataViz1.Render(canvas);
                //lblQntServicosSemanais.Text = qntServicos.ToString();
            }
        }
    }
}
