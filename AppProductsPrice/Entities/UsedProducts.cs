using System;


namespace AppProductsPrice.Entities
{
    class UsedProducts : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProducts()
        {
        }

        public UsedProducts(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string PriceTag() // Método sobreescrito para retornar uma string 
        {
            return Name + " (Usado), " + "R$ " + Price.ToString("F2") + " Fabricado em: " + manufactureDate.ToString("dd/MM/yyyy");
        }
    }
}
