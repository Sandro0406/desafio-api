using System.Collections.Generic;
using System.Linq;
using workstation_backend.SearchContext.Domain;
using workstation_backend.SearchContext.Domain.Models;

namespace workstation_backend.SearchContext.Infrastructure;

public class InMemoryPlaceRepository : IPlaceRepository {
    private readonly List<Place> _places = new() {
        new Place { Id = 1, Title = "searchResults.item1.title", Location = "San Miguel 300-398, Lima 15047", Description = "searchResults.item1.description" },
        new Place {  Id = 2, Title = "searchResults.item2.title", Location = "C. Piura, Miraflores 15074", Description = "searchResults.item2.description"  },
    };

    public List<Place> GetAll() => _places;

    public Place? FindById(int id) => _places.FirstOrDefault(p => p.Id == id);

    public void Reserve(int id) {
        var place = FindById(id);
        if (place != null) place.IsReserved = true;
    }
}