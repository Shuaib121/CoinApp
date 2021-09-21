namespace CoinJarApp.Models
{
    using CoinJarApp.Interfaces;

    class CoinJar : ICoinJar
    {
        private decimal totalAmount = 0;
        private decimal totalVolume = 0;

        public void AddCoin(ICoin coin)
        {
            totalAmount += coin.Amount;
            totalVolume += coin.Volume;
        }

        public decimal GetTotalAmount()
        {
            return totalAmount;
        }

        public decimal GetTotalVolume()
        {
            return totalVolume;
        }

        public void Reset()
        {
            totalAmount = 0;
            totalVolume = 0;
        }
    }
}
