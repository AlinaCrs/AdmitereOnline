using System;
using System.Collections.Generic;

namespace AdmitereOnline.API.Models
{
    public class User
    {
         public int Id { get; set;}

         public string Username { get; set;}
         public byte[] PasswordHash { get; set; }
         public byte[] PasswordSalt { get; set; }
         public string FullName { get; set; }
         public string emailAddress { get; set; }
         public string CNP { get; set; }
         public string PhoneNo { get; set; }

    }
}