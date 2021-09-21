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

        //Extra method I added to get the volume of the jar in order to prevent the user from adding in more coins if the jar is full.
        public decimal GetTotalVolume()
            => totalVolume;

        public void Reset()
        {
            totalAmount = 0;
            totalVolume = 0;
        }
    }
}
