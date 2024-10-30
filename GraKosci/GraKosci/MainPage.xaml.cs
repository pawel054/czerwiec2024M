using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GraKosci
{
    public partial class MainPage : ContentPage
    {
        int finalSum = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void RzutKoscmi(object sender, EventArgs e)
        {
            int[] randomNumbers = new int[5];
            int numersSum = 0;
            bool[] countedNumbers = new bool[randomNumbers.Length];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                randomNumbers[i] = random.Next(1, 7);
            }

            image1.Source = ImageSource.FromFile($"liczba{randomNumbers[0]}.png");
            image2.Source = ImageSource.FromFile($"liczba{randomNumbers[1]}.png");
            image3.Source = ImageSource.FromFile($"liczba{randomNumbers[2]}.png");
            image4.Source = ImageSource.FromFile($"liczba{randomNumbers[3]}.png");
            image5.Source = ImageSource.FromFile($"liczba{randomNumbers[4]}.png");

            for(int i = 0; i < randomNumbers.Length; i++)
            {
                if (!countedNumbers[i])
                {
                    int count = 1;
                    for(int j= i+1; j< randomNumbers.Length;  j++)
                    {
                        if (randomNumbers[i] == randomNumbers[j])
                        {
                            count++;
                            countedNumbers[j] = true;
                        }
                    }
                    if(count > 1)
                    {
                        numersSum += randomNumbers[i] * count;
                    }
                }
            }
            finalSum += numersSum;
            gameResults.Text = $"Wynik tego losowania: {numersSum.ToString()}";
            finalScore.Text = $"Wynik gry: {finalSum.ToString()}";
        }
    }
}
