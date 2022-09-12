using DomainLib;
using DomainLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.EntitiesService;
using Solution1.Dto;

namespace Solution1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CatsController : Controller
{
    private readonly DataBaseContext _dbContext;
    private readonly CatService _catService;

    public CatsController(DataBaseContext dbContext,CatService catService)
    {
        _dbContext = dbContext;
        _catService = catService;

    }

    [HttpGet("hui")]
    public async Task<IEnumerable<CatEntity>> getAll()
    {
        return this._dbContext.Cats;
    }
    
    
    [HttpPost("create")]
    public  void CreateCat(CreateCatDto catDto)
    { 
        _catService.CreateCat(catDto);
    }
}