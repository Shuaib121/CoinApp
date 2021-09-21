namespace CoinApp.Services
{
    using System.Windows;
    using System.Windows.Controls;

    using CoinApp.Interfaces;
    using CoinApp.Models;

    using MahApps.Metro.Controls;

    //Moved most logic to this service
    public class CoinJarService : ICoinJarService
    {
        //Resets the coin jar fields as well as relevant UI components.
        public void Reset(CoinJar coinJar, Label currentAmount, MetroProgressBar volumeBar, Label currentVolume)
        {
            coinJar.Reset();
            currentAmount.Content = "$0";
            volumeBar.Value = 0;
            currentVolume.Content = $"0/42";
        }

        //Adds a coin to the coin jar and updates relevant UI components.
        public void TryAddCoin(Coin coin, CoinJar coinJar, Label currentAmount, MetroProgressBar volumeBar, Label currentVolume)
        {
            if (coinJar.GetTotalVolume() + coin.Volume > 42)
            {
                MessageBox.Show("The Coin Jar is Too Full!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            coinJar.AddCoin(coin);
            currentAmount.Content = $"${coinJar.GetTotalAmount()}";

            var jarVolume = (double)coinJar.GetTotalVolume();
            volumeBar.Value = jarVolume;
            currentVolume.Content = $"{jarVolume:0.0}/42";
        }
    }
}
