using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using System.Linq;
using HotChocolate.Data;

namespace CommanderGQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        public IQueryable<Plateform> GetPlateform([ScopedService] AppDbContext context)
        {
            return context.Plateforms;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        public IQueryable<Command> GetCommand([ScopedService] AppDbContext context)
        {
            return context.Commands;
        }
    }
}