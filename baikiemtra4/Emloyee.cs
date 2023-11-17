using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtra4
{
    public class Emloyee
    {
        private string id_;
        private string name_;
        private string address_;
        private DateTime DateofB_;
        private string sex_;
        private string tel_;

        public Emloyee()
        {
            id_ = string.Empty;
            name_ = string.Empty;
            address_ = string.Empty;
            sex_ = string.Empty;   
            tel_ = string.Empty; 
            DateofB_ = DateTime.Now;
        }
        public string Id
        { set { id_ = value; }
            get { return id_; }
        }    
        public string EmloyName
        {
            set { name_ = value; }
            get { return name_; }
        }
        public string EmloyAddress
        {
            set { address_ = value; }
            get { return address_; }
        }
        public DateTime EmloyDateofB
        {
            set { DateofB_ = value; }
            get { return DateofB_; }
        }
        public string EmloySex
        {
            set { sex_ = value; }
            get { return sex_; }
        }
        public string EmloyTel
        {
            set { tel_ = value; }
            get { return tel_; }    
        }

    }
}
