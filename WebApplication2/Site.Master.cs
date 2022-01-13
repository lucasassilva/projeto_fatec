using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
   public partial class Site : System.Web.UI.MasterPage
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         if(Session["Nome"] != null)
         {
            NomeUsuario.Text = "<mark style='background:#ADD8E6'>" + Session["Nome"].ToString() + "</mark>";
            // USUÁRIO ESTA AUTENTICADO
            ExibeExcecoes.Visible = true;
            Usuarios.Visible = true;
            Logout.Visible = true;
            Candidatos.Visible = true;
            Login.Visible = false;
            TrabalheConosco.Visible = true;
         }
         else
         {
            ExibeExcecoes.Visible = false;
            Usuarios.Visible = false;
            Logout.Visible = false;
            Candidatos.Visible = false;
            Login.Visible = true;
            TrabalheConosco.Visible = true;
         }
      }
   }
}