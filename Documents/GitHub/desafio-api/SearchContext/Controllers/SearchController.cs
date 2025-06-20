using Microsoft.AspNetCore.Mvc;
using workstation_backend.SearchContext.Domain;

namespace workstation_backend.SearchContext.Controllers;

[ApiController]
[Route("api/search")]
public class SearchController : ControllerBase {
    private readonly ISearchService _service;
    public SearchController(ISearchService service) => _service = service;

    [HttpGet("places")]
    public IActionResult GetPlaces() => Ok(_service.Search());

    [HttpPost("reserve/{id}")]
    public IActionResult Reserve(int id) =>
        _service.ReservePlace(id) ? Ok("Reservado") : BadRequest("No disponible");
}