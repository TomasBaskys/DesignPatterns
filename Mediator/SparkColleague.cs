using System;

namespace Mediator
{
    public class SparkColleague : Colleague
    {
        public SparkColleague(IMediator mediator) : base(mediator)
        {
            Console.WriteLine("Spark has sign for stock exchange.");
        }
    }
}