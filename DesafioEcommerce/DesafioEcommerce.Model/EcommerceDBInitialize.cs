using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Model
{
    public class EcommerceDBInitialize : DropCreateDatabaseAlways<EcommerceDB>
    {
        protected override void Seed(EcommerceDB context)
        {
            context.Products.Add(Halo5());
            context.Products.Add(AssasinsCreedBlackFlag());
            context.Products.Add(GTAV());

            context.Brands.Add(Bandeira("Mastercard", "MasterCard"));
            context.Brands.Add(Bandeira("Visa", "Visa"));
            context.Brands.Add(Bandeira("Amex", "Amex"));
            context.Brands.Add(Bandeira("Diners", "Diners"));
            context.Brands.Add(Bandeira("Elo", "Elo"));
            context.Brands.Add(Bandeira("Aura", "Aura"));
            context.Brands.Add(Bandeira("Discover", "Discover"));
            context.Brands.Add(Bandeira("CasaShow", "Casa Show"));
            context.Brands.Add(Bandeira("HugCard", "HugCard"));
            context.Brands.Add(Bandeira("Hiper", "Hiper"));

            context.SaveChanges();
        }

        private Brand Bandeira(string valor, string descricao)
        {
            var brand = new Brand();
            brand.Id = Guid.NewGuid();
            brand.Valor = valor;
            brand.Descricao = descricao;
            return brand;
        }

        private Product Halo5()
        {
            var product = new Product();
            product.Id = Guid.NewGuid();
            product.Name = "Halo 5: Guardians";
            product.Description = "Halo 5 Guardians oferece uma experiência multijogador épica com vários modos, ferramentas completas para criação de níveis e a história mais emocionante de Halo até hoje.";
            product.Price = 200f;

            return product;
        }

        private Product AssasinsCreedBlackFlag()
        {
            var product = new Product();
            product.Id = Guid.NewGuid();
            product.Name = "Assassin’s Creed: Black Flag";
            product.Description = "Assassin’s Creed IV Black Flag começa em 1715, quando os piratas estabeleceram uma república sem lei no Caribe e governaram a terra e os mares. Esses bandidos detinham navios, paravam o comércio internacional, e saqueavam grandes fortunas.";
            product.Price = 99f;

            return product;
        }

        private Product GTAV()
        {
            var product = new Product();
            product.Id = Guid.NewGuid();
            product.Name = "GTA V";
            product.Description = "Os jogadores que visitam Los Santos e Blaine County no Xbox One vão experimentar o novo Modo em Primeira Pessoa, suporte para até 30 jogadores no GTA Online.";
            product.Price = 299f;

            return product;
        }
    }
}
