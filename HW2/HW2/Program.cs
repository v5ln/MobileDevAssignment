using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HW2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Inserter inserter = new Inserter();
            List<Route> AllRoutes = new List<Route>();
            ShowRoutes show = new ShowRoutes();
            Searcher searcher = new Searcher();

            int choice;
            Console.WriteLine("Enter Your Choice:\n1-Create Route\n2-Create Router\n3-Show All Routes\n4-Sync Search\n5-Async Search\n6-Exit");
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 6){
                switch (choice)
                {
                    case 1:
                        inserter.CreateRoute(AllRoutes);
                        break;

                    case 2:
                        inserter.CreateRouter(AllRoutes);
                        break;

                    case 3:
                        show.ShowAll(AllRoutes);
                        break;
                    
                    case 4:
                        searcher.SyncSearch(AllRoutes);
                        break;

                    case 5:
                        searcher.AsyncSearch(AllRoutes);
                        Thread.Sleep(500);
                        break;
                    
                    default:
                        Console.WriteLine("Invalid Input, Try Again");
                        break;
                }
                
                Console.WriteLine("Enter Your Choice:\n1-Create Route\n2-Create Router\n3-Show All Routes\n4-Sync Search\n5-Async Search\n6-Exit");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            
        }
    }
}
