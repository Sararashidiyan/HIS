using Microsoft.AspNetCore.Mvc;

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
    [HttpPatch("activate/{id}")]
    public async Task<IActionResult> Activate([FromRoute] int id)
    {
        await _service.Activate(id);
        return Ok();
    }
    [HttpPatch("deactivate/{id}")]
    public async Task<IActionResult> Deactivate([FromRoute] int id)
    {
        await _service.Deactivate(id);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        await _service.Delete(id);
        return Ok();
    }
}