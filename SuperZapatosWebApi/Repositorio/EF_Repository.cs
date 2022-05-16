using SuperZapatosWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperZapatosWebApi.Repositorio
{
    public class EF_Repository : IRepository
    {
        public DataContext _entityframeworkContext;

        public EF_Repository()
        {
            _entityframeworkContext = new DataContext();
        }

        public DtoResponse<int> Update<T>(T entity) where T : class
        {
            DtoResponse<int> _respuesta;

            try
            {
                _entityframeworkContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
                _entityframeworkContext.SaveChanges();
                _respuesta = new DtoResponse<int>
                {
                    Estado = true,
                    Icono = IStatus.OK,
                    Resultado = 1
                };
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                _respuesta = new DtoResponse<int>
                {
                    Icono = IStatus.ERROR,
                    Excepcion = ex,
                    Mensaje = System.Reflection.MethodInfo.GetCurrentMethod().Name + " method execution failed."
                };
            }

            return _respuesta;
        }

        public DtoResponse<int> Update()
        {
            DtoResponse<int> _respuesta;

            try
            {
                _entityframeworkContext.SaveChanges();
                _respuesta = new DtoResponse<int>
                {
                    Estado = true,
                    Icono = IStatus.OK,
                    Resultado = 1
                };
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                _respuesta = new DtoResponse<int>
                {
                    Icono = IStatus.ERROR,
                    Excepcion = ex,
                    Mensaje = System.Reflection.MethodInfo.GetCurrentMethod().Name + " method execution failed."
                };
            }

            return _respuesta;
        }
        public DtoResponse<int> Delete<T>(T entidad) where T : class
        {
            DtoResponse<int> _respuesta;

            try
            {
                _entityframeworkContext.Entry<T>(entidad).State = System.Data.Entity.EntityState.Deleted;
                _entityframeworkContext.SaveChanges();
                _respuesta = new DtoResponse<int>
                {
                    Estado = true,
                    Icono = IStatus.OK,
                    Resultado = 1
                };
            }
            catch (Exception ex)
            {
                _respuesta = new DtoResponse<int>
                {
                    Icono = IStatus.ERROR,
                    Excepcion = ex,
                    Mensaje = System.Reflection.MethodInfo.GetCurrentMethod().Name + " method execution failed."
                };
            }

            return _respuesta;
        }
        public DtoResponse<int> Insert<T>(T entidad) where T : class
        {
            DtoResponse<int> _respuesta;
            try
            {
                _entityframeworkContext.Set<T>().Add(entidad);
                _entityframeworkContext.SaveChanges();
                _respuesta = new DtoResponse<int>
                {
                    Estado = true,
                    Icono = IStatus.OK
                };
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                _respuesta = new DtoResponse<int>
                {
                    Icono = IStatus.ERROR,
                    Excepcion = ex,
                    Mensaje = System.Reflection.MethodInfo.GetCurrentMethod().Name + " method execution failed."
                };
            }

            return _respuesta;
        }
        public IQueryable<T> Read<T>(Func<T, bool> filter, bool isSlowCarge) where T : class
        {
            _entityframeworkContext.Configuration.LazyLoadingEnabled = isSlowCarge;
            IQueryable<T> _dbset;
            if (filter != null)
                _dbset = _entityframeworkContext.Set<T>().Where(filter) as IQueryable<T>;
            else
                _dbset = _entityframeworkContext.Set<T>();

            return _dbset;
        }
        public DataContext GetDataAccess()
        {
            return _entityframeworkContext;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}