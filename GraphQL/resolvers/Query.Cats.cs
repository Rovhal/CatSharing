using DomainLib.Entities;
using ServicesLib.EntitiesService;

namespace Solution1.GraphQL.resolvers;

public partial class Query
{
    [UseProjection]
    [UseFiltering]
    public IQueryable<CatEntity> GetAllCats([Service] CatService catService)
    {
        return catService.GetALlCats();
    }
}