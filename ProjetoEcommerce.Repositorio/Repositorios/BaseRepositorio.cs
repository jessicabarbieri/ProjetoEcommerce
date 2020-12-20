using ProjetoEcommerce.Dominio.Contratos;
using ProjetoEcommerce.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoEcommerce.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        // Armazenando a instancia do contexto internamente na classe
        protected readonly ProjetoContexto ProjetoContexto;
        public BaseRepositorio(ProjetoContexto projetoContexto)
        {
            ProjetoContexto = projetoContexto;
        }
        public void Adicionar(TEntity entity)
        {
            ProjetoContexto.Set<TEntity>().Add(entity);
            ProjetoContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            ProjetoContexto.Set<TEntity>().Update(entity);
            ProjetoContexto.SaveChanges();
        }


        public IEnumerable<TEntity> ObterTodos()
        {
            return ProjetoContexto.Set<TEntity>().ToList();
        }

        public TEntity ObterPorId(int Id)
        {
            return ProjetoContexto.Set<TEntity>().Find(Id);
        }

        public void Remover(TEntity entity)
        {
            ProjetoContexto.Set<TEntity>().Remove(entity);
            ProjetoContexto.SaveChanges();
        }
        public void Dispose()
        {
            ProjetoContexto.Dispose();
        }
    }
}
