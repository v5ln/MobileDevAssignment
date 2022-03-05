using System;
using System.Collections.Generic;

namespace HW2
{
    public class Route
    {
        private List<Router> route = new List<Router>();
        private int routeNumber;

        public void SetRouteNumber(int number){
            routeNumber = number;
        }

        public int GetRouteNumber(){
            return routeNumber;
        }
        public void SetRoute(Router router){
            route.Add(router);
        }

        public List<Router> GetRoute(){
            return route;
        }
    }
}
    