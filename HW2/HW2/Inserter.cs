using System;
using System.Collections.Generic;
using HW2;
namespace HW2
{
    public class Inserter
    {
        public void CreateRoute (List<Route> AllRoutes){
            try{
                Route route = new Route();
                AllRoutes.Add(route);
                route.SetRouteNumber(AllRoutes.Count);
                System.Console.WriteLine("Route number " + route.GetRouteNumber() + " added sucesfully");
                System.Console.WriteLine("-------------");
            }
            catch (System.Exception e){
                throw e;
            }
        }
        public void CreateRouter (List<Route> AllRoutes){
            try{
                if (AllRoutes.Count != 0){
                    System.Console.WriteLine("-------------");
                    System.Console.WriteLine("Choose number of route");
                    foreach (var route in AllRoutes){
                        System.Console.WriteLine("Route number: " + route.GetRouteNumber());
                    }
                    int choice = Convert.ToInt32(Console.ReadLine())-1;

                    Router router = new Router();
                    Console.WriteLine("Add value of router");
                    router.SetRouter(Convert.ToInt32(Console.ReadLine()));
                    AllRoutes[choice].SetRoute(router);
                    System.Console.WriteLine("Router added sucesfully");
                    System.Console.WriteLine("-------------");
                }
                else {
                    System.Console.WriteLine("There is no routes to add router");
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }  
        }
    }
}
