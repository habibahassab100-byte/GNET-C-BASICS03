using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_three
{
    internal class Program
    {

        #region Question three
        //Write a method called PrintWelcomeMessage that takes no parameters and prints
        //"Welcome to the Library!".Call it from Main.
        //public static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}
        #endregion
        #region Question five
        //Write a method AddBonusPages(int pages) that adds 50 to pages.Call it with a variable
        //int pages = 400; and print pages afterward.What do you expect to see, and why?
        // public static void AddBonusPages(int pages)
        //{
        //    pages += 50;
        //}
        #endregion
        #region Question six 
        // Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
        //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
        //see, and why
        //public static void ApplyDiscount(double[]prices)
        //{
        //    prices[0] -= 5;

        //}
        #endregion
        #region Question seven
        //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
        //Call it and print pages afterward. How is the result different from question 5 ?
        //static void AddBonusPagesByRef(ref int pages)
        //{
        //    pages = pages + 50;
        //}
        #endregion
        #region Question eight
        // Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
        //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
        //afterward
        //static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] { 10.0, 12.5, 15.0 };
        //}

        #endregion
        #region Question nine
        //  Write a method bool TryGetPrice(string title, out double price) that returns true and sets
        //price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
        //static bool TryGetPrice(string title, out double price)
        //{
        //    if (title == "Clean Code")
        //    {
        //        price = 25.5;
        //        return true;
        //    }
        //    else
        //    {
        //        price = 0;
        //        return false;
        //    }
        //}

        #endregion
        #region Question ten
        // Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.Call
        // it once with only a title, and once passing both a title and pages.
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Pages: {pages}");
        }

        #endregion

        static void Main(string[] args)
        {
            #region Question 1 
            //  Create a one - dimensional array double[] prices with the values 25.5, 40.0, 33.75.Print
            //the second price(index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);

            #endregion
            #region Question two 
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] ShelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(ShelfCopies[1, 0]);
            #endregion

            #region Question three
            //Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main.
            //PrintWelcomeMessage();
            #endregion
            #region Question five
            // Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            // AddBonusPages(pages);
            // Console.WriteLine(pages);
            // expect it to print 400 because the method AddBonusPages does not change the original variable pages
            // it only modifies a copy of it.
            #endregion
            #region Question six 
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].Call it
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and  why
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            // it will change obviously bec array is  a refrence type 


            #endregion

            #region Question seven
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?

            //int pages = 400;

            //AddBonusPagesByRef(ref pages);

            //Console.WriteLine(pages);
            #endregion
            #region Question eight
            // Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            //afterward
            //double[] prices = { 25.5, 40.0 };

            //ReplaceArray(ref prices);

            //Console.WriteLine(prices.Length);
            #endregion
            #region Question nine
            //  Write a method bool TryGetPrice(string title, out double price) that returns true and sets
            //price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
            //bool found = TryGetPrice("Clean Code", out double price);

            //if (found)
            //{
            //    Console.WriteLine(price);
            //}
            #endregion
            #region Question ten
            // Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.Call
            // it once with only a title, and once passing both a title and pages.

            PrintBookInfo("Clean Code");

            PrintBookInfo("Java Basics", 450);
            #endregion
        }

    }
    }   

	

