using System.Collections.Generic;
using System.Collections.ObjectModel;
using static HW3.Helpers.StaticReferences;
namespace HW3.Models
{
    public class AdminUser : User
    {
        public ObservableCollection<StaffUser> StaffUsers;
        public AdminUser(int Id, string Name, int Age) : base(Id, Name, Age)
        {
            StaffUsers = new ObservableCollection<StaffUser>();
        }
        public override string ToString()
        {
            string staffusers = "";
            if (StaffUsers.Count != 0)
                staffusers += "\nStaff users under this admin:\n";
            foreach (StaffUser user in StaffUsers)
            {
                staffusers += user.ToString();
                staffusers += line;
            }
            return "Id: " + Id + "\nName: "
            + Name + "\nAge: " + Age + staffusers;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            AdminUser UserObject = (AdminUser)obj;
            if (!base.Equals(UserObject))
                return false;
            if (StaffUsers.Count != UserObject.StaffUsers.Count)
                return false;
            int count = StaffUsers.Count;
            for (int i = 0; i < count; i++)
                if (!StaffUsers[i].Equals(UserObject.StaffUsers[i])) return false;
            return true;
        }
        public override int GetHashCode() => base.GetHashCode();
    }
}
