using System;
using System.Collections.Generic;

namespace HW2
{
    public class ShowRoutes
    {
        public void ShowAll(List<Route> AllRoutes)
        {
            try
            {   if (AllRoutes.Count != 0){
                    foreach (var route in AllRoutes)
                    {
                        Show(route);
                    }
                }
                else{
                    System.Console.WriteLine("There is no routes to show!");
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public void Show(Route route){
            try
            {
                System.Console.WriteLine("Route number " + route.GetRouteNumber() + ":\n");
                foreach (var router in route.GetRoute())
                {
                    System.Console.WriteLine(router.GetRouter());
                }
                System.Console.WriteLine("-------------");
            }
            catch (System.Exception e)
            {
                
                throw e;
            }
        }
    }
}
