using PFC___StandBy_CSharp.SqlDbConnect;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Globalization;

namespace PFC___StandBy_CSharp.Graficos
{

    class SemanaDoAno : conexao
    {
        public int BuscarSemanaAno(DateTime dataServico)
        {
            CultureInfo cultureInfo = new CultureInfo("en-US");
            Calendar meuCalendario = cultureInfo.Calendar;

            CalendarWeekRule RegraCalendarioSemanal = cultureInfo.DateTimeFormat.CalendarWeekRule;
            DayOfWeek PrimeiroDiaSemana = cultureInfo.DateTimeFormat.FirstDayOfWeek;

            string data = "2020-03-27";
            DateTime date = DateTime.Parse(data);

            int dia = meuCalendario.GetWeekOfYear(dataServico, RegraCalendarioSemanal, PrimeiroDiaSemana);

            return dia;
        }

        public int BuscarSemanaDatabase() 
        {
            SqlConnection con = OpenConnection();
            SqlDataReader dr;
            //string Query = "select * from tb_semanaAno";

            SqlCommand cmd = new SqlCommand("Selecionar_tb_semanaAno", con);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();

            dr.Read();
            int dia = dr.GetInt32(0);

            return dia;
        }//procedure

        public void AtualizarSemanaAno(int _numeroSemana)
        {
            using (SqlConnection con = OpenConnection())
            {
                string Query = "update tb_semanaAno SET semanaDoAno = @NumeroSemana";

                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@NumeroSemana", _numeroSemana);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }//procedure
    }
}
