namespace CoinApp.Interfaces
{
    using System.Windows.Controls;

    using CoinApp.Models;

    using MahApps.Metro.Controls;

    public interface ICoinJarService
    {
        void Reset(CoinJar coinJar, Label currentAmount, MetroProgressBar volumeBar, Label currentVolume);
        void TryAddCoin(Coin coin, CoinJar coinJar, Label currentAmount, MetroProgressBar volumeBar, Label currentVolume);
    }
}
