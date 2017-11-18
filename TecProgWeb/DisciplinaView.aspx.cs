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
    public partial class DisciplinaView : System.Web.UI.Page
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
                con.Close();
            }
            finally
            {
                con.Close();
            }
        }

        protected void Save_Click(object sender, EventArgs e)
        {

            Disciplina disciplina = new Disciplina(0, TxtNome.Text, 0, 0, 0, 0, 0);

            string enderecoServidor = @"Data Source = LAD0419\SQLEXPRESS;";
            string baseDeDados = "Initial Catalog = db01;";
            string credencial = "Integrated Security = true;";

            string strConexao = enderecoServidor + baseDeDados + credencial;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(strConexao);
                con.Open();
                // int codigo, string nome,int aulasPraticas, int aulasTeoricas, int creditos, int totalHA, int totalHR
                string sql = "insert into disciplina values (@nome,@aulasPraticas,@aulasTeoricas,@creditos,@totalHa,@totalHr,@idPeriodo)";
                SqlCommand comandoInsert = new SqlCommand(sql, con);
                comandoInsert.Parameters.Add("@nome", TxtNome.Text);
                comandoInsert.Parameters.Add("@aulasPraticas", TxtAulasPraticas.Text);
                comandoInsert.Parameters.Add("@aulasTeoricas", TxtAulasTeoricas.Text);
                comandoInsert.Parameters.Add("@creditos", TxtCreditos.Text);
                comandoInsert.Parameters.Add("@totalHa", TxtTotalHa.Text);
                comandoInsert.Parameters.Add("@totalHr", TxtTotalHr.Text);
                comandoInsert.Parameters.Add("@idPeriodo", DropPeriodo.Text);
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

        protected void DropCurso_SelectedIndexChanged(object sender, EventArgs e)
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

                string sql = "select * from periodo where idCurso = @idCurso";
                SqlCommand comandoSelect = new SqlCommand(sql, con);
                comandoSelect.Parameters.Add("@idCurso", DropCurso.Text);
                SqlDataReader leitor = comandoSelect.ExecuteReader();

                while (leitor.Read())
                {
                    DropPeriodo.Attributes.Add(leitor["nome"].ToString(), leitor["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }
        }
    }
}