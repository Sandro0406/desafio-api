using System.Collections.Generic;
using workstation_backend.SearchContext.Domain;
using workstation_backend.SearchContext.Domain.Models;

namespace workstation_backend.SearchContext.Application;

public class SearchService : ISearchService {
    private readonly IPlaceRepository _repo;
    public SearchService(IPlaceRepository repo) => _repo = repo;

    public List<Place> Search() => _repo.GetAll();

    public bool ReservePlace(int id) {
        var place = _repo.FindById(id);
        if (place == null || place.IsReserved) return false;
        _repo.Reserve(id);
        return true;
    }
}