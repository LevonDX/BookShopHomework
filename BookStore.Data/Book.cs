using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class Book
    {
        private bool isModified = false;

        [Browsable(false)]
        public bool IsValueChanged
        {
            get { return isModified; }
            set { isModified = value; }
        }

        public int? ID { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    isModified = true;
                }
            }
        }
        public int? year;
        public int? Year
        {
            get { return year; }
            set
            {
                if (year != value)
                {
                    year = value;
                    isModified = true;
                }
            }
        }

        public decimal? price;
        public decimal? Price 
        {
            get { return price; }
            set
            {
                if(price != value)
                {
                    price = value;
                    isModified = true;
                }
            }
        }
    }
}
