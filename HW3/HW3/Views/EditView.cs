using static HW3.Helpers.StaticReferences;
using System;
using HW3.ViewModels;
using static HW3.Models.StaffUser;
using static HW3.Models.StaffUser.Roles;
using HW3.Helpers;

namespace HW3.Views
{
    public class EditView
    {
        private EditViewModel Edit;
        MenuViewModel MenuViewModel;
        public EditView(MenuViewModel MenuViewModel)
        {
            Edit = new EditViewModel(MenuViewModel);
            this.MenuViewModel = MenuViewModel;
            EditMenuSwitch();
        }

        private string NameEditor()
        {
            Console.WriteLine(editName);
            int choice = IsNum();
            while (choice != yes && choice != no)
            {
                Console.WriteLine(editName);
                choice = IsNum();
            }
            if (choice == no)
                return emptyName;
            Console.WriteLine(enterName);
            return IsAlpha();
        }

        private int AgeEditor()
        {
            Console.WriteLine(editAge);
            int choice = IsNum();
            while (choice != yes && choice != no)
            {
                Console.WriteLine(editAge);
                choice = IsNum();
            }
            if (choice == no)
                return emptyAge;
            Console.WriteLine(enterAge);
            return IsNum();

        }

        private Roles RoleEditor()
        {
            Console.WriteLine(editRole);
            int choice = IsNum();
            while (choice != yes && choice != no)
            {
                Console.WriteLine(editRole);
                choice = IsNum();
            }
            if (choice == no)
                return Null;
            Console.WriteLine(enterRole);
            choice = IsNum();
            while (!roles.Contains(choice))
            {
                Console.WriteLine(enterRole);
                choice = IsNum();
            }
            switch (choice)
            {
                case 1:
                    return Role1;
                case 2:
                    return Role2;
                default:
                    return Role3;
            }

        }
        private void EditUser()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsNotExist(Types.User, Id))
                throw new Exceptions(UserNotFound.Edit);
            Edit.Edit(Types.User, Id, NameEditor(), AgeEditor());
        }

        private void EditStaff()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsNotExist(Types.Staff, Id))
                throw new Exceptions(UserNotFound.Edit);
            Edit.Edit(Types.User, Id, NameEditor(), AgeEditor(), RoleEditor());
        }

        private void EditAdmin()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsNotExist(Types.Admin, Id))
                throw new Exceptions(UserNotFound.Edit);
            Edit.Edit(Types.Admin, Id, NameEditor(), AgeEditor());
        }

        private void EditMenuSwitch()
        {
            Console.WriteLine(editMenu);
            int choice = IsNum();
            switch (choice)
            {
                case 1:
                    EditUser();
                    break;
                case 2:
                    EditStaff();
                    break;
                case 3:
                    EditAdmin();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine(wrongInput);
                    break;
            }
        }
    }
}
