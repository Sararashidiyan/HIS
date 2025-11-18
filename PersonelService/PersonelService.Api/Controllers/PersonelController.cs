using Microsoft.AspNetCore.Mvc;
using PersonelService.Application.Contract.Personels;
using PersonelService.Application.Contract.Personels.Commands;

public class PersonelController(IPersonelService _service) : ControllerBase
{
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var Personels = await _service.GetAll();
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var Personel = await _service.GetById(id);
        return Ok();
    }
    [HttpGet()]
    public async Task<IActionResult> Post(AddPersonelCommand command)
    {
        await _service.Add(command);
        return Ok();
    }
    [HttpGet()]
    public async Task<IActionResult> Put(ModifyPersonelCommand command)
    {
        await _service.Modify(command);
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        await _service.Delete(id);
        return Ok();
    }
}