namespace Core;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage) : base(beverage)
    {
    }
    
    public override string GetDescription()
    {
        return _beverage.GetDescription() + " Mocha";
    }

    public override decimal Cost()
    {
        return _beverage.Cost() + 0.5m;
    }


}