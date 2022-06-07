using Microsoft.AspNetCore.Mvc;
using CleanArchitectureMovie.Application.Interfaces.Services;
using CleanArchitectureMovie.Domain;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }
    // GET: api/<MovieApiController>
    [HttpGet]
    public IEnumerable<Movie> Get()
    {
        return _movieService.GetAll();
    }

    // GET api/<MovieApiController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<MovieApiController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<MovieApiController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<MovieApiController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
