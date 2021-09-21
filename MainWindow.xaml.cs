namespace CoinApp
{
    using System.Collections.Generic;
    using System.Windows;

    using CoinApp.Models;

    using MahApps.Metro.Controls;

    public partial class MainWindow : MetroWindow
    {
        private CoinJar coinJar = new CoinJar();

        Dictionary<string, Coin> coins = new Dictionary<string, Coin>(){
            {"Penny", new Coin(new decimal(0.01), new decimal(0.0118349))},
            {"Nickel", new Coin(new decimal(0.05), new decimal(0.024312282))},
            {"Dime", new Coin(new decimal(0.10), new decimal(0.01149677))},
            {"Quarter", new Coin(new decimal(0.25), new decimal(0.02733965177512))}
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddPenny(object sender, RoutedEventArgs e)
        {
            TryAddCoin(coins["Penny"]);
        }

        private void AddNickel(object sender, RoutedEventArgs e)
        {
            TryAddCoin(coins["Nickel"]);
        }

        private void AddDime(object sender, RoutedEventArgs e)
        {
            TryAddCoin(coins["Dime"]);
        }

        private void AddQuarter(object sender, RoutedEventArgs e)
        {
            TryAddCoin(coins["Quarter"]);
        }

        private void Resetbtn(object sender, RoutedEventArgs e)
        {
            coinJar.Reset();
            currentAmount.Content = "$0";
            volumeBar.Value = 0;
            currentVolume.Content = $"0/42";
        }

        private void TryAddCoin(Coin coin)
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
