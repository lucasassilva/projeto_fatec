using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
   public partial class ExibeExcecoes : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         CarregaExcecoes();
      }

      private LIB_ADST.RecoverExceptions re = new LIB_ADST.RecoverExceptions();

      protected void CarregaExcecoes()
      {
         Excecoes.Text = re.LoadException().Replace("\n", "<br/>");
      }

      protected void Excluir_Click(object sender, EventArgs e)
      {
         re.DeleteException();
         CarregaExcecoes();
      }
   }
}