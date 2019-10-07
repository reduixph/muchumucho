using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace muchomucho
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLaunch_Click(object sender, EventArgs e)
        {
            //TEST PAYROLL
            if (ddlType.SelectedIndex==0 && ddlSystem.SelectedIndex == 0)
            {
                string newWindowUrl = "https://avlincpayroll-test.reduixph.com";
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>window.open('" + newWindowUrl + "');</script>");
            }
            //TEST ACCTG
            else if (ddlType.SelectedIndex == 0 && ddlSystem.SelectedIndex == 1)
            {
                string newWindowUrl = "https://avlincacctg-test.reduixph.com";
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>window.open('" + newWindowUrl + "');</script>");
            }
            //PROD PAYROLL
            else if (ddlType.SelectedIndex == 1 && ddlSystem.SelectedIndex == 0)
            {
                string newWindowUrl = "https://avlincpayroll.reduixph.com";
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>window.open('" + newWindowUrl + "');</script>");
            }
            //PROD ACCTG
            else if (ddlType.SelectedIndex == 1 && ddlSystem.SelectedIndex == 1)
            {
                string newWindowUrl = "https://avlincacctg.reduixph.com";
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>window.open('" + newWindowUrl + "');</script>");
            }
        }
    }
}