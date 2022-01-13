using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication2
{
    public partial class DadosCandidatos : System.Web.UI.Page
    {
        protected string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/ADS2020.accdb") + ";Persist Security Info=False;";

        AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();
        protected void Page_Load(object sender, EventArgs e)
        {
            

            //string id = Request.QueryString("id");
            if (Request.QueryString["id"] != null)
            {
                
                string comando = "SELECT * FROM TrabalhoConosco WHERE Codigo=" + Request.QueryString["id"];
                db.ConnectionString = conexao;
                System.Data.DataTable tb = (System.Data.DataTable)db.Query(comando);
                

                foreach (DataRow linhas in tb.Rows)
                {
                    NomeCompleto.Text = linhas[1].ToString();
                    Email.Text = linhas[2].ToString();
                    Telefone.Text = linhas[3].ToString();
                    Sexo.Text = linhas[4].ToString();
                    if (Sexo.Text.Trim() == "1")
                    {
                        Sexo.Text = "Masculino";
                    }
                    else
                    {
                        Sexo.Text = "Feminino";
                    }
                    
                    myIframe.Src = linhas[8].ToString();
                }

            }
            else
            {
                Response.Redirect("~/Admin/Candidatos.aspx");
            }
                           
        }
    }
}