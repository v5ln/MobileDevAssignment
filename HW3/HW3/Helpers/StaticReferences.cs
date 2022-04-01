using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace HW3.Helpers
{
    public class StaticReferences
    {
        public enum Types { User, Staff, Admin, AllUser, AllStaff, AllAdmin, StaffList };
        public enum UserNotFound { Print, Edit, Delete, AddToAdmin }
        public enum UserAlreadyExist { Add, AddToAdmin }
        public enum InputTypeNotValid { Numeric, Alphabet }
        public const string emptyName = "";
        public const int emptyAge = -1;
        public const int emptyID = -1;
        public static readonly Regex regexNum = new Regex(@"^\d+$");
        public static readonly Regex regexAlpha = new Regex(@"[^a-zA-Z]");
        public readonly static List<int> roles = new List<int> { 1, 2, 3 };
        public readonly static int yes = 1;
        public readonly static int no = 2;
        public readonly static int exitChoice = 5;
        public readonly static string line = "----------------\n";
        public readonly static string wrongInput = "Wrong input, try again";
        public readonly static string ChangedLine = "\n^^^^^^^^^^^^^^^\n";
        public readonly static string UserAdded = ChangedLine+ "New User Added:\n";
        public readonly static string UserDeleted = ChangedLine+ "User Deleted:\n";
        public readonly static string UserEdited = ChangedLine+ "User Updated:\n";
        public readonly static string Before = ChangedLine + "Before Editing:\n";
        public readonly static string After = ChangedLine + "\nAfter Editing:\n";
        public readonly static string ListCount = "\nList Count Now: ";

        public readonly static string menu = line +
            "Enter Your Choice:\n" +
            "1- Add User\n" +
            "2- Edit User\n" +
            "3- Delete User\n" +
            "4- Print User Details\n" +
            "5- Exit\n" + line;
        public readonly static string addMenu = line +
            "Enter Your Choice:\n" +
            "1- Add User\n" +
            "2- Add Staff User\n" +
            "3- Add Admin User\n" +
            "4- Attach Staff User into Admin\n" +
            "5- Return\n" + line;
        public readonly static string deleteMenu = line +
            "Enter Your Choice:\n" +
            "1- Delete User\n" +
            "2- Delete Staff User\n" +
            "3- Delete Admin User\n" +
            "4- Return\n" + line;
        public readonly static string printMenu = line +
            "Enter Your Choice:\n" +
            "1- Print User Details\n" +
            "2- Print Staff User Details\n" +
            "3- Print Admin User Details\n" +
            "4- Print All Users Details\n" +
            "5- Print Staff Users Details\n" +
            "6- Print Admin Users Details\n" +
            "7- Print Staff User In Admin Details\n" +
            "8- Return\n" + line;
        public readonly static string editMenu = line +
            "Enter Your Choice:\n" +
            "1- Edit User\n" +
            "2- Edit Staff User\n" +
            "3- Edit Admin User\n" +
            "4- Return\n" + line;
        public readonly static string editName =
            "Do You Want Edit The Name?\n" +
            "1- Yes\n" +
            "2- No\n";
        public readonly static string editAge =
            "Do You Want Edit The Age?\n" +
            "1- Yes\n" +
            "2- No\n";
        public readonly static string editRole =
            "Do You Want Edit The Role?\n" +
            "1- Yes\n" +
            "2- No\n";
        public readonly static string enterId = "Enter The Id\n";
        public readonly static string enterName = "Enter The Name\n";
        public readonly static string enterAge = "Enter The Age\n";
        public readonly static string enterRole =
            "Enter The Role:\n" +
            "1- Role 1\n" +
            "2- Role 2\n" +
            "3- Role 3\n";

        public static int IsNum()
        {
            string input = Console.ReadLine();
            while (true)
            {
                if (regexNum.IsMatch(input))
                    return Convert.ToInt32(input);
                Console.WriteLine(wrongInput);
                input = Console.ReadLine();
            }
        }
        public static string IsAlpha()
        {
            string input = Console.ReadLine();
            while (true)
            {
                if (!regexAlpha.IsMatch(input))
                    return input;
                Console.WriteLine(wrongInput);
                input = Console.ReadLine();
            }
        }
    }
}
