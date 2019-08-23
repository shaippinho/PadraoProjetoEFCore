using System.Linq;
using System;
using System.Threading.Tasks;

namespace AcessoDados.Repositorio.Base
{
    public interface IRepositorio<TEntidade> where TEntidade : class
    {
        IQueryable<TEntidade> ObterTodos();

        IQueryable<TEntidade> Obter(Func<TEntidade, bool> predicado);

        TEntidade Buscar(params object[] key);

        void Adicionar(TEntidade obj);

        void Atualizar(TEntidade obj);

        void Excluir(Func<TEntidade, bool> predicado);

        int SalvarTodos();

        Task<int> SalvarTodosAsync();
    }
}