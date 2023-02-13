using FluentAssertions;

namespace Observer.Tests;

public class ObserverTest
{
    private StockPriceSubject _stockPriceSubject;
    private StockPriceObserver _stockPriceObserver1;
    private StockPriceObserver _stockPriceObserver2;
     
    public ObserverTest()
    {
        _stockPriceSubject = new StockPriceSubject();
        _stockPriceObserver1 = new StockPriceObserver("stock1", _stockPriceSubject);
        _stockPriceObserver2 = new StockPriceObserver("stock2", _stockPriceSubject);
    }
    [Fact]
    public void SetPrice_should_notify_observers()
    {
        for (double i = 15; i > 5; i--)
        {
            _stockPriceSubject.SetPrice(i);
            _stockPriceObserver1.GetPrice().Should().Be(i);
            _stockPriceObserver2.GetPrice().Should().Be(i);
        }
    }
}