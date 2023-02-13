namespace Observer;

public interface IObserver
{
    void Update(double price);
}

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
public class StockPriceObserver : IObserver
{
    private string _name;
    private double _price;
    private ISubject _stock;

    public StockPriceObserver(string name, ISubject stock)
    {
        _name = name;
        _stock = stock;
        _stock.RegisterObserver(this);
    }

    public void Update(double price)
    {
        this._price = price;
        Console.WriteLine($"the price of {_name} changed to {price}");
    }

    public double GetPrice() => _price;
}

public class StockPriceSubject : ISubject
{
    private List<IObserver> _observers;
    private double _price;

    public StockPriceSubject()
    {
        _observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_price);
        }
    }

    public void SetPrice(double price)
    {
        _price = price;
        NotifyObservers();
    }
}