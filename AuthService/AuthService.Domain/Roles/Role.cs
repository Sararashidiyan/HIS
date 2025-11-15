using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.SharedKernel;

namespace AuthService.Domain.Roles
{
    public class Role : AuditableEntityBase<long>, IAggrigateRoot
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public bool IsActive { get;private set; }
        public Role()
        {
            
        }
        public Role(string title)
        {
            Title = title;
            IsActive = true;
        }
        public void Update(string title)
        {
            Title = title;
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
