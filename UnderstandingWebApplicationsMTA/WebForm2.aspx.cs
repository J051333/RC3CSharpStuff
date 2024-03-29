﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnderstandingWebApplicationsMTA {
    public partial class WebForm2 : Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["Name"] != null) {
                Label1.Text = $"Welcome, {Session["Name"]}";
            } else {
                Response.Redirect("WebForm1.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e) {
            Session.Remove("Name");
            Response.Redirect("WebForm1.aspx");
        }
    }
}