using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;


namespace HW2
{
    public class Searcher
    {

        public void SyncSearch(List<Route> AllRoutes)
        {
            try
            {
                if (AllRoutes.Count != 0 ){
                    int shortestRoute = finder(AllRoutes[0]);
                    int shortestRouteNumber = 1;
                    int temp;
                    foreach (var route in AllRoutes)
                    {
                        temp = finder(route);
                        if (temp != 0 && temp < shortestRoute)
                        {
                            shortestRoute = temp;
                            shortestRouteNumber = route.GetRouteNumber();
                        }
                    }
                    ShowRoutes show = new ShowRoutes();
                    System.Console.WriteLine("The shortest route is: ");
                    show.Show(AllRoutes[shortestRouteNumber-1]);
                    System.Console.WriteLine("By cost : "+ shortestRoute);
                    
                }
                else{
                    System.Console.WriteLine("There is no routes");
                }
                
                
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public async void AsyncSearch(List<Route> AllRoutes)
        {
            try
            {
                if (AllRoutes.Count != 0 ){
                    int shortestRoute = finder(AllRoutes[0]);
                    int shortestRouteNumber = 1;
                    int temp;
                    foreach (var route in AllRoutes)
                    {
                        temp = await Asyncfinder(route);
                        if (temp != 0 && temp < shortestRoute)
                        {
                            shortestRoute = temp;
                            shortestRouteNumber = route.GetRouteNumber();
                        }
                    }
                    ShowRoutes show = new ShowRoutes();
                    System.Console.WriteLine("The shortest route is: ");
                    show.Show(AllRoutes[shortestRouteNumber-1]);
                    System.Console.WriteLine("By cost : "+ shortestRoute);
                    
                }
                else{
                    System.Console.WriteLine("There is no routes");
                }
                
                
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        private int finder(Route route)
        {
            int time = 0;
            foreach (var router in route.GetRoute())
            {
                time += router.GetRouter();
            }
            return time;
        }

        private async Task<int> Asyncfinder(Route route)
        {
            Task<int> task = Task.Run(() =>
            {
                int time = 0;
                System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                foreach (var router in route.GetRoute())
                {
                    time += router.GetRouter();
                }
                return time;
            });
            await task;
            return task.GetAwaiter().GetResult();
        }
    }
}
