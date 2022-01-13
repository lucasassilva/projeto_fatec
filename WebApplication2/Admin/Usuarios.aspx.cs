using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppDatabase;
using System.Data;

// TECNICAR PARA EVITAR INJEÇÃO DE SQL NO CÓDIGO
// https://docs.microsoft.com/en-us/sql/relational-databases/security/sql-injection?view=sql-server-2017&ranMID=24542&ranEAID=je6NUbpObpQ&ranSiteID=je6NUbpObpQ-y5AGKR2EoVj9KrxYVg4fMA&epi=je6NUbpObpQ-y5AGKR2EoVj9KrxYVg4fMA&irgwc=1&OCID=AID2000142_aff_7593_1243925&tduid=%28ir__jfcc3cs6w9kfqnqmkk0sohzjxm2xsy9k9bwotvxa00%29%287593%29%281243925%29%28je6NUbpObpQ-y5AGKR2EoVj9KrxYVg4fMA%29%28%29&irclickid=_jfcc3cs6w9kfqnqmkk0sohzjxm2xsy9k9bwotvxa00

namespace WebApplication2.Admin
{
   public partial class Usuarios : System.Web.UI.Page
   {
      // STRING DE CONEXÃO COM O BANCO DE DADOS
      protected string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/ADS2020.accdb") + ";Persist Security Info=False;";

      AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();

      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)
         {
            ExibirUsuarios();
         }
      }

      #region SALVAR

      // SALVA OS DADOS DE UM NOVO OU EDITA UM USUÁRIO
      protected void Salvar_Click(object sender, EventArgs e)
      {
         if (NomeCompleto.Text.Trim() == "")
         {
            Erro.Text = "Digite o nome ";
         }
         else if (Email.Text.Trim() == "")
         {
            Erro.Text = "Digite o email";
         }
         else if (EmailExiste(Email.Text.Trim()))
         {
            Erro.Text = "Este email já está cadastrado para outro usuário";
         }
         else if (NomeAcesso.Text.Trim() == "")
         {
            Erro.Text = "Digite o nome de acesso";
         }
         else if (NomeAcessoExiste(NomeAcesso.Text.Trim()))
         {
            Erro.Text = "este nome de acesso já esta registrado para outro usuário";
         }
         else if (Senha.Text.Trim() == "")
         {
            Erro.Text = "Digite a senha";
         }
         else
         {
            string comando = "";

            if (Codigo.Text != "")
            {
               comando = "UPDATE Usuarios SET NomeCompleto='" + Utilities.Filter(NomeCompleto.Text) + "', Email='" + Utilities.Filter(Email.Text) + "',NomeAcesso='" + Utilities.Filter(NomeAcesso.Text) + "',Senha='" + Utilities.Filter(Senha.Text) + "',Anotacoes='" + Utilities.Filter(Anotacoes.Text) + "' WHERE Codigo=" + Codigo.Text + ";";
            }
            else
            {
               // connectionstrings.com
               comando = "INSERT INTO Usuarios(NomeCompleto,Email,NomeAcesso,Senha,Anotacoes) VALUES('" + Utilities.Filter(NomeCompleto.Text) + "','" + Utilities.Filter(Email.Text) + "','" + Utilities.Filter(NomeAcesso.Text) + "','" + Utilities.Filter(Senha.Text) + "','" + Utilities.Filter(Anotacoes.Text) + "');";
            }
            db.ConnectionString = conexao;
            int linhas = (int)db.Query(comando);

            // PARA TRANSAÇÃO NO MY-SQL
            //AppDatabase.MySqlTransaction db = new AppDatabase.MySqlTransaction();
            //db.ConnectionString = conexao;
            //db.Query(comando);

            LimparControles();
            ExibirUsuarios();
         }
      }

      // LIMPA OS DADOS DOS CONTROLES DO FORMULÁRIO
      protected void LimparControles()
      {
         Codigo.Text = "";
         NomeAcesso.Text = "";
         NomeCompleto.Text = "";
         Senha.Text = "";
         Email.Text = "";
         Anotacoes.Text = "";
         Erro.Text = "";
         BuscarUsuario.Text = "";
         Erro.Text = "";

         Excluir.Visible = false;
         Cancelar.Visible = false;
      }

      // VERIFICA A EXISTENCIA OU NÃO DE UM NOME DE ACESSO
      protected bool NomeAcessoExiste(string nomeAcesso)
      {
         // comando para verificar a existencia do nome
         string comando = "SELECT Codigo FROM Usuarios WHERE NomeAcesso='" + Utilities.Filter(nomeAcesso) + "';";

         db.ConnectionString = conexao;
         System.Data.DataTable tb = (DataTable)db.Query(comando);
         if (tb.Rows.Count == 1)
         {
            if (Codigo.Text == tb.Rows[0]["Codigo"].ToString())
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

      // VERIFICA A EXISTENCIA DE UM EMAIL 
      protected bool EmailExiste(string email)
      {
         // comando para verificar a existencia do nome
         string comando = "SELECT Codigo FROM Usuarios WHERE Email='" + Utilities.Filter(email) + "';";

         AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();
         db.ConnectionString = conexao;
         System.Data.DataTable tb = (DataTable)db.Query(comando);
         if (tb.Rows.Count == 1)
         {
            if (Codigo.Text == tb.Rows[0]["Codigo"].ToString())
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

      // EXCLUI UM USUÁRIO DO BANCO DE DADOS
      protected void Excluir_Click(object sender, EventArgs e)
      {
         string comando = "DELETE FROM Usuarios WHERE Codigo=" + Codigo.Text;
         db.ConnectionString = conexao;
         int linhas = (int)db.Query(comando);
         LimparControles();
         ExibirUsuarios();
      }

      #endregion

      #region EXIBIR USUÁRIOS
      // EXIBE TODOS OS USUÁRIOS DO BANCO DE DADOS NO GRIDVIEW
      protected void ExibirUsuarios()
      {
         string comando = "SELECT Codigo, NomeCompleto, Email, NomeAcesso FROM Usuarios ORDER BY NomeCompleto ASC ";

         db.ConnectionString = conexao;
         System.Data.DataTable tb = (DataTable)db.Query(comando);

         if (tb.Rows.Count > 0)
         {
            ViewUsuarios.DataSource = tb;
            ViewUsuarios.DataBind();
            ViewUsuarios.Visible = true;
         }
         else
         {
            ViewUsuarios.Visible = false;
         }
         tb.Dispose();
      }

      // SELECIONA UMA LINHA DO GRIDVIEW PARA EDITAR OU EXCLUIR UM USUÁRIO
      protected void ViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
      {
         // 1. BUSCAR NO BANCO DE DADOS O REGISTRO SELECIONADO
         // recupera o código "campo chave" da linha selecionada
         Codigo.Text = ViewUsuarios.SelectedRow.Cells[1].Text;
      
         string comando = "SELECT * FROM Usuarios WHERE Codigo=" + Codigo.Text;
         db.ConnectionString = conexao;
         System.Data.DataTable tb = (System.Data.DataTable)db.Query(comando);

         if (tb.Rows.Count == 1)
         {
            NomeCompleto.Text = tb.Rows[0]["NomeCompleto"].ToString();
            Email.Text = tb.Rows[0]["Email"].ToString();
            NomeAcesso.Text = tb.Rows[0]["NomeAcesso"].ToString();
            Senha.Text = tb.Rows[0]["Senha"].ToString();
            Anotacoes.Text = tb.Rows[0]["Anotacoes"].ToString();
            Excluir.Visible = true;
         }
         else
         {
            Erro.Text = "Registro não encontrado";
            ExibirUsuarios();
         }
         tb.Dispose();
      }

      // EXECUTA UM FILTRO NA LISTA DE USUÁRIOS
      protected void Buscar_Click(object sender, EventArgs e)
      {
         string comando = "SELECT Codigo, NomeCompleto, Email, NomeAcesso FROM Usuarios WHERE NomeCompleto+Email+NomeAcesso LIKE '%" + Utilities.Filter(BuscarUsuario.Text) + "%';";

         db.ConnectionString = conexao;
         System.Data.DataTable tb = (DataTable)db.Query(comando);

         if (tb.Rows.Count > 0)
         {
            ViewUsuarios.DataSource = tb;
            ViewUsuarios.DataBind();
            ViewUsuarios.Visible = true;
         }
         else
         {
            ViewUsuarios.Visible = false;
         }
         Cancelar.Visible = true;
         tb.Dispose();
      }

      // CANCELA O FILTRO E VOLTA A LISTA DE TODOS OS USUÁRIOS
      protected void Cancelar_Click(object sender, EventArgs e)
      {
         LimparControles();
         ExibirUsuarios();
      }

      #endregion

   }
}