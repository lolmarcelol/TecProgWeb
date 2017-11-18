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
    public partial class CursoView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            // construtor int id, string nome, int aulasPraticas, int aulasTeoricas, int creditos, int totalHA, int totalHR
            Curso curso = new Curso(0,TxtNome.Text,0,0,0,0,0);

             string enderecoServidor = @"Data Source = LAD0419\SQLEXPRESS;";
             string baseDeDados = "Initial Catalog = db01;";
             string credencial = "Integrated Security = true;";

             string strConexao = enderecoServidor + baseDeDados + credencial;
             SqlConnection con = null;
             try
             {
                 con = new SqlConnection(strConexao);
                 con.Open();
                 string sql = "insert into curso values (@nome,0,0,0,0,0)";
                 SqlCommand comandoInsert = new SqlCommand(sql, con);
                 comandoInsert.Parameters.Add("@nome", TxtNome.Text);
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