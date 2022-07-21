using Microsoft.AspNetCore.Mvc;
namespace GettingStartedAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    // GET: api/<UsersController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        List<string> output = new();
        for(int i=0; i < Random.Shared.Next(minValue:2, maxValue:10); i++)
        {
            output.Add($"Value #{ i+1}");
        }
        return output ;
    }

    // GET api/<UsersController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return $"Value {id+1}";
    }

    // POST api/<UsersController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<UsersController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<UsersController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
