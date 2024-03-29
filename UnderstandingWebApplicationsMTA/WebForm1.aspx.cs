﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnderstandingWebApplicationsMTA {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Response.Write("Message from Page_Load. <br />");
            
            if (Session["Name"] != null) {
                Response.Redirect("WebForm2.aspx");
            }
        }

        protected void Page_Init(object sender, EventArgs e) {
            Response.Write("Message from Page_Init. <br />");
        }

        protected void Page_PreRender(object sender, EventArgs e) {
            Response.Write("Message from Page_PreRender. <br />");
        }

        protected void Page_PreInit(object sender, EventArgs e) {
            Response.Write("Message from Page_PreInit. <br />");
        }

        protected void Button1_Click(object sender, EventArgs e) {
            Session.Add("Name", TextBox1.Text);
            Response.Redirect("WebForm2.aspx");
        }

        protected void ShowExamples_Click(object sender, EventArgs e) {
            Response.Redirect("default.html");
        }
    }
}