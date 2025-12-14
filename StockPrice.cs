using System;
using System.Collections.Generic;
using System.Text;

namespace StockApp 
{
        class StockPrice
    {
        public string StockName;
        public string StockSymbol;
        public double PreviousClosingPrice;
        public double CurrentClosingPrice;
        public StockPrice(string StockName, string StockSymbol, double PreviousClosingPrice, double CurrentPrice)
        {
            this.StockName = StockName;
            this.StockSymbol = StockSymbol;
            this.PreviousClosingPrice = PreviousClosingPrice;
            this.CurrentClosingPrice = CurrentPrice;
        }
         public double GetChangePercentage()
        {
            double change = CurrentClosingPrice - PreviousClosingPrice;
            double percentage = (change / PreviousClosingPrice) * 100;
            return percentage;
        }

    }
}

        