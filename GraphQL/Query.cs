using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using System.Linq;

namespace CommanderGQL.GraphQL
{
    public class Query
    {
        public IQueryable<Plateform> GetPlateform([Service] AppDbContext context)
        {
            return context.Plateforms;
        }
    }
}