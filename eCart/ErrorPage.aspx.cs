using eCart.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCart
{
    public partial class ErrorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string generalErrorMsg = "A problem has occurred on this web site. Please try again. " +
                "If this error continues, please contact support.";
            string httpErrorMsg = "An HTTP error occurred. Page Not found. Please try again.";
            string unhandledErrorMsg = "The error was unhandled by application code.";
            FriendlyErrorMsg.Text = generalErrorMsg;
            string errorHandler = Request.QueryString["handler"];
            if (errorHandler == null)
            {
                errorHandler = "Error Page";
            }
            Exception ex = Server.GetLastError();
            string errorMsg = Request.QueryString["msg"];
            if (errorMsg == "404")
            {
                ex = new HttpException(404, httpErrorMsg, ex);
                FriendlyErrorMsg.Text = ex.Message;
            }
            if (ex == null)
            {
                ex = new Exception(unhandledErrorMsg);
            }
            if (Request.IsLocal)
            {
                ErrorDetailedMsg.Text = ex.Message;
                ErrorHandler.Text = errorHandler;    
                DetailedErrorPanel.Visible = true;
                if (ex.InnerException != null)
                {
                    InnerMessage.Text = ex.GetType().ToString() + "<br/>" +
                        ex.InnerException.Message;
                    InnerTrace.Text = ex.InnerException.StackTrace;
                }
                else
                {
                    InnerMessage.Text = ex.GetType().ToString();
                    if (ex.StackTrace != null)
                    {
                        InnerTrace.Text = ex.StackTrace.ToString().TrimStart();
                    }
                }
            }
            ExceptionUtility.LogException(ex, errorHandler);
            Server.ClearError();
        }
    }
}