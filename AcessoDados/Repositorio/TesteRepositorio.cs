using System.Linq;
using AcessoDados.Repositorio.Base;
using Dominio.Entidades;

namespace AcessoDados.Repositorio
{
    public class TesteRepositorio : RepositorioBase<Teste>
    {
        public Teste ObterPelaDescricao(string nome)
        {
            return this.Contexto.Testes.Where(a => a.Valor == nome).FirstOrDefault();
        }
    }
}