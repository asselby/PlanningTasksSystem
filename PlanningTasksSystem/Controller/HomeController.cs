using Model.DbConnection;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanningTasksSystem;
using PlanningTasksSystem.View;

namespace Controller
{
    public class HomeController : EventArgs
    {
        private DataBaseContext db;
        private AutenticationForm autForm;
        private AddDealForm addDealForm;
        private FindByTag findTagForm;
        private MenuForm menuForm;


        public void Validation()
        {
            var user = db.People.FirstOrDefault(p => p.Login == autForm.loginTextBox.Text.ToString());
            if (user != null)
            {
                if (autForm.loginTextBox.Text == user.Login.ToString() &&
                    autForm.passwordTextBox.Text == user.Password.ToString())
                    menuForm.Show();
            }

            MessageBox.Show("Пользователь" +
                            " с таким именем не найден");
        }


       public void ShowDeal(object sender, EventArgs e)
        {
            var deal = db.Deals;
            foreach (var item in deal)
            {
                menuForm.listView.Items[0].Text = item.Description.ToString();
                menuForm.listView.Items[2].Text = item.LimitionDate.ToString();
                foreach (var tag in item.Tags)
                {
                    menuForm.listView.Items[1].Text = tag.TagDescripton.ToString();
                }
            }
        }

       public void FindByDeal(object sender, EventArgs e)
        {
            string tag = findTagForm.tagTextBox.ToString();
            var deals = db.Deals.Where(p => p.Tags.Any(k => k.TagDescripton == tag));
            foreach (var item in deals)
            {
                findTagForm.tagTextBox.Text = item.ToString();
            }
        }

       public void AddDeal(object sender, EventArgs e)
        {
            Deal deal = new Deal()
            {
                CreatedDate = DateTime.Now,
                Description = addDealForm.descriptionTextBox.Text.ToString(),
                LimitionDate = addDealForm.dateTimePicker.Value,
                Tags = new List<Tag>(),
            };
            db.Deals.Add(deal);
            db.SaveChanges();
        }
    }
}
