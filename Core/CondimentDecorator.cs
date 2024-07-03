namespace Core;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage _beverage;

    public CondimentDecorator(Beverage beverage)
    {
        _beverage = beverage;
    }
}