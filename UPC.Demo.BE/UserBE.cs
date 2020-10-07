using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Demo.BE
{
    public class UserBE
    {
        public class Entity {
            public int Id { get; set; }
            public string UserName { get; set; }
            public byte[] Password { get; set; }
            public string Email { get; set; }
            public bool Active { get; set; }
            public int UserModifyId { get; set; }
        }

        public class Authentication {
            public string UserName { get; set; }
            public byte[] Password { get; set; }
        }

        public class ChangePassword
        {
            public string UserName { get; set; }
            public byte[] NewPassword { get; set; }
            public byte[] OldPassword { get; set; }
        }
    }
}
