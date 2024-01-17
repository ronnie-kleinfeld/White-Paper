namespace PlaygroundTest.Core.Classes
{
    public class StockRecord
    {
        private decimal[] prices = new decimal[] {
            105.1m, 103.12m, 106.93m, 104.5m, 103.7m
        };

        public int Length => prices.Length;

        public decimal this[int index]
        {
            get => prices[index];
            set => prices[index] = value;
        }
        public decimal this[string day]
        {
            get
            {
                if (day == "mon")
                {
                    return prices[0];
                }
                if (day == "tue")
                {
                    return prices[1];
                }
                if (day == "wed")
                {
                    return prices[2];
                }
                if (day == "thu")
                {
                    return prices[3];
                }
                if (day == "fri")
                {
                    return prices[4];
                }
                throw new IndexOutOfRangeException($"'{day}' is not a valid index to StockRecord");
            }
        }
    }
}