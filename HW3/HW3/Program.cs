using System.Collections.Generic;
using System.Linq;
using HW3.Models;
using HW3.Views;
using System;
using HW3.Helpers;
using static HW3.Helpers.StaticReferences;

namespace HW3
{
    class MainClass
    {
        //public static List<User> Users;
        public static void Main(string[] args)
        {

            MenuView main = new MenuView();
            main.MenuSwitch();
            //Users = new List<User>();
            //Users.Add(new User(1, "Name", 5));

            //Console.WriteLine(Users.Count);
            //throw new Exceptions(InputTypeNotValid.Numeric);
        }
    }
}
