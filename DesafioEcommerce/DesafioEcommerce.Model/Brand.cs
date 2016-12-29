using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Model
{
    public class Brand : IEntity
    {
        public Guid Id { get; set; }

        public string Valor { get; set; }

        public string Descricao { get; set; }

    }
}
