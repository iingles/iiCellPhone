using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace iiCellPhone
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  // When the button is clicked, display the results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            // Instantiate an object of the Phone class
            Phone cellPhone = new Phone();


            // If brand or model is an empty string, input isn't valid
            if (EntryBrand.Text != "" && EntryModel.Text != "")
            {
                cellPhone.Brand = EntryBrand.Text;
                cellPhone.Model = EntryModel.Text;

                if (ValidPrice(cellPhone))
                {
                    cellPhone.PhoneMarkup();
                    DisplayPhoneDetails(cellPhone);
                }
            }

            else
            {
                DisplayAlert("Enter a string", "Please enter a value for the brand and model", "Close");
            }

        }

        /// <summary>
        ///  Display the results
        /// </summary>
        /// <param name="cellPhone"></param>
        private void DisplayPhoneDetails(Phone cellPhone)
        {
            // use a template string to set the label text with price to currency string
            LblResults.Text = $"Brand: {cellPhone.Brand}\nModel:{cellPhone.Model}\nPrice: {cellPhone.Price.ToString("c")}";
        }

        /// <summary>
        ///  Check to see if the price is valid
        /// </summary>
        /// <param name="cellPhone"></param>
        /// <returns></returns>
        public bool ValidPrice(Phone cellPhone)
        {

            if (decimal.TryParse(EntryPrice.Text, out decimal price) && price >=0)
            {
                // Set the price
                cellPhone.Price = price;
                return true;
            }
            else
            {
                // if it isn't valid, display an alert
                DisplayAlert("Invalid Input", "Please enter a number for the price", "Close");
                return false;
            }
        }
    }
}
