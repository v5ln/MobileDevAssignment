using System;
using static HW3.Helpers.StaticReferences;
namespace HW3.Helpers
{
    [Serializable]
    public class Exceptions : Exception
    {
        public Exceptions(UserAlreadyExist userAlreadyExist)
            : base("[Duplicate Error] User Id Is Already Exist. {" + userAlreadyExist + "}")
        {
            Console.WriteLine("[Duplicate Error] User Id Is Already Exist. {" + userAlreadyExist + "}");
        }
        public Exceptions(UserNotFound userNotFound)
            : base("[Not Found Error] User Id Does Not Exist. {" + userNotFound + "}")
        {
            Console.WriteLine("[Not Found Error] User Id Does Not Exist. {" + userNotFound + "}");
        }
        public Exceptions(InputTypeNotValid inputTypeNotValid)
            : base("[Invalid Input Error] Input Type Is Not Valid. {" + inputTypeNotValid + "}")
        {
            Console.WriteLine("[Invalid Input Error] Input Type Is Not Valid. {" + inputTypeNotValid + "}");
        }
    }
}
