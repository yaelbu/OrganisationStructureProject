using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organisation.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Firstnane { get; set; }
        public string Lastname { get; set; }
        public string Status { get; set; }
        public string Position { get; set; }
        public int ManagerId { get; set; }
        public string Image { get; set; }
    }
}
