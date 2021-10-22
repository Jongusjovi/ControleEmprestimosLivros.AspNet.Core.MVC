using ControleEmprestimosLivros.AspNet.Core.MVC.DATA.Interfaces;
using ControleEmprestimosLivros.AspNet.Core.MVC.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleEmprestimosLivros.AspNet.Core.MVC.DATA.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected dbContext dbcontext;
        public bool _SaveChanges = true;

        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            dbcontext = new dbContext();
        }

        public T Alterar(T objeto)
        {
            dbcontext.Entry(objeto).State = EntityState.Modified;

            if (_SaveChanges)
            {
                dbcontext.SaveChanges();
            }

            return objeto;
        }

        public void Dispose()
        {
            dbcontext.Dispose();
        }

        public void Excluir(T objeto)
        {
            dbcontext.Set<T>().Remove(objeto);

            if (_SaveChanges)
            {
                dbcontext.SaveChanges();
            }
        }

        public void Excluir(params object[] variavel)
        {
            var obj = SelecionarPk(variavel);
            Excluir(obj);
        }

        public T Incluir(T objeto)
        {
            dbcontext.Set<T>().Add(objeto);

            if (_SaveChanges)
            {
                dbcontext.SaveChanges();
            }

            return objeto;
        }

        public void SaveChanges()
        {
            dbcontext.SaveChanges();
        }

        public T SelecionarPk(params object[] variavel)
        {
            return dbcontext.Set<T>().Find(variavel);
        }

        public List<T> SelecionarTodos()
        {
            return dbcontext.Set<T>().ToList();
        }
    }
}
