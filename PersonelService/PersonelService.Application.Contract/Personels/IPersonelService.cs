using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonelService.Application.Contract.Personels.Commands;
using PersonelService.Application.Contract.Personels.Dtos;

namespace PersonelService.Application.Contract.Personels
{
    public interface IPersonelService
    {
        Task<List<PersonelDto>> GetAll();
        Task<PersonelDto> GetById(int id);
        Task Add(AddPersonelCommand command);
        Task Modify(ModifyPersonelCommand command);
        Task Delete(int id);
    }
}
