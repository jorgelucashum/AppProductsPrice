using System;

namespace AppProductsPrice.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag() // Método sobreescrito para retornar uma string 
        {
            return Name + ", R$ " + (Price + CustomsFee).ToString("F2") + " (Taxa: " + CustomsFee + ")";
        }


    }
}
