namespace CoinJarApp.Models
{
    using CoinJarApp.Interfaces;

    class Coin : ICoin
    {
        private decimal _amount;
        private decimal _volume;

        public Coin(decimal amount, decimal volume)
        {
            _amount = amount;
            _volume = volume;
        }

        public decimal Amount { get => _amount; set => _amount = value; }
        public decimal Volume { get => _volume; set => _volume = value; }
    }
}
