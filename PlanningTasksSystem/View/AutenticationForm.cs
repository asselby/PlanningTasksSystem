using Controller;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.DbConnection;

namespace PlanningTasksSystem
{
    public partial class AutenticationForm : Form
    {
        private HomeController controller= new HomeController();
        private DataBaseContext db;
        private MenuForm mform;
        public AutenticationForm()
        {
            InitializeComponent();
            passwordTextBox.TextChanged += OkButtonEnabled;
        }


        void OkButtonEnabled(object sender, EventArgs e)
        {
            {
                if (loginTextBox.Text != String.Empty && passwordTextBox.Text != String.Empty)
                    okButton.Enabled = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            controller.Validation();
        }
    }
}
