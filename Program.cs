using DomainLib;
using ServicesLib;
using Solution1;
using Solution1.GraphQL.resolvers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDomainLib(builder.Configuration);
builder.Services.AddServicesLib();

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSorting()
    .AddFiltering()
    .AddProjections();



var app = builder.Build();

app.MapControllers();
app.UseRouting();
app.MapGraphQL("/api/graphql/");

app.Run();