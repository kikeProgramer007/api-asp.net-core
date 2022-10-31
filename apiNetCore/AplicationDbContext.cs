using apiNetCore.Models;                //importar model
using Microsoft.EntityFrameworkCore;    //importar para DbContext
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiNetCore
{
    //DbContext es una instacia de la bd para interactuar con ella
    public class AplicationDbContext: DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
            
        }
    }
}
