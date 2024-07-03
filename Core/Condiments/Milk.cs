namespace Core;

public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage) : base(beverage)
    {
    }
    
    public override string GetDescription()
    {
        return _beverage.GetDescription() + " with Milk";
    }

    public override decimal Cost()
    {
        return 0.19m + _beverage.Cost();
    }


}