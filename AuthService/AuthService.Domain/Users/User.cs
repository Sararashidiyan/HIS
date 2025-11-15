using AuthService.Domain.Users;
using Company.SharedKernel;

namespace AuthService.Domain
{
    public class User : AuditableEntityBase<long>, IAggrigateRoot
    {
        public User()
        {

        }
        public NationalCode NationalCode { get; private set; }//Username
        public Email? Email { get; private set; }
        public Mobile Mobile { get; private set; }
        public List<int> RoleIds { get; private set; }
        public bool IsActive { get; private set; }
        public List<UserClaim> UserClaims { get; set; }
        public User(NationalCode nationalCode, Email email, Mobile mobile, List<int> roleIds)
        {
            NationalCode = nationalCode;
            Email = email;
            Mobile = mobile;
            IsActive = true;
            RoleIds = roleIds;
        }
        public void AssignClaim(string title, string value)
        {
            UserClaims ??= new List<UserClaim>();
            UserClaims.Add(new UserClaim(title, value));
        }
        public void Update(Email email, Mobile mobile)
        {
            Email = email;
            Mobile = mobile;
            UpdatedAt = DateTime.Now;
        }

        public void Activate()
        {
            IsActive = true;
            UpdatedAt = DateTime.Now;
        }
        public void Deactivate()
        {
            IsActive = false;
            UpdatedAt = DateTime.Now;
        }

    }

}
