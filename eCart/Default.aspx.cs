using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCart
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e) { }
        private void Page_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();
            if (exc is InvalidOperationException)
            {
                Server.Transfer("ErrorPage.aspx?handler=Page_Error%20-%20Default.aspx", true);
            }
        }
    }
}