using Model.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    interface IRepository <T> where T:class
    {
        IEnumerable<T> GetAll();
        void Create(T item);
        void Read(Predicate<Tag> item);
        void Update(T item);
        void Delete(int id);
    }
}
