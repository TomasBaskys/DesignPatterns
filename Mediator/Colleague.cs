namespace Mediator
{
    public abstract class Colleague
    {
        private readonly IMediator _mediator;
        private int _colleagueCode;

        protected Colleague(IMediator mediator)
        {
            _mediator = mediator;

            mediator.AddColleague(this);
        }

        public void SaleOffer(string stock, int shares)
        {
            _mediator.SaleOffer(stock, shares, _colleagueCode);
        }

        public void BuyOffer(string stock, int shares)
        {
            _mediator.BuyOffer(stock, shares, _colleagueCode);
        }

        public void SetColleagueCode(int code)
        {
            _colleagueCode = code;
        }
    }
}