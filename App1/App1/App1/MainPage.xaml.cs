using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{

        static string bomb = new Random().Next(1, 4).ToString();
        static int scores = 0;


		public MainPage()
		{
			InitializeComponent();
		}

        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            // Game Over
            if (button.Text == bomb)
            {
                await DisplayAlert("Bomb Exploded! GAME OVER", "Score: " + scores,  "RETRY?");
                bomb = new Random().Next(1, 4).ToString();
                
                
            }
            else
            {
                scores += 1;
                await DisplayAlert("Bomb Defused!", "Good job.", "CONTINUE");
                bomb = new Random().Next(1, 4).ToString();
                
            }

        }

      
    }
}
