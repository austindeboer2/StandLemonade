namespace LemonadeStandTests
{
    
    public class Tests
    {
        LemonadeStand ls;
        Random r;
        float c;
        float l;

        [SetUp]
        public void Setup()
        {
            r = new Random();
            c = (float) Math.Round(Math.Round(r.NextDouble(), 2) * 2, 2);
            l = (float) Math.Round(Math.Round(r.NextDouble(), 2) * 2, 2);
            ls = new LemonadeStand(c, l);
            
        }

        [Test]
        public void SellLemonTest()
        {
            float cash = ls.money;
            int soldL = ls.soldLemonades;
            for(int i = 0; i < r.Next(1, 100); i++)
            {
                ls.SellLemonade(i);
                cash += i * ls.costOfLemonade;
                soldL += i;
            }
            if (ls.money != cash) Assert.Fail("Lemonade Cost: " + l +" System: " + ls.money + " Test: " + cash + " You are not properly adding the money from Lemonade sales to your money variable.");
            else if (ls.soldLemonades != soldL) Assert.Fail("You are not properly adding the number of sold Lemonades to your variable.");
            else Assert.Pass();
        }

        [Test]
        public void SellCookieTest()
        {
            float cash = ls.money;
            int soldC = ls.soldCookies;
            for (int i = 0; i < r.Next(1, 100); i++)
            {
                ls.SellCookie(i);
                cash += i * ls.costOfCookie;
                soldC += i;
            }
            if (ls.money != cash) Assert.Fail("Cookie Cost: " + c + " System: " + ls.money + " Test: " + cash +" You are not properly adding the money from Cookie sales to your money variable.");
            else if (ls.soldCookies != soldC) Assert.Fail(" System: " + ls.soldCookies + " Test: " + soldC + " You are not properly adding the number of sold Cookies to your variable.");
            else Assert.Pass();
        }
    }
}