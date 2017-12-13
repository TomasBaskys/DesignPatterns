using System;
using System.Collections.Generic;

namespace Mediator
{
    public class StockMediator : IMediator
    {
        private readonly IList<Colleague> _colleagues;
        private readonly IList<StockOffer> _stockBuyOffers;
        private readonly IList<StockOffer> _stockSellOffers;

        private int _colleagueCode;

        public StockMediator()
        {
            _colleagues = new List<Colleague>();
            _stockBuyOffers = new List<StockOffer>();
            _stockSellOffers = new List<StockOffer>();
        }

        public void SaleOffer(string stock, int shares, int colleagueCode)
        {
            foreach (var offer in _stockBuyOffers)
            {
                if (offer.StockCode == stock && offer.Shares == shares)
                {
                    Console.WriteLine($"Colleague with code '{colleagueCode}' sold {shares} of '{stock}' stocks.");
                    _stockBuyOffers.Remove(offer);
                    return;
                }
            }

            _stockSellOffers.Add(new StockOffer(stock, shares));
        }

        public void BuyOffer(string stock, int shares, int colleagueCode)
        {
            foreach (var offer in _stockSellOffers)
            {
                if (offer.StockCode == stock && offer.Shares == shares)
                {
                    Console.WriteLine($"Colleague with code '{colleagueCode}' bought {shares} of '{stock}' stocks.");
                    _stockSellOffers.Remove(offer);
                    return;
                }
            }

            _stockBuyOffers.Add(new StockOffer(stock, shares));
        }

        public void AddColleague(Colleague colleague)
        {
            _colleagues.Add(colleague);
            colleague.SetColleagueCode(++_colleagueCode);

            Console.WriteLine($"Colleague with code '{_colleagueCode}' has joined to market.");
        }

        public void GetStockStatus()
        {
            Console.WriteLine("\nStocks for sale:");
            foreach (var offer in _stockSellOffers)
            {
                Console.WriteLine($"\t{offer.StockCode}\t{offer.Shares}");
            }

            Console.WriteLine("\nStocks to buy:");
            foreach (var offer in _stockBuyOffers)
            {
                Console.WriteLine($"\t{offer.StockCode}\t{offer.Shares}");
            }
        }
    }
}