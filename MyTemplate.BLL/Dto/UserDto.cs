using System;
using System.Collections.Generic;
using System.Text;

namespace MyTemplate.BLL.Dto
{
    public class UserDto
    {
        public Guid rowguid { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
