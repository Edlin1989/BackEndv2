using BackEndv2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndv2
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
            { }
        public interface IRelationalTypeMappingSource : Microsoft.EntityFrameworkCore.Storage.ITypeMappingSource 
            { }
        public DbSet<TarjetaDeCredito> TarjetaDeCreditos { get; set; }

    }
}
