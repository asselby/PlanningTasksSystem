using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace PlanningTasksSystem.View
{
    public partial class FindByTag : Form
    {
        private HomeController controller;
        public FindByTag()
        {
            InitializeComponent();
            findButton.Click += controller.FindByDeal;
        }

    }
}
