namespace Core;

public class Espresso : Beverage
{
    public override string GetDescription()
    {
        return "Espresso";
    }

    public override decimal Cost()
    {
        return 1.5m;
    }
}