namespace knightmoves;
public class Store
{
    public string PriceCheck(double price)
    {
        if (price == 1.50)
        {
            return "match";
        }
        return "";
    }

    public string GuessNumber(int guess)
    {
        if (guess != 25)
        {
            return "not it";
        }
        return "";
    }
}
