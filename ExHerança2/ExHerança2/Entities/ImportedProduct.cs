using System.Globalization;

namespace ExHerança2.Entities
{

    // Classe Produto Importado, herda de Produto
    class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        // Método para calcular o preço total com a taxa alfandegária
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        // Sobrescrevendo o método PriceTag para adicionar a taxa alfandegária
        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}

