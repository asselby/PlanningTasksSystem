using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanningTasksSystem.View;

namespace PlanningTasksSystem
{
    public partial class MenuForm : Form
    {
        private FindByTag findview;
        private AddDealForm addform;
        public MenuForm()
        {
            InitializeComponent();

        }

        private void findbyTagButton_Click(object sender, EventArgs e)
        {
            findview.Show();
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            addform.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
