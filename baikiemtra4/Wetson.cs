using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtra4
{
    public class Wetson
    {
        private int id_;
        private Product product_;
        private int sellQuantity_;
        private int sumPrice_;
        private int count_;
        public Wetson()
        {
            id_ = 0;
            product_ = new Product();
            sellQuantity_ = 0;
            sumPrice_ = 0;
            count_ = 0;
        }
        public int Count
        {
            set { count_ = value; }
            get { return count_; }
        }
        public int Id
        {
            set { id_ = value; }
            get { return id_; }
        }
        public Product Product
        {
            set { product_ = value; }
            get { return product_; }
        }
        public int SellQuantity
        {
            set { sellQuantity_ = value; }
            get { return sellQuantity_; }
        }
        public int SumPrice
        {
            set { sumPrice_ = value; }
            get { return sumPrice_; }
        }
        public int CountHD()
        {
            Count++;
            return Count;
        }
    }
}
