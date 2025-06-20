using System.Collections.Generic;
using workstation_backend.SearchContext.Domain.Models;

namespace workstation_backend.SearchContext.Domain;

public interface ISearchService {
    List<Place> Search();
    bool ReservePlace(int id);
}