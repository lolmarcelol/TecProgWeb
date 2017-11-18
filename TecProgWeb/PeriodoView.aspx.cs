using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrabTecprog2.Class;

namespace TecProgWeb
{
    public partial class PeriodoView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string enderecoServidor = @"Data Source = LAD0419\SQLEXPRESS;";
            string baseDeDados = "Initial Catalog = db01;";
            string credencial = "Integrated Security = true;";

            string strConexao = enderecoServidor + baseDeDados + credencial;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(strConexao);
                con.Open();

                string sql = "select * from curso";
                SqlCommand comandoSelect = new SqlCommand(sql, con);

                SqlDataReader leitor = comandoSelect.ExecuteReader();

                while (leitor.Read())
                {   
                    DropCurso.Attributes.Add(leitor["nome"].ToString(), leitor["id"].ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }


            
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            // construtor int id, string nome, int aulasPraticas, int aulasTeoricas, int creditos, int totalHA, int totalHR
            Periodo periodo = new Periodo(0, 0, 0, 0, 0, 0, Convert.ToInt32(TxtPeriodo.Text));

            string enderecoServidor = @"Data Source = LAD0419\SQLEXPRESS;";
            string baseDeDados = "Initial Catalog = db01;";
            string credencial = "Integrated Security = true;";

            string strConexao = enderecoServidor + baseDeDados + credencial;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(strConexao);
                con.Open();
                string sql = "insert into periodo values (@periodo,0,0,0,0,0,@idCurso)";
                SqlCommand comandoInsert = new SqlCommand(sql, con);
                comandoInsert.Parameters.Add("@periodo", TxtPeriodo.Text);
                comandoInsert.Parameters.Add("@idCurso", DropCurso.Text);
                comandoInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}