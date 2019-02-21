using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K19_CopaDoMundo.Models
{
    public class JogadorRepository: IDisposable
    {
        private bool disposed = false;
        private K19CopaDoMundoContext context;

        public JogadorRepository(K19CopaDoMundoContext context)
        {
            this.context = context;
        }

        public void Adiciona(Jogador jogador)
        {
            context.Jogadores.Add(jogador);
        }

        public List<Jogador> Jogadores
        {
            get{ return context.Jogadores.ToList(); }
        }

        public void Salva()
        {
            context.SaveChanges();
        }

        public Jogador Busca(int id)
        {
            return context.Jogadores.Find(id);
        }

        public void Remove(int id)
        {
            Jogador jogador = Busca(id);
            context.Jogadores.Remove(jogador);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }

                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}