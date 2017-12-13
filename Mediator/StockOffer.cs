using System;

namespace Mediator
{
    public class StockOffer
    {
        public String StockCode { get; }

        public int Shares { get; }

        public StockOffer(string stockCode, int shares)
        {
            StockCode = stockCode;
            Shares = shares;
        }
    }
}