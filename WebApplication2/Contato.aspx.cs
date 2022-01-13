using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net.Mail;
using System.Net;


using System.IO; // contem metodos para trab. com arquivos e pastas

namespace WebApplication2
{
   public partial class Contato : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {

      }

      protected void Enviar_Click(object sender, EventArgs e)
      {
         //try
         //{
         if (Nome.Text.Trim() == "")
         {
            Erro.Text = "Digite seu nome";
         }
         else if (Email.Text.Trim() == "")
         {
            Erro.Text = "Digite seu e-mail";
         }
         else if (Mensagem.Text.Trim() == "")
         {
            Erro.Text = "Digite a mensagem";
         }
         else
         {

            // ENVIA O EMAIL PARA O CONTATO DO SITE
            // Ref: http://msdn.com.br (WEB C# enviar email) 

            // 1. CRIAR A MENSAGEM DE E-MAIL
            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = false;
            mail.Subject = "Fale Conosco";
            mail.To.Add("contato@seudominio.com.br");
            MailAddress from = new MailAddress("contato@seudominio.com.br");
            mail.From = from;
            mail.Body = "MENSAGEM ENVIADA\n\r";
            mail.Body += "Nome     :" + Nome.Text + "\n";
            mail.Body += "Email    :" + Email.Text + "\n";
            mail.Body += "Mensagem :" + Mensagem.Text + "\n";

            // 2. ENVIAR O EMAIL VIA PROTOCOLO SMTP
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.seudominio.com.br";
            smtp.Port = 587;
            smtp.EnableSsl = false;
            smtp.Credentials = new NetworkCredential("contato@seudominio.com.br", "suasenha");
            smtp.Send(mail);
         }
         //}
         //catch (Exception)
         //{
         //			Erro.Text = "Houve uma falha ao enviar o e-mail";
         //}
      }

   }
}