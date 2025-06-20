using System.Collections.Generic;
using workstation_backend.SearchContext.Domain.Models;

namespace workstation_backend.SearchContext.Domain;

public interface IPlaceRepository {
    List<Place> GetAll();
    Place? FindById(int id);
    void Reserve(int id);
}