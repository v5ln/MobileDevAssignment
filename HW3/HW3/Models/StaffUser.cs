namespace HW3.Models
{
    public class StaffUser : User
    {
        public enum Roles { Role1, Role2, Role3, Null };
        public Roles Role { get; set; }

        public StaffUser(int Id, string Name, int Age, Roles Role) : base(Id, Name, Age)
        {
            this.Role = Role;
        }

        public override string ToString() => base.ToString() + "\nRole: " + Role;

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            StaffUser UserObject = (StaffUser)obj;
            if (base.Equals(UserObject) &&
                UserObject.Role == Role)
                return true;
            return false;
        }
        public override int GetHashCode() => base.GetHashCode();

    }
}
