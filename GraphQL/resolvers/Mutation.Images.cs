using DomainLib.Entities;
using ServicesLib.EntitiesService;
using Solution1.Dto;

namespace Solution1.GraphQL.resolvers;

public partial class Mutation
{   
    
    public  ImageEntity addImage([Service] ImageService imageService,CreateImageDto imageDto)
    {
        return imageService.createImage(imageDto);
    }
}