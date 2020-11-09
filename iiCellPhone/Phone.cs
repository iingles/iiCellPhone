using System;
using System.Collections.Generic;
using System.Text;

namespace iiCellPhone
{
    public class Phone
    {
        private string _brand;
        private string _model;
        private decimal _price;

        public int age { get; set; }

        // Constructor
        public Phone()
        {
            // Set default values
            _brand = "";
            _model = "";
            _price = 0;
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public void PhoneMarkup()
        {
            MarkupPhonePrice();
        }

        private void MarkupPhonePrice()
        {
            if (_model == "iPhone")
            {
                // Mark price up 1.56 percent
                _price *= 1.56m;
            }
            else
            {                   
                _price *= 2.56m;
            }
        }
    }
}
