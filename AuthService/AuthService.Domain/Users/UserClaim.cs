using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.SharedKernel;

namespace AuthService.Domain.Users
{
    public class UserClaim:ValueObject
    {
        public UserClaim()
        {
            
        }
        public UserClaim(string type, string value)
        {
            Type=type;
            Value = value;
        } 
        public long Id { get;private set; }
        public long UserId { get; private set; }
        public string Type { get; private set; }
        public string Value { get; private set; }
    }
}
