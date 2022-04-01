using System.Linq;
using System;
using HW3.Models;
using static HW3.Helpers.StaticReferences;
using static HW3.Models.StaffUser;

namespace HW3.ViewModels
{
    public class AddViewModel
    {
        public MenuViewModel menuViewModel;
        public AddViewModel(MenuViewModel menuViewModel)
        {
            //this.menuViewModel = new MenuViewModel();
            this.menuViewModel = menuViewModel;
        }
        public bool IsDuplicated(Types type, int Id, int AdminId = emptyID)
        {
            switch (type)
            {
                case Types.User:
                    foreach (User user in menuViewModel.Users) { if (user.Id.Equals(Id)) return true; }
                    return false;
                case Types.Staff:
                    foreach (StaffUser user in menuViewModel.StaffUsers) { if (user.Id.Equals(Id)) return true; }
                    return false;
                case Types.Admin:
                    foreach (AdminUser user in menuViewModel.AdminUsers) { if (user.Id.Equals(Id)) return true; }
                    return false;
                case Types.StaffList:
                    foreach (StaffUser user in menuViewModel.AdminUsers[AdminId].StaffUsers)
                    {
                        if (user.Id.Equals(Id)) return true;
                    }
                    break;

            }
            return false;

        }
        public void Add(Types type, int Id, string Name, int Age, Roles Role = Roles.Null)
        {
            switch (type)
            {
                case Types.User:
                    menuViewModel.Users.Add(new User(Id, Name, Age));
                    break;
                case Types.Staff:
                    menuViewModel.StaffUsers.Add(new StaffUser(Id, Name, Age, Role));
                    break;
                case Types.Admin:
                    menuViewModel.AdminUsers.Add(new AdminUser(Id, Name, Age));
                    break;
            }

        }
        //public void print()
        //{
        //    foreach (User user in menuViewModel.Users)
        //        user.ToString();
        //} 
        public void AddStaffToAdmin(int StaffId, int AdminId)
        {
            menuViewModel.AdminUsers.FirstOrDefault((user) => user.Id == AdminId).StaffUsers
                .Add(menuViewModel.StaffUsers.FirstOrDefault((user) => user.Id == StaffId));
        }
    }
}
