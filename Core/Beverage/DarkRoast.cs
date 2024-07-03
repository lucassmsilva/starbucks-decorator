namespace Core;

public class DarkRoast : Beverage
{
    public override string GetDescription()
    {
        return "Dark Roast";
    }

    public override decimal Cost()
    {
        return 0.99m;
    }
}