namespace C_4
{
    internal class Program
    {
        #region Question 3 function
        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}
        #endregion
        #region Question 4 Function
        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine("Book title: " + title);
        //}
        #endregion
        #region َQuestion 5 Function
        //static void AddBonusPages(int pages)
        //{
        //    pages = pages + 50;
        //}
        #endregion
        #region Question 6 Function
        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] = prices[0] - 5;
        //}
        #endregion
        #region Question 7 Function
        //static void AddBonusPagesByRef(ref int pages)
        //{
        //    pages = pages + 50;
        //}

        #endregion
        #region Question 8 Function 
        //static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] {10.0,12.5,15.0};
        //}

        #endregion
        #region Question 9 Function
        //static bool TryGetPrice(string title, out double price)
        //{
        //    if (title == "Clean Code")
        //    {
        //        price = 25.5;
        //        return true;
        //    }
        //    price = 0;
        //    return false;
        //}
        #endregion
        #region Question 10 Function
        //static void PrintBookInfo(string title, int pages = 300)
        //{
        //    Console.WriteLine($"Title: {title}");
        //    Console.WriteLine($"Pages: {pages}");
        //}
        #endregion
        #region Question 12 Function
        //static void PrintAllTitles(params string[] titles)
        //{
        //    foreach (string title in titles)
        //    {
        //        Console.WriteLine(title);
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Question 1
            //double[] prices = { 25.5,40.0,33.75 };
            //Console.WriteLine(prices[1]);
            #endregion
            #region Question2
            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion
            #region Question 3 Fuction call
            //PrintWelcomeMessage();
            #endregion
            #region Question 4 Function call
            //PrintBookTitle("Clean Code");
            #endregion
            #region Question 5 Function call
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            ////int is a value type the method recieves a copy not the original value
            #endregion
            #region Question 6 Function call
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            ////Array is a refrence type the method recieves a refence to the same array
            #endregion
            #region Question 7 Function call
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            #endregion
            #region Question 8 function call
            //double[] prices = {25.5,40.0};
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion
            #region Question 9 Function call
            //double price;
            //if (TryGetPrice("Clean Code", out price))
            //{
            //    Console.WriteLine(price);
            //}
            #endregion
            #region Question 10 Function call
            //PrintBookInfo("Abdelshafy");
            //PrintBookInfo("Abdelshafy",100);
            #endregion
            #region Question 11
            //PrintBookInfo(pages:11,title: "Mohanad");
            #endregion
            #region Question 12 Function call
            //PrintAllTitles("Mohand","Mohammed","Abdelshafy");
            #endregion
        }
    }
}
