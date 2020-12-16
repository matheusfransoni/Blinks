using Blinks.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blinks.Repo { 
    public class PlanilhaContexto : DbContext
    {
     

        public PlanilhaContexto (DbContextOptions<PlanilhaContexto> options) : base(options) {}




        public DbSet<Planilha> Planilhas { get; set; }



    }
}
