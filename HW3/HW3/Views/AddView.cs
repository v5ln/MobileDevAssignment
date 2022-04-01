using static HW3.Helpers.StaticReferences;
using static HW3.Models.StaffUser;
using static HW3.Models.StaffUser.Roles;
using System;
using HW3.ViewModels;
using HW3.Helpers;

namespace HW3.Views
{
    public class AddView
    {
        private AddViewModel Add;
        MenuViewModel MenuViewModel;
        public AddView(MenuViewModel MenuViewModel)
        {
            Add = new AddViewModel(MenuViewModel);
            this.MenuViewModel = MenuViewModel;
            AddMenuSwitch();
        }
        private void AddUser()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsDuplicated(Types.User, Id))
                throw new Exceptions(UserAlreadyExist.Add);
            Console.WriteLine(enterName);
            string Name = IsAlpha();
            Console.WriteLine(enterAge);
            int Age = IsNum();
            Add.Add(Types.User, Id, Name, Age);
        }
        private void AddStaff()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsDuplicated(Types.Staff, Id))
                throw new Exceptions(UserAlreadyExist.Add);
            Console.WriteLine(enterName);
            string Name = IsAlpha();
            Console.WriteLine(enterAge);
            int Age = IsNum();
            Console.WriteLine(enterRole);
            int choice = IsNum();
            while (!roles.Contains(choice))
            {
                Console.WriteLine(enterRole);
                choice = IsNum();
            }
            Roles role = Null;
            switch (choice)
            {
                case 1:
                    role = Role1;
                    break;
                case 2:
                    role = Role1;
                    break;
                case 3:
                    role = Role1;
                    break;
            }

            Add.Add(Types.Staff, Id, Name, Age, role);
        }
        private void AddAdmin()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsDuplicated(Types.Admin, Id))
                throw new Exceptions(UserAlreadyExist.Add);
            Console.WriteLine(enterName);
            string Name = IsAlpha();
            Console.WriteLine(enterAge);
            int Age = IsNum();
            Add.Add(Types.Admin, Id, Name, Age);
        }

        private void AttachStaffToAdmin()
        {
            Console.WriteLine(enterId + "For The Staff");
            int staffId = IsNum();
            Console.WriteLine(enterId + "For The Admin");
            int adminId = IsNum();
            if (MenuViewModel.IsDuplicated(Types.StaffList, staffId, adminId))
                throw new Exceptions(UserAlreadyExist.AddToAdmin);
            Add.AddStaffToAdmin(staffId, adminId);
        }

        private void AddMenuSwitch()
        {
            Console.WriteLine(addMenu);
            int choice = IsNum();
            switch (choice)
            {
                case 1:
                    AddUser();
                    break;
                case 2:
                    AddStaff();
                    break;
                case 3:
                    AddAdmin();
                    break;
                case 4:
                    AttachStaffToAdmin();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine(wrongInput);
                    break;
            }
        }
    }
}
