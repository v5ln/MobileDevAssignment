using static HW3.Helpers.StaticReferences;
using System;
using HW3.ViewModels;
using HW3.Helpers;

namespace HW3.Views
{
    public class DeleteView
    {
        private DeleteViewModel Delete;
        MenuViewModel MenuViewModel;
        public DeleteView(MenuViewModel MenuViewModel)
        {
            Delete = new DeleteViewModel(MenuViewModel);
            this.MenuViewModel = MenuViewModel;
            DeleteMenuSwitch();
        }

        private void DeleteUser()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsNotExist(Types.User, Id))
                throw new Exceptions(UserNotFound.Delete);
            Delete.Delete(Types.User, Id);
        }

        private void DeleteStaff()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsNotExist(Types.Staff, Id))
                throw new Exceptions(UserNotFound.Delete);
            Delete.Delete(Types.Staff, Id);
        }

        private void DeleteAdmin()
        {
            Console.WriteLine(enterId);
            int Id = IsNum();
            if (MenuViewModel.IsNotExist(Types.Admin, Id))
                throw new Exceptions(UserNotFound.Delete);
            Delete.Delete(Types.Admin, Id);
        }

        private void DeleteMenuSwitch()
        {
            Console.WriteLine(deleteMenu);
            int choice = IsNum();
            switch (choice)
            {
                case 1:
                    DeleteUser();
                    break;
                case 2:
                    DeleteStaff();
                    break;
                case 3:
                    DeleteAdmin();
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
