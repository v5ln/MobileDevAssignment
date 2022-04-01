using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HW3.Models;
using HW3.Views;
using static HW3.Helpers.StaticReferences;

namespace HW3.ViewModels
{
    public class MenuViewModel
    {
        public ObservableCollection<User> Users;
        public ObservableCollection<StaffUser> StaffUsers;
        public ObservableCollection<AdminUser> AdminUsers;
        public MenuViewModel()
        {
            Users = new ObservableCollection<User>();
            StaffUsers = new ObservableCollection<StaffUser>();
            AdminUsers = new ObservableCollection<AdminUser>();
        }
        public bool IsDuplicated(Types type, int Id, int AdminId = emptyID)
        {
            switch (type)
            {
                case Types.User:
                    foreach (User user in Users) { if (user.Id.Equals(Id)) return true; }
                    return false;
                case Types.Staff:
                    foreach (StaffUser user in StaffUsers) { if (user.Id.Equals(Id)) return true; }
                    return false;
                case Types.Admin:
                    foreach (AdminUser user in AdminUsers) { if (user.Id.Equals(Id)) return true; }
                    return false;
                case Types.StaffList:
                    foreach (StaffUser user in AdminUsers[AdminId].StaffUsers)
                    {
                        if (user.Id.Equals(Id)) return true;
                    }
                    break;
            }
            return false;
        }
        public bool IsNotExist(Types type, int Id, int AdminId = emptyID)
        {
            switch (type)
            {
                case Types.User:
                    foreach (User user in Users) { if (user.Id.Equals(Id)) return false; }
                    return true;
                case Types.Staff:
                    foreach (StaffUser user in StaffUsers) { if (user.Id.Equals(Id)) return false; }
                    return true;
                case Types.Admin:
                    foreach (AdminUser user in AdminUsers) { if (user.Id.Equals(Id)) return false; }
                    return true;
                case Types.StaffList:
                    foreach (StaffUser user in AdminUsers[AdminId].StaffUsers)
                    {
                        if (user.Id.Equals(Id)) return false;
                    }
                    break;
            }
            return true;
        }
    }
}
