namespace CoinApp.Services
{
    using System.Windows;
    using System.Windows.Controls;

    using CoinApp.Interfaces;
    using CoinApp.Models;

    using MahApps.Metro.Controls;

    public class CoinJarService : ICoinJarService
    {
        public void Reset(CoinJar coinJar, Label currentAmount, MetroProgressBar volumeBar, Label currentVolume)
        {
            coinJar.Reset();
            currentAmount.Content = "$0";
            volumeBar.Value = 0;
            currentVolume.Content = $"0/42";
        }

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
