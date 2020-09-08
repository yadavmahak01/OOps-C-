using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM1
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public decimal? CurrentPrice { get; set; }//? defines nullable type
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        //override toString() method lambda expressions
        public override string ToString() => ProductName;
        private string _productName;
        public string ProductName
        {
            get
            {
                //for static class no need of creating instances
                //var stringHandler = new StringHandler();
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public string Log()
        {
            var logString = ProductId + ": " +
                ProductName + " " +
                "Detail :" + ProductDescription + " ";
            //"Status :" + EntityState.ToString();
            return logString;
        }

        /*string InsertSpaces(string source)
        { 
            var source = ProductName;
        }*/
        public override bool Validate()
        {
            var isvalid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isvalid = false;
            if (CurrentPrice == null) isvalid = false;

            return isvalid;

        }






    }
}
