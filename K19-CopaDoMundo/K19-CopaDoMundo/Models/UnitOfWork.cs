using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K19_CopaDoMundo.Models
{
    public class UnitOfWork: IDisposable
    {
        private bool disposed = false;
        private K19CopaDoMundoContext context = new K19CopaDoMundoContext();
        private SelecaoRepository selecaoRepository;
        private JogadorRepository jogadorRepository;

        public JogadorRepository JogadorRepository
        {
            get
            {
                if (jogadorRepository == null)
                {
                    jogadorRepository = new JogadorRepository(context);
                }

                return jogadorRepository;
            }
        }

        public SelecaoRepository SelecaoRepository
        {
            get
            {
                if (selecaoRepository == null)
                {
                    selecaoRepository = new SelecaoRepository(context);
                }
                return selecaoRepository;
            }
        }

        public void Salva()
        {
            context.SaveChanges();
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