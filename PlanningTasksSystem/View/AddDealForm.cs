﻿using System;
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
    public partial class AddDealForm : Form
    {
        private HomeController controller;
        public AddDealForm()
        {
            InitializeComponent();
            okButton.Click += controller.AddDeal;
        }
    }
}
