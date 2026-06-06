using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers;

public class MyModel
{
    public string Name { get; set; }
    
    public int Age { get; set; }
}

[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<MyModel>> BlaBlaBla(int id)
    {
        var model = new MyModel { Name = "John", Age = 20 };
        
        if(id <= 0)
        {
            return BadRequest();
        }

        var a = new List<int>().First();

        Created();
        NoContent();
        return Ok(model);
    }

    [HttpPost]
    public async Task<IActionResult> Create()
    {
        return Ok();
    }
}

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<MyModel>> BlaBlaBla(int id)
    {
        var model = new MyModel { Name = "John", Age = 20 };
        
        if(id <= 0)
        {
            return BadRequest();
        }

        var a = new List<int>().First();

        Created();
        NoContent();
        return Ok(model);
    }
}

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<MyModel>> BlaBlaBla()
    {
        var model = new MyModel {Name = "John", Age = 20};
        
        return Ok(model);
    }
    
    [HttpPost]
    public async Task<IActionResult> BlaBlaBla4()
    {
        return Ok();
    }
    
    [HttpPut]
    public async Task<IActionResult> BlaBlaBla3()
    {
        return Ok();
    }
    
    [HttpPatch]
    public async Task<IActionResult> BlaBlaBla2()
    {
        return Ok();
    }
    
    [HttpDelete]
    public async Task<IActionResult> BlaBlaBla1()
    {
        return Ok();
    }
}