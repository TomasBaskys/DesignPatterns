using System;

namespace Mediator
{
    public class JerseyColleague : Colleague
    {
        public JerseyColleague(IMediator mediator) : base(mediator)
        {
            Console.WriteLine("Jersey has sign for stock exchange.");
        }
    }
}