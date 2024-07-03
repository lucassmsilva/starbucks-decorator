namespace Core;

public class HouseBlend : Beverage
{
    public override string GetDescription()
    {
        return "House Blend";
    }

    public override decimal Cost()
    {
        return 1.09m;
    }
}