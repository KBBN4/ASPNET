using System;
namespace Testing.Models
{
	public class Product
	{
		public Product()
		{
		}

		public object ProductID { get; set; }
        public object Name{ get; set; }
        public object Price { get; set; }
        public object CategoryID { get; set; }
        public object OnSale{ get; set; }
        public object StockLevel { get; set; }

    }
}

