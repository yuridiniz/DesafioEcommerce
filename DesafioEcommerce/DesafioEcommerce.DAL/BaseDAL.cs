using DesafioEcommerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.DAL
{
    /// <summary>
    /// Classe abstrata para listagem generica de dados
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class BaseDAL<TEntity> where TEntity : class, IEntity
    {
        protected EcommerceDB DbContext;

        public BaseDAL() {
            DbContext = new EcommerceDB();
        }

        /// <summary>
        /// Obtém a coleção de entidades do <see cref="TEntity"/>
        /// </summary>
        /// <returns></returns>
        protected abstract DbSet<TEntity> GetCollection();

        /// <summary>
        /// Lista todas as <see cref="TEntity"/>
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntity> GetAll()
        {
            return GetCollection();
        }

        /// <summary>
        /// Obtém um <see cref="TEntity"/> por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity GetById(Guid id)
        {
            return GetCollection().FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Insere um <see cref="TEntity"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity Insert(TEntity entidade)
        {
            entidade.Id = Guid.NewGuid();
            GetCollection().Add(entidade);
            DbContext.SaveChanges();

            return entidade;
        }

        /// <summary>
        /// Remove um <see cref="TEntity"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Remove(TEntity entidade)
        {
            GetCollection().Remove(entidade);
            DbContext.SaveChanges();
        }

        /// <summary>
        /// Remove um <see cref="TEntity"/> por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void RemoveById(Guid id)
        {
            var entidade = GetById(id);
            GetCollection().Remove(entidade);
            DbContext.SaveChanges();
        }

    }
}
