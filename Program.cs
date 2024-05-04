using CommanderGQL.Data;
using CommanderGQL.GraphQL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region services zone - BEGIN

builder.Services.
    AddDbContext<AppDbContext>(options => options.UseSqlServer("name=CommandConstr"));

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>();

#endregion services zone - end

#region Middlewares zone - BEGIN
var app = builder.Build();

app.MapGraphQL();
app.MapGet("/", () => "Hello World!");

#endregion Middlewares zone - END

app.Run();