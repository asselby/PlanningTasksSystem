using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DbConnection;
using Model.Entities;
using Model.Interfaces;
using System.Data.Entity;

namespace Model
{
    class DealRepository : IRepository<Deal>
    {
        private DataBaseContext db;
        public void Create(Deal item)
        {
            db.Deals.Add(item);
        }

        public void Delete(int id)
        {
            Deal deal = db.Deals.FirstOrDefault(p => p.Id == id);
            db.Deals.Remove(deal);
            db.SaveChanges();
        }

        public IEnumerable<Deal> GetAll()
        {
            return db.Deals;
        }

        public void Read(Predicate<Tag> item)
        {
            return db.Deals.Where(item);
        }

        public void Update(Deal item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
