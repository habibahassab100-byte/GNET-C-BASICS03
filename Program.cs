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
        public static void ApplyDiscount(double[]prices)
        {
            prices[0] -= 5;
             
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
            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]);
            // it will change obviously bec array is  a refrence type 

 
            #endregion
        }
    }
}
