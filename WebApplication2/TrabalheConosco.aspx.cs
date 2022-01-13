using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppDatabase;
using System.Data;

namespace WebApplication2
{
   public partial class TrabalheConosco : System.Web.UI.Page
   {
        // STRING DE CONEXÃO COM O BANCO DE DADOS
        protected string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/ADS2020.accdb") + ";Persist Security Info=False;";

        AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();

        // SALVAR OS DADOS 
        protected void Enviar_Click(object sender, EventArgs e)
        {

            if (NomeCompleto.Text.Trim() == "")
            {
                Erro.Text = "Digite o nome ";
            }
            else if (Email.Text.Trim() == "")
            {
                Erro.Text = "Digite seu e-mail";
            }
            else if (EmailExiste(Email.Text.Trim()))
            {
                Erro.Text = "Este email já está cadastrado";
            }
            else if (Cidade.Text.Trim() == "")
            {
                Erro.Text = "Digite sua cidade";
            }
            else if (DataNascimento.Text.Trim() == "")
            {
                Erro.Text = "Digite a sua data nascimento";
            }
            else if (Sexo.SelectedValue.Trim() == "")
            {
                Erro.Text = "Selecione o seu sexo";
            }
            else if (Telefone.Text.Trim() == "")
            {
                Erro.Text = "Digite o seu telefone";
            }
            else if (Interesse.Items[0].Selected == true)
            {
                Erro.Text = "Selecione um interesse";

            } else if (myFile.PostedFile.FileName == "") {

                Erro.Text = "Selecione um curriculo";

            } else
            {
                //VERIFICAR SE O ARQUIVO FOI ENVIADO 
                if ((myFile.PostedFile != null) && (myFile.PostedFile.ContentLength > 0))
                {
                    string fn = System.IO.Path.GetFileName(myFile.PostedFile.FileName);
                    string SaveLocation = Server.MapPath("~/Curriculos/") + fn;
                    string local = "~/Curriculos/" + fn;
                    myFile.PostedFile.SaveAs(SaveLocation);
                    //INSERÇÃO DOS DADOS
                    string comando = "";
                    comando = "INSERT INTO TrabalhoConosco(NomeCompleto,Email,Cidade,DataNascimento,Sexo,Telefone,Descricao,Interesse,Curriculo) VALUES('" + Utilities.Filter(NomeCompleto.Text) + "','" + Utilities.Filter(Email.Text) + "','" + Utilities.Filter(Cidade.Text) + "','" + Utilities.Filter(DataNascimento.Text) + "','" + Utilities.Filter(Sexo.SelectedValue) + "','" + Utilities.Filter(Telefone.Text) + "' ,'" + Utilities.Filter(Descricao.Text) + "' ,'" + Utilities.Filter(Interesse.SelectedValue) + "','" + local + "');";
                    db.ConnectionString = conexao;
                    db.Query(comando);
                    LimparControles();
                }
                Erro.Text = "";
            }
        }

        // VERIFICA A EXISTENCIA DE UM EMAIL 
        protected bool EmailExiste(string email)
        {
            // comando para verificar a existencia do nome
            string comando = "SELECT Codigo,Email FROM TrabalhoConosco WHERE Email='" + Utilities.Filter(email) + "';";
            db.ConnectionString = conexao;
            System.Data.DataTable tb = (DataTable)db.Query(comando);
            if (tb.Rows.Count == 1)
            {
                if (Email.Text == tb.Rows[0]["Codigo"].ToString())
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        // LIMPA OS DADOS DOS CONTROLES DO FORMULÁRIO
        protected void LimparControles()
        {
            NomeCompleto.Text = "";
            Email.Text = "";
            Cidade.Text = "";
            DataNascimento.Text = "";
            Sexo.SelectedValue = null ;
            Telefone.Text = "";
            Descricao.Text = "";
            Interesse.SelectedValue= Interesse.SelectedItem.Value = null;
            Erro.Text = "";
        }

        

    }
}