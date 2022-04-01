using static HW3.Helpers.StaticReferences;
using System;
using HW3.ViewModels;
using HW3.Helpers;

namespace HW3.Views
{
    public class PrintView
    {
        private PrintViewModel Print;
        MenuViewModel MenuViewModel;
        public PrintView(MenuViewModel MenuViewModel)
        {
            this.MenuViewModel = MenuViewModel;
            Print = new PrintViewModel(MenuViewModel);
            PrintMenuSwitch();
        }

        private void PrintUser()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsNotExist(Types.User, Id))
                throw new Exceptions(UserNotFound.Print);
            Print.Print(Types.User, Id);
        }

        private void PrintStaff()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsNotExist(Types.Staff, Id))
                throw new Exceptions(UserNotFound.Print);
            Print.Print(Types.Staff, Id);
        }

        private void PrintAdmin()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsNotExist(Types.Admin, Id))
                throw new Exceptions(UserNotFound.Print);
            Print.Print(Types.Admin, Id);
        }

        private void PrintAllUser() => Print.Print(Types.AllUser);

        private void PrintAllStaff() => Print.Print(Types.AllStaff);

        private void PrintAllAdmin() => Print.Print(Types.AllAdmin);

        private void PrintStaffInAdmin()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsNotExist(Types.Admin, Id))
                throw new Exceptions(UserNotFound.Print);
            Print.Print(Types.StaffList, Id);
        }

        private void PrintMenuSwitch()
        {
            Console.WriteLine(printMenu);
            int choice = IsNum();
            switch (choice)
            {
                case 1:
                    PrintUser();
                    break;
                case 2:
                    PrintStaff();
                    break;
                case 3:
                    PrintAdmin();
                    break;
                case 4:
                    PrintAllUser();
                    break;
                case 5:
                    PrintAllStaff();
                    break;
                case 6:
                    PrintAllAdmin();
                    break;
                case 7:
                    PrintStaffInAdmin();
                    break;
                case 8:
                    break;
                default:
                    Console.WriteLine(wrongInput);
                    break;
            }
        }
    }
}
