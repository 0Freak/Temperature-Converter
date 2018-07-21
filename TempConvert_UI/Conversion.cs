using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConvert_UI
{
    public class Conversion
    {
        private double _userNumber = 0;

        public double ConvertFahrenheit(string choiceTo, double degree)
        {           
            choiceTo.ToLower();
            if (choiceTo == "Celsius")
            {
                double fahrToCel = 0;
                _userNumber = Convert.ToDouble(degree);

                fahrToCel = ((_userNumber - 32)) * 5 / 9;
                fahrToCel = Round(fahrToCel);
                return fahrToCel;
            }

            else if (choiceTo == "Kelvin")
            {
                double fahrToKel = 0;
                _userNumber = Convert.ToDouble(degree);

                fahrToKel = ((_userNumber + 459.67)) * 5 / 9;
                fahrToKel = Round(fahrToKel);
                return fahrToKel;
            }
            else
            {
                return degree;
            }
        }

        public double ConvertCelsius(string choiceTo, double degree)
        {
            if (choiceTo == "Fahrenheit")
            {
                double celToFahr = 0;
                _userNumber = Convert.ToDouble(degree);

                celToFahr = _userNumber * 9 / 5 + 32;
                celToFahr = Round(celToFahr);
                return celToFahr;
            }
            else if (choiceTo == "Kelvin")
            {
                double celToKel = 0;
                _userNumber = Convert.ToDouble(degree);

                celToKel = _userNumber + 273.15;
                celToKel = Round(celToKel);
                return celToKel;
            }
            else
            {
                return degree;
            }
        }

        public double ConvertKelvin(string choiceTo, double degree)
        {
            if (choiceTo == "Fahrenheit")
            {
                double kelToFahr = 0;
                _userNumber = Convert.ToDouble(degree);

                kelToFahr = _userNumber * 9 / 5 - 459.67;
                kelToFahr = Round(kelToFahr);
                return kelToFahr;
            }
            else if (choiceTo == "Celsius")
            {
                double kelToCel = 0;
                _userNumber = Convert.ToDouble(degree);

                kelToCel = _userNumber - 273.15;
                kelToCel = Round(kelToCel);
                return kelToCel;
            }
            else
            {
                return degree;
            }
        }

        private double Round(double number)
        {
            double roundedNumber = Math.Round(number, 5);
            return roundedNumber;
        }
    }
}
