using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppDatabase;

namespace WebApplication2
{
   public partial class Login : System.Web.UI.Page
   {
      // STRING DE CONEXÃO COM O BANCO DE DADOS
      protected string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/ADS2020.accdb") + ";Persist Security Info=False;";

      AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();
      protected void Page_Load(object sender, EventArgs e)
      {

      }

      protected void Entrar_Click(object sender, EventArgs e)
      {
         //1 VERIFICAR SE O NOME E SENHA DIGITADOS EXISTEM
         string comando = "SELECT NomeAcesso, NomeCompleto FROM Usuarios WHERE NomeAcesso='" + Utilities.Filter(NomeAcesso.Text) + "' AND Senha='" + Utilities.Filter(Senha.Text) + "';";
         db.ConnectionString = conexao;
         DataTable tb = (DataTable)db.Query(comando);
         if (tb.Rows.Count == 1)
         {
            Session["Nome"] = tb.Rows[0]["NomeCompleto"].ToString();

            // 2. CRIA O TICKET DE ACESSO 

            // Inicializa a classe de autenticação do usuário
            FormsAuthentication.Initialize();

            // Define os dados do ticket de autenticação 
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, tb.Rows[0]["NomeAcesso"].ToString(), DateTime.Now, DateTime.Now.AddMinutes(30), false, FormsAuthentication.FormsCookiePath);

            // Grava o ticket no cookie de autenticação
            Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName,
                FormsAuthentication.Encrypt(ticket)));

            // Redireciona para a página que o usuário chamou
            Response.Redirect(FormsAuthentication.GetRedirectUrl(tb.Rows[0]["NomeAcesso"].ToString(), false));
         }
         else
         {
            Mensagem.Text = "Dados de acesso invalidos";
         }
      }
   }
}