using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Deal
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate{ get; set; }
        public int Priority { get; set; }
        public List<Tag> Tags { get; set; }
        public DateTime CurrentDate { get; set; }
    }
}
