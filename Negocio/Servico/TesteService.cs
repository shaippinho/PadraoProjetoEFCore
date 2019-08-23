using AcessoDados.Repositorio;
using Dominio.Entidades;
using System.Linq;

namespace Negocio.Servico
{
    public class TesteService
    {
        private readonly TesteRepositorio repositorio;

        public TesteService()
        {
            this.repositorio = new TesteRepositorio();
        }

        public Teste Obter(string nome)
        {
            return this.repositorio.ObterPelaDescricao(nome);
        }

    }
}