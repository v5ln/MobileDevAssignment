using System.Linq;
using HW3.Models;
using static HW3.Helpers.StaticReferences;
using static HW3.ViewModels.MenuViewModel;
namespace HW3.ViewModels
{
    public class DeleteViewModel
    {
        public MenuViewModel MenuViewModel;
        public DeleteViewModel(MenuViewModel MenuViewModel)
        {
            this.MenuViewModel = MenuViewModel;
        }
        public void Delete(Types type, int Id)
        {
            switch (type)
            {
                case Types.User:
                    MenuViewModel.Users.Remove(MenuViewModel.Users.FirstOrDefault((user) => user.Id == Id));
                    break;

                case Types.Staff:
                    MenuViewModel.StaffUsers.Remove(MenuViewModel.StaffUsers.FirstOrDefault((user) => user.Id == Id));
                    for (int adminIndex = 0; adminIndex < MenuViewModel.AdminUsers.Count; adminIndex++)
                    {
                        for (int staffIndex = 0; staffIndex < MenuViewModel.AdminUsers[adminIndex].StaffUsers.Count; staffIndex++)
                        {
                            if (MenuViewModel.AdminUsers[adminIndex].StaffUsers[staffIndex].Id.Equals(Id))
                                MenuViewModel.StaffUsers.Remove
                                    (MenuViewModel.StaffUsers.FirstOrDefault((staffuser) => staffuser.Id == Id));
                        }
                    }

                    break;

                case Types.Admin:
                    MenuViewModel.AdminUsers.Remove(MenuViewModel.AdminUsers.FirstOrDefault((user) => user.Id == Id));
                    break;
            }
        }
    }
}
