using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.DbConnection;
using Model.Entities;
using PlanningTasksSystem;

namespace Controller
{
    class HomeController: EventArgs
    {
        private AutenticationForm form;
        private MenuForm formMenu;
        private DataBaseContext db;
   
        
        void Validation(object sender, EventArgs e)
        {
            User user = db.People.FirstOrDefault(p => p.Login == form.loginTextBox.Text.ToString());
            if(form.loginTextBox.Text==user.Login.ToString() && form.passwordTextBox.Text==user.Password.ToString())
                formMenu.Show();
            MessageBox.Show("Пользователь с таким именем не найден");
        }

        

    }
}
