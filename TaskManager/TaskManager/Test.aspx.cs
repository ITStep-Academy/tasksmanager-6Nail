﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TaskManager
{
    public partial class Test : System.Web.UI.Page
    {
        public int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            count.Text = counter.ToString();
            if (Request.Cookies["counter"] == null)
            {
                HttpCookie cookie = new HttpCookie("counter")
                {
                    Value = counter.ToString(),
                    Expires = DateTime.Now.AddDays(30)
                };
                //Response.Cookies["counter"].Value = counter.ToString();
                //Response.Cookies["counter"].Expires = DateTime.Now.AddDays(30);
                Response.SetCookie(cookie);
            }

            count.Text = Request.Cookies["counter"].Value.ToString();
        }

        protected void button_Click(object sender, EventArgs e)
        {
            counter = Int32.Parse(Request.Cookies["counter"].Value);
            counter++;
            count.Text = counter.ToString();
            Response.Cookies["counter"].Value = counter.ToString();
            Response.Cookies["counter"].Expires = DateTime.Now.AddDays(30);
        }
    }
}