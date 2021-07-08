using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TaskManager
{
    public class Task
    {
        private int count = 0;
        public Task()
        {
            ID = count++;
        }
        public int ID { get; set; }
        public string Title { get; set; }
    }
    public partial class Main : System.Web.UI.Page
    {
        public List<Task> Tasks = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            taskRepeater.DataSource = Tasks;
        }
    }
}