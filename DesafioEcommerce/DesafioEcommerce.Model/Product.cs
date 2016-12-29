using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Model
{
    public class Product : IEntity
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public float Price { get; set; }
    }
}
