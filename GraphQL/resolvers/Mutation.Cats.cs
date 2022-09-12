using DomainLib.Entities;
using ServicesLib.EntitiesService;
using Solution1.Dto;

namespace Solution1.GraphQL.resolvers;

public partial class Mutation
{
    [UseFirstOrDefault]
    [UseProjection]
    [UseFiltering]
    public  IQueryable<CatEntity> createCat([Service] CatService catService,CreateCatDto catDto)
    {
        return catService.CreateCat(catDto);
    }
}