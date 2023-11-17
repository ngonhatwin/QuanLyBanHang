using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtra4
{
    public class Customer
    {
        private string id_;
        private string name_;
        private string address_;
        private int tel_;
        private int count_;
        public Customer()
        {
            id_ = string.Empty;
            name_ = string.Empty;
            address_ = string.Empty;
            tel_ = 0;
            count_ = 0;
        }
        public int Count
        {
            set { count_ = value; }
            get { return count_; }
        }
        public string ID
        {
            set { id_ = value; }
            get { return id_; }
        }
        public string Name
        {
            set { name_ = value; }
            get { return name_; }
        }
        public string Address
        {
            set { address_ = value; }
            get { return address_; }
        }
        public int Tel
        {
            set { tel_ = value; }
            get { return tel_; }
        }
       public int COUNT()
        {
            Count++;
            return Count;
        }
    }
}
