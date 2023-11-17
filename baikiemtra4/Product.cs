using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtra4
{
    public class Product
    {
        public string id_;
        private string name_;
        private string datesell_;
        private int sellquantity_;
        private int sumQuantity_;
        private int price_;

        public Product()
        {
            id_ = string.Empty;
            name_ = string.Empty;
            datesell_ = string.Empty;
            sellquantity_ = 0;
            price_ = 0;
            sellquantity_ = 0;
      
        }
        public int SumQuantity
        {
            set { sumQuantity_ = value; }
            get { return sumQuantity_; }
        }

        public string ProductID
        {
            set { id_ = value; }
            get { return id_; }
        }
        public string ProductName
        {
            set { name_ = value; }
            get { return name_; }
        }
        public string Datesell
        {
            set { datesell_ = value; }
            get { return datesell_; }
        }
        public int Sellquantity
        {
            set { sellquantity_ = value; }
            get { return sellquantity_; }         
        }
        public int Price
        {
            set { price_ = value; }
            get { return price_; }
        }
     
    }
}
