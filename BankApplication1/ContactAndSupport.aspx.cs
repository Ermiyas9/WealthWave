﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankApplication1
{
    public partial class ContactAndSupport : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

<<<<<<< HEAD
            if (!IsPostBack)
            {
                // Store the previous page URL in a session variable
                Session["PreviousPageUrl"] = Request.RawUrl;


                // Load the content of your agreement dynamically
                string filePath = Server.MapPath("~/ContactInformation.pdf");

                // Check if there is a referrer
                if (Request.UrlReferrer != null)
                {
                    // Get the URL of the previous page
                    string previousPageUrl = Request.UrlReferrer.ToString();

                    // Store the previous page URL in a session variable (optional)
                    Session["PreviousPageUrl"] = previousPageUrl;
                }
            }
            else
            {
                Response.Redirect("HomePage.aspx");
            }
        }
        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            // Check if the previous page URL is available in the session
            if (Session["PreviousPageUrl"] != null)
            {
                // Redirect the user back to the previous page
                Response.Redirect(Session["PreviousPageUrl"].ToString());
            }
            else
            {
                Response.Redirect("HomePage.aspx");
            }
=======
            // Load the content of your agreement dynamically
            string filePath = Server.MapPath("~/ContactInformation.pdf");
>>>>>>> ffac5bf8acbeee7fa07991c6cfa003738767045d
        }



    }
}



        
