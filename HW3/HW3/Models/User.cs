using System;

namespace HW3.Models
{
    public class User
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }

        public User(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
        public override string ToString() => "Id: " + Id + "\nName: "
        + Name + "\nAge: " + Age;

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            User UserObject = (User)obj;
            if (UserObject.Id == Id &&
                UserObject.Name == Name &&
                UserObject.Age == Age)
                return true;
            return false;
        }
        public override int GetHashCode() => base.GetHashCode();

        public static explicit operator User(string v)
        {
            throw new NotImplementedException();
        }
    }
}
