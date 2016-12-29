using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Model
{
    public class Transaction : IEntity
    {
        public Guid Id { get; set; }
        public float OrderPrice { get; set; }
        public Guid ProductId { get; set; }
    }
}
