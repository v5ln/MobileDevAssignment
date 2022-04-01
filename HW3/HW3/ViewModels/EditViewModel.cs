using HW3.Models;
using static HW3.Helpers.StaticReferences;
using static HW3.Models.StaffUser;
using static HW3.ViewModels.MenuViewModel;
using System.Linq;
using System.Collections.ObjectModel;
using System;

namespace HW3.ViewModels
{
    public class EditViewModel
    {
        public MenuViewModel MenuViewModel;
        public EditViewModel(MenuViewModel MenuViewModel)
        {
            this.MenuViewModel = MenuViewModel;
        }
        

        public void Edit(Types type, int Id, string Name, int Age, Roles Role = Roles.Null)
        {
            switch (type)
            {
                case Types.User:
                    int index = MenuViewModel.Users.IndexOf(MenuViewModel.Users.FirstOrDefault((user) => user.Id == Id));
                    if (Name == emptyName)
                        Name = MenuViewModel.Users[index].Name;
                    if (Age == emptyAge)
                        Age = MenuViewModel.Users[index].Age;
                    MenuViewModel.Users[index] = new User(Id, Name, Age);
                    break;

                case Types.Staff:
                    index = MenuViewModel.StaffUsers.IndexOf(MenuViewModel.StaffUsers.FirstOrDefault((user) => user.Id == Id));
                    if (Name == emptyName)
                        Name = MenuViewModel.StaffUsers[index].Name;
                    if (Age == emptyAge)
                        Age = MenuViewModel.StaffUsers[index].Age;
                    if (Role == Roles.Null)
                        Role = MenuViewModel.StaffUsers[index].Role;
                    MenuViewModel.StaffUsers[index] = new StaffUser(Id, Name, Age, Role);

                    for (int adminIndex = 0; adminIndex < MenuViewModel.AdminUsers.Count; adminIndex++)
                    {
                        for (int staffIndex = 0; staffIndex < MenuViewModel.AdminUsers[adminIndex].StaffUsers.Count; staffIndex++)
                        {
                            if (MenuViewModel.AdminUsers[adminIndex].StaffUsers[staffIndex].Id.Equals(Id))
                                MenuViewModel.AdminUsers[adminIndex].StaffUsers[staffIndex] =
                                    MenuViewModel.StaffUsers.FirstOrDefault((staffuser) => staffuser.Id == Id);
                        }
                    }

                    break;

                case Types.Admin:
                    index = MenuViewModel.AdminUsers.IndexOf(MenuViewModel.AdminUsers.FirstOrDefault((user) => user.Id == Id));
                    if (Name == emptyName)
                        Name = MenuViewModel.AdminUsers[index].Name;
                    if (Age == emptyAge)
                        Age = MenuViewModel.AdminUsers[index].Age;
                    MenuViewModel.AdminUsers[index] = new AdminUser(Id, Name, Age);
                    break;
            }
        }
    }
}
