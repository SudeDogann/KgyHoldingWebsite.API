using Microsoft.AspNetCore.Mvc;
using KgyHoldingWebsite.Application.Interfaces;
using KgyHoldingWebsite.Application.Dtos;

[ApiController]
[Route("api/[controller]")]
public class BoardMemberController : ControllerBase
{
    private readonly IBoardMemberService _service;

    public BoardMemberController(IBoardMemberService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var member = _service.GetById(id);
        if (member == null) return NotFound();
        return Ok(member);
    }

    [HttpPost]
    public IActionResult Post([FromBody] BoardMemberDto dto)
    {
        _service.Add(dto);
        return Ok(dto);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] BoardMemberDto dto)
    {
        var success = _service.Update(id, dto);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var success = _service.Delete(id);
        if (!success) return NotFound();
        return NoContent();
    }
}
