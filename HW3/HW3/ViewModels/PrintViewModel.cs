using System;
using HW3.Models;
using static HW3.Helpers.StaticReferences;
using static HW3.ViewModels.MenuViewModel;
using System.Linq;
namespace HW3.ViewModels
{
    public class PrintViewModel
    {
        public MenuViewModel MenuViewModel;
        public PrintViewModel(MenuViewModel MenuViewModel)
        {
            this.MenuViewModel = MenuViewModel;
            //this.MenuViewModel = new MenuViewModel();
        }
        public void Print(Types type, int Id = emptyAge)
        {
            switch (type)
            {
                case Types.User:
                    Console.WriteLine(MenuViewModel.Users.FirstOrDefault((user) => user.Id == Id).ToString());
                    break;

                case Types.Staff:
                    Console.WriteLine(MenuViewModel.StaffUsers.FirstOrDefault((user) => user.Id == Id).ToString());
                    break;

                case Types.Admin:
                    Console.WriteLine(MenuViewModel.AdminUsers.FirstOrDefault((user) => user.Id == Id).ToString());
                    break;

                case Types.AllUser:
                    foreach (User user in MenuViewModel.Users)
                        Console.WriteLine(user.ToString());
                    break;

                case Types.AllStaff:
                    foreach (StaffUser user in MenuViewModel.StaffUsers)
                        Console.WriteLine(user.ToString());
                    break;

                case Types.AllAdmin:
                    foreach (AdminUser user in MenuViewModel.AdminUsers)
                        Console.WriteLine(user.ToString());
                    break;
                case Types.StaffList:
                    foreach (User user in MenuViewModel.AdminUsers.FirstOrDefault((user) => user.Id == Id).StaffUsers)
                        Console.WriteLine(user.ToString());
                    break;
            }
        }
    }
}
