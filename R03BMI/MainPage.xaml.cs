using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A27 高橋　海斗";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var height = heighit.Text;
            var weight = weighit.Text;
            try
            {
                double h = double.Parse(height);
                if (h > 10)
                {
                    h = h / 100;
                    result.Text = h + "";
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "!!!";


            }
        }
    }
}
