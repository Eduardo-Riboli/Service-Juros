using System.Globalization;

namespace Curso_OO.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }


        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customfee)
            : base (name, price)
        {
            CustomsFee = customfee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name
                + ", $" 
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Custom fee: $" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }

 
}
