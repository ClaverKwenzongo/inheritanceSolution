using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceSolution
{
    internal class Product
    {
        private string productName = "Tom and Jerry";
        private string productDescription = "The story of a cat and mouse";
        private int productPrice = 100;
        private string productCode = "DF009FD";

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        public int ProductPrice
        {
            get { return productPrice; }
            set { ProductPrice = value; }
        }

        public string ProductCode
        {
            get { return productCode; }
            set => ProductCode = value; 
        }
    }
}
