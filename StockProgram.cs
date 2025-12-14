using System;
namespace StockApp
{
    class StockProgram
    {
        static void Main()
        {
            StockPrice stock = new StockPrice("Apple", "AAp##", 150.0, 165.0);

            double changePercentage = stock.GetChangePercentage();

            Console.WriteLine("Stock Name   : " + stock.StockName);
            Console.WriteLine("Stock Symbol : " + stock.StockSymbol);
            Console.WriteLine("Change %     : " + changePercentage);
        }
    }
}
