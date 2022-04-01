using System;
using static HW3.Helpers.StaticReferences;
using HW3.ViewModels;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using HW3.Models;
using static System.Collections.Specialized.NotifyCollectionChangedAction;

namespace HW3.Views
{
    public class MenuView
    {
        public MenuViewModel MenuViewModel;
        public MenuView()
        {
            MenuViewModel = new MenuViewModel();

            MenuViewModel.Users.CollectionChanged += notifyUsersEventHandler;
            MenuViewModel.StaffUsers.CollectionChanged += notifyStaffUsersEventHandler;
            MenuViewModel.AdminUsers.CollectionChanged += notifyAdminUsersEventHandler;
        }



        private void notifyUsersEventHandler(object sender, NotifyCollectionChangedEventArgs e)
        {
            ObservableCollection<User> users = (ObservableCollection<User>)sender;
            switch (e.Action)
            {
                case Add:
                    Console.WriteLine(UserAdded + e.NewItems[0] + ListCount + users.Count + ChangedLine);
                    break;
                case Remove:
                    Console.WriteLine(UserDeleted + e.OldItems[0] + ListCount + users.Count + ChangedLine);
                    break;
                case Replace:
                    Console.WriteLine(UserEdited + Before + e.OldItems[0] + After + e.NewItems[0] + ChangedLine);
                    break;

            }
        }
        private void notifyStaffUsersEventHandler(object sender, NotifyCollectionChangedEventArgs e)
        {
            ObservableCollection<StaffUser> users = (ObservableCollection<StaffUser>)sender;
            switch (e.Action)
            {
                case Add:
                    Console.WriteLine(UserAdded + e.NewItems[0] + ListCount + users.Count + ChangedLine);
                    break;
                case Remove:
                    Console.WriteLine(UserDeleted + e.OldItems[0] + ListCount + users.Count + ChangedLine);
                    break;
                case Replace:
                    Console.WriteLine(UserEdited + Before + e.OldItems[0] + After + e.NewItems[0] + ChangedLine);
                    break;

            }
        }

        private void notifyAdminUsersEventHandler(object sender, NotifyCollectionChangedEventArgs e)
        {
            ObservableCollection<AdminUser> users = (ObservableCollection<AdminUser>)sender;
            Console.WriteLine(e.Action);
            switch (e.Action)
            {
                case Add:
                    Console.WriteLine(UserAdded + e.NewItems[0] + ListCount + users.Count + ChangedLine);
                    break;
                case Remove:
                    Console.WriteLine(UserDeleted + e.OldItems[0] + ListCount + users.Count + ChangedLine);
                    break;
                case Replace:
                    Console.WriteLine(UserEdited + Before + e.OldItems[0] + After + e.NewItems[0] + ChangedLine);
                    break;

            }
        }

        public void MenuSwitch()
        {
            int choice = 0;
            while (choice != exitChoice)
            {
                Console.WriteLine(menu);
                choice = IsNum();
                switch (choice)
                {
                    case 1:
                        _ = new AddView(MenuViewModel);
                        break;

                    case 2:
                        _ = new EditView(MenuViewModel);
                        break;

                    case 3:
                        _ = new DeleteView(MenuViewModel);
                        break;

                    case 4:
                        _ = new PrintView(MenuViewModel);
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
}
