using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Versaler.Model;

namespace Versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClearButton.Visible = false;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            ResponseText.Text = TextBox.Text.GetNumberOfCapitals().ToString();

            TextBox.Enabled = false;
            SubmitButton.Visible = false;
            ClearButton.Visible = true;
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = String.Empty;
            ResponseText.Text = String.Empty;
            TextBox.Enabled = true;
            SubmitButton.Visible = true;
            ClearButton.Visible = false;
        }
    }
}