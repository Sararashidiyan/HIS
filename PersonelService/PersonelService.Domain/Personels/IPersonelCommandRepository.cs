using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.SharedKernel;

namespace PersonelService.Domain.Personels
{
    internal interface IPersonelCommandRepository:ICommandRepository<long,Personel>
    {
    }
}
