using System;
using System.Collections.Generic;
namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
        //   double side = 3.14;
        //   double area = side * side;
        //   Console.WriteLine("area: {0}", area);
        // Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
        // Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
        // Console.WriteLine(1 + 2 * 3);     // order of operations
        // Console.WriteLine(10 / 3.0);      // int's and doubles
        // Console.WriteLine(10 / 3);        // int's 
        // Console.WriteLine("12" + "3");    // What happens here?

        // int num = 10;
        // num += 100;
        // Console.WriteLine(num);
        // num ++;
        // Console.WriteLine(num);
        // bool isCold = true;
        // Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
        // Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice
        // string stringNum = "2";
        // int intNum = Convert.ToInt16(stringNum);
        // Console.WriteLine(intNum);
        // Console.WriteLine(intNum.GetType());
        //========================================================================================
        // Dictionary
        // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
        // { "firstInning", 10 },
        // { "secondInning", 20},
        // { "thirdInning", 30},
        // { "fourthInning", 40},
        // { "fifthInning", 50}
        // };
        // // myScoreBoard.Add("firstInning", 10);
        // // myScoreBoard.Add("secondInning", 20);
        // // myScoreBoard.Add("thirdInning", 30);
        // // myScoreBoard.Add("fourthInning", 40);
        // // myScoreBoard.Add("fifthInning", 50);
        // Console.WriteLine("----------------");
        // Console.WriteLine("  Scoreboard");
        // Console.WriteLine("----------------");
        // Console.WriteLine("Inning |  Score");
        // Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
        // Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
        // Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
        // Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
        // Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);
        //========================================================================================
        // Array
        // string[] favFood = new string[3]{ "pizza", "doughnuts", "icecream" };
        // string firstFood = favFood[0];
        // string secondFood = favFood[1];
        // string thirdFood = favFood[2];
        // Console.WriteLine("I like {0}, {1}, {2}", firstFood, secondFood, thirdFood);
        //========================================================================================
        // List
        // List<string> employees = new List<string>() { "adam", "amy"};

        // employees.Add("barbara");
        // employees.Add("billy");
        // Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);
        //========================================================================================
        // Loops
        List<string> employees = new List<string>() { "adam", "amy"};

        employees.Add("barbara");
        employees.Add("billy");

        for (int i = 0; i < employees.Count; i++)
        {
            Console.WriteLine(employees[i]);
        }
    }
  }
}