namespace CoinApp
{
    using System.Collections.Generic;
    using System.Windows;

    using CoinApp.Models;
    using CoinApp.Services;

    using MahApps.Metro.Controls;

    public partial class MainWindow : MetroWindow
    {
        private readonly CoinJar coinJar = new CoinJar();
        private readonly CoinJarService coinJarService = new CoinJarService();

        Dictionary<string, Coin> coins = new Dictionary<string, Coin>(){
            {"Penny", new Coin(new decimal(0.01), new decimal(0.0118349))},
            {"Nickel", new Coin(new decimal(0.05), new decimal(0.024312282))},
            {"Dime", new Coin(new decimal(0.10), new decimal(0.01149677))},
            {"Quarter", new Coin(new decimal(0.25), new decimal(0.02733965177512))}
        };

        public MainWindow()
            => InitializeComponent();

        private void AddPenny(object sender, RoutedEventArgs e)
            => coinJarService.TryAddCoin(coins["Penny"], coinJar, currentAmount, volumeBar, currentVolume);

        private void AddNickel(object sender, RoutedEventArgs e)
            => coinJarService.TryAddCoin(coins["Nickel"], coinJar, currentAmount, volumeBar, currentVolume);

        private void AddDime(object sender, RoutedEventArgs e)
            => coinJarService.TryAddCoin(coins["Dime"], coinJar, currentAmount, volumeBar, currentVolume);

        private void AddQuarter(object sender, RoutedEventArgs e)
           => coinJarService.TryAddCoin(coins["Quarter"], coinJar, currentAmount, volumeBar, currentVolume);

        private void Reset(object sender, RoutedEventArgs e)
            => coinJarService.Reset(coinJar, currentAmount, volumeBar, currentVolume);
    }
}