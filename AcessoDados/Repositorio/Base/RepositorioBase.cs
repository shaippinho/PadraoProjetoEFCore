using System;
using System.Linq;
using System.Threading.Tasks;

namespace AcessoDados.Repositorio.Base
{
    public abstract class RepositorioBase<TEntidade> : IDisposable, IRepositorio<TEntidade> where TEntidade : class
    {

        protected Modelo.Contexto Contexto { get; set; } = new Modelo.Contexto();

        public void Adicionar(TEntidade obj)
        {
            this.Contexto.Set<TEntidade>().Add(obj);
        }

        public void Atualizar(TEntidade obj)
        {
            this.Contexto.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public TEntidade Buscar(params object[] key)
        {
            return this.Contexto.Set<TEntidade>().Find(key);
        }


        public void Excluir(Func<TEntidade, bool> predicado)
        {
            this.Contexto.Set<TEntidade>()
            .Where(predicado)
            .ToList()
            .ForEach(x => this.Contexto.Set<TEntidade>().Remove(x));
        }

        public IQueryable<TEntidade> Obter(Func<TEntidade, bool> predicado)
        {
            return this.ObterTodos().Where(predicado).AsQueryable();
        }

        public IQueryable<TEntidade> ObterTodos()
        {
            return this.Contexto.Set<TEntidade>();
        }

        public int SalvarTodos()
        {
            return this.Contexto.SaveChanges();
        }

        public async Task<int> SalvarTodosAsync()
        {
            return await this.Contexto.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.Contexto.Dispose();
        }
    }
}