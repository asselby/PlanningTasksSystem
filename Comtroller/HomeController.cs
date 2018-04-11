using Model.DbConnection;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class HomeController : EventArgs
    {
        private DataBaseContext db;
        
        void Validation(object sender, EventArgs e)
        {
            User user = db.People.FirstOrDefault(p => p.Login == form.loginTextBox.Text.ToString());
            if (form.loginTextBox.Text == user.Login.ToString() && form.passwordTextBox.Text == user.Password.ToString())
                formMenu.Show();
            MessageBox.Show("Пользователь с таким именем не найден");
        }



    }
}
