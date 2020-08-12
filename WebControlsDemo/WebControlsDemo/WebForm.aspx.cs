using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControlsDemo
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {


                List<string> values = new List<string>();
                values.AddRange(new String[] { "Item1", "Item2", "Item3", "Item4", "Item5" });
                foreach (var n in values)
                {
                    ListBox1.Items.Add(n);
                    RadioButtonList1.Items.Add(n);
                    CheckBoxList1.Items.Add(n);

                }

            }

            
            }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex > -1)
                Label1.Text = "You chose from ListBox : " + ListBox1.SelectedItem.Text;
         

        }

        protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex > -1)
                Label2.Text = "You chose fom Radio Button : " + RadioButtonList1.SelectedItem.Text;

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                Label3.Text = "Selected Item(s):<br />";
                
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    { Label3.Text += CheckBoxList1.Items[i].Text + "<br />"; }
                }

            
        }
    }
}