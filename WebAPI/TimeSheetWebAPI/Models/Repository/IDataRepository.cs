using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TimeSheetWebAPI.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        //TEntity Get(Guid Id);
        //IEnumerable<TEntity> Add(TEntity entity);
        //IEnumerable<TEntity> Update(TEntity dbEntity, TEntity entity);
        //IEnumerable<TEntity> Delete(TEntity entity);
    }
}
