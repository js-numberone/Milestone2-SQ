using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp1Test.Shared;

namespace BlazorApp1Test.Server.Data
{
    public class GForceParametersContext : DbContext
    {
        public GForceParametersContext (DbContextOptions<GForceParametersContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp1Test.Shared.GForceParameter> GForceParameters { get; set; }

        public DbSet<BlazorApp1Test.Shared.AttitudeParamater> AttitudeParameters { get; set; }
    }
}
