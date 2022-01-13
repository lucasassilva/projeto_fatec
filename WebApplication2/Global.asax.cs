using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication2
{
			public class Global : System.Web.HttpApplication
			{

						protected void Application_Start(object sender, EventArgs e)
						{

						}

						protected void Session_Start(object sender, EventArgs e)
						{

						}

						protected void Application_BeginRequest(object sender, EventArgs e)
						{

						}

						protected void Application_AuthenticateRequest(object sender, EventArgs e)
						{

						}

						protected void Application_Error(object sender, EventArgs e)
						{
									Exception ex = Server.GetLastError();
									// gravar a exceção no arquivo de log
									LIB_ADST.RecoverExceptions re = new LIB_ADST.RecoverExceptions();
									re.SendEmail = true;
									re.SaveException(ex);
						}

						protected void Session_End(object sender, EventArgs e)
						{

						}

						protected void Application_End(object sender, EventArgs e)
						{

						}
			}
}