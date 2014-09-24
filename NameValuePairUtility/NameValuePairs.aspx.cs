using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using NameValuePairUtility.Commands;

namespace NameValuePairUtility
{
    public partial class NameValuePairs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.DataSource = Utility.Instance.NvCollection;
            ListBox1.DataBind();
        }

        protected void bottonClickAction(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string buttonName = button.ID;

            Icommand command = CommandFactory.CreateCommand(buttonName);
            CommandArg cmdArg = new CommandArg();
            CommandResult results = null;
            cmdArg.Value = txtNameValuePair.Text;
            cmdArg.ListBox = ListBox1;
            if (command != null)
            {
                results = command.Execute(cmdArg);
                if (results.ErrorMessage == "")
                {
                    ListBox1.DataSource = results.NvCollection;
                    ListBox1.DataBind();
                    errorLabel.Text = "";
                }
                else
                {
                    errorLabel.Text = results.ErrorMessage;
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Font.Size = FontUnit.Larger;
                }
            }
        }
    }
}