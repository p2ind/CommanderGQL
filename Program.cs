using CommanderGQL.Data;
using CommanderGQL.GraphQL;
using Microsoft.EntityFrameworkCore;
using GraphQL.Server.Ui.Voyager;

var builder = WebApplication.CreateBuilder(args);

#region services zone - BEGIN

builder.Services.
    AddPooledDbContextFactory<AppDbContext>(options => options.UseSqlServer("name=CommandConstr"));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddProjections();

#endregion services zone - end

#region Middlewares zone - BEGIN
var app = builder.Build();

 app.MapGraphQL();
app.UseGraphQLVoyager("/graphql-voyager",new VoyagerOptions {GraphQLEndPoint = "/graphql" });

app.MapGet("/", () => "Hello World!");

#endregion Middlewares zone - END

app.Run();