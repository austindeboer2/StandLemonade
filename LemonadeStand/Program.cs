public class LemonadeStand
{
    //Creates variables to be used in the program
    public float money;
    public float costOfLemonade;
    public float costOfCookie;
    public int soldLemonades;
    public int soldCookies;

    /*
     * Class Constructor Function: This function takes in 2 numbers, the cost of a lemonade and cookie. 
     * It then instatiates the variables to be used and saves the cost of these two products.
     */
    public LemonadeStand(float lemonade, float cookie)
    {
        money = 0f;
        costOfCookie = cookie;
        costOfLemonade = lemonade;
        soldCookies = 0;
        soldLemonades = 0;
    }

    /*
     * Goal: Make a function that calculates the money made from a lemonade sale and add the number of lemonades sold to your total
     * To Do- Calculate the amount of money made from selling x lemonades then add that to your money variable
     *      - Add the number of lemonades sold to the variable soldLemonades
     */
    public void SellLemonade(int numberOfLemonades)
    {
        
    }

    /*
     * Goal: Make a function that calculates the money made from a cookie sale and add the number of cookies sold to your total
     * To Do- Calculate the amount of money made from selling x cookies then add that to your money variable
     *      - Add the number of cookies sold to the variable soldCookies
     */
    public void SellCookie(int numberOfCookies)
    {
        
    }


    /*
     * Returns a sentance that tells how many lemonades and cookies were sold along with how much money was made
     */
    public string EndOfDayReview()
    {
        return "You have sold " + soldLemonades + " lemonades and " + soldCookies + " cookies, making a total of $" + money;
    }

    public static void Main(string[] args)
    {
        //Creates a LemonadeStand object with the cost of a single lemonade/cookie
        LemonadeStand ls = new LemonadeStand(1.25f, 1.1f);

        //for loop that runs 10 times to sell cookies and lemonades
        for(int i = 0; i < 10; i++)
        {
            ls.SellLemonade(i);
            ls.SellCookie(i);
        }

        //Writes the review of the day to the console
        Console.WriteLine(ls.EndOfDayReview());
    }
}