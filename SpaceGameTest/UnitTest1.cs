using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceGameProj;

namespace SpaceGameTest
{
    [TestClass]
    public class UnitTest1
    {
        Character c = new Character();
        Init i = new Init();
        double[] a = { 5 }, b = { 8 };
        double d = 10, e = 15, f = 20;
        [TestMethod]
        public void TestMethod1()
        {
            //setting refuel to true, allowing the purchase of fuel
            c.Refuel(true);
            //testing the ability to obtain the distance during space travel
            c.GetDistance(a, b);
            //testing the time elapse method, which calulates the amount of travel time
            c.GetTimeElapsed(d, e);
            //testing ability to calculate the user's score
            c.GetScore(d, e, f);
            //testing main menu
            i.SelectedAction(3);
        }
    }
}
