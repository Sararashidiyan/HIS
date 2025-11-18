using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Application.Contract.Roles.Dtos
{
    public class RoleDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
