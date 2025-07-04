﻿using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/[controller]")]
public class LifeAtKgyController : ControllerBase
{
    private readonly KgyDbContext _context;
    public LifeAtKgyController(KgyDbContext context) => _context = context;

    [HttpGet] public async Task<IActionResult> Get() => Ok(await _context.LifeAtKgys.ToListAsync());
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] LifeAtKgy item)
    {
        _context.LifeAtKgys.Add(item);
        await _context.SaveChangesAsync();
        return Ok(item);
    }
}
