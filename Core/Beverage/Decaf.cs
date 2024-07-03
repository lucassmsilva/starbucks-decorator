namespace Core;

public class Decaf : Beverage
{
    public override string GetDescription()
    {
        return "Becaf";
    }

    public override decimal Cost()
    {
        return 1.11m;
    }
}