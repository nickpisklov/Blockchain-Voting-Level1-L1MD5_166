using System;
using System.Collections.Generic;

namespace BlockchainVoting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> points = new Dictionary<string, int>()
            {
                {"Yes", 0},
                {"No", 0}
            };
            Voting voting = new Voting(1, "MyVoting", points, new DateTime(2022, 2, 22), new DateTime(2022, 2, 25));
            Console.WriteLine(voting.ToString());
            Console.WriteLine();

            Transaction transaction = new Transaction(voting, "No");
            voting._points["No"] += 1;
            Transaction transaction1 = new Transaction(voting, "No");
            voting._points["No"] += 1;
            Transaction transaction2 = new Transaction(voting, "No");

            transaction.Print();
            Console.WriteLine();
            transaction1.Print();
            Console.WriteLine();
            transaction2.Print();
        }
    }
}
