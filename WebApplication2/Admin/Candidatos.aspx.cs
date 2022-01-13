using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppDatabase;
using System.Data;

namespace WebApplication2
{
    public partial class Candidatos : System.Web.UI.Page
    {
        // STRING DE CONEXÃO COM O BANCO DE DADOS
        protected string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/ADS2020.accdb") + ";Persist Security Info=False;";

        AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string comando = "SELECT Codigo,NomeCompleto,Email,Telefone,Sexo,DataNascimento,Cidade,Descricao FROM TrabalhoConosco ORDER BY Codigo ASC ";
                db.ConnectionString = conexao;
                System.Data.DataTable tb = (DataTable)db.Query(comando);
                if (tb.Rows.Count > 0)
                {
                    ViewCandidatos.DataSource = tb;
                    ViewCandidatos.DataBind();
                    ViewCandidatos.Visible = true;
                }
                else
                {
                    ViewCandidatos.Visible = false;
                }
                tb.Dispose();
            }
        }
        protected void ViewCandidatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Codigo.Text = ViewCandidatos.SelectedRow.Cells[1].Text;
            Response.Write(Codigo.Text);
            Response.Redirect("DadosCandidatos.aspx?id=" + Codigo.Text);

        }
    }
}