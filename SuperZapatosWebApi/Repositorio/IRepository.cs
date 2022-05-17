using SuperZapatosWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperZapatosWebApi.Repositorio
{
    public interface IRepository
    {
        DtoResponse<int> Insert<T>(T entidad) where T : class;
        IQueryable<T> Read<T>(Func<T, bool> filtro, bool esCargaPerezosa) where T : class;
        DtoResponse<int> Update<T>(T entidad) where T : class;
        DtoResponse<int> Update();
        DtoResponse<int> Delete<T>(T entidad) where T : class;
        DataContext GetDataAccess();
    }
}
