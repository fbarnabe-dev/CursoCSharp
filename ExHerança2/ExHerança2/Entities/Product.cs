using System.Globalization;

namespace ExHerança2.Entities
{

    // Classe base Produto
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Método virtual para gerar a etiqueta de preço
        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

