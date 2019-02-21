using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace K19_CopaDoMundo.Models
{
    public class K19CopaDoMundoContext: DbContext
    {
        public DbSet<Selecao> Selecoes { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
    }
}