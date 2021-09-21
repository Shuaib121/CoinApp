namespace CoinApp.Models
{
    using CoinApp.Interfaces;

    public class CoinJar : ICoinJar
    {
        private decimal totalAmount = 0;
        private decimal totalVolume = 0;

        public void AddCoin(ICoin coin)
        {
            totalAmount += coin.Amount;
            totalVolume += coin.Volume;
        }

        public decimal GetTotalAmount()
            => totalAmount;

        public decimal GetTotalVolume()
            => totalVolume;

        public void Reset()
        {
            totalAmount = 0;
            totalVolume = 0;
        }
    }
}
