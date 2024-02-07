using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract;

public interface IGenericDal<T> where T : class, IEntity,new()
{
    List<T> GetAll();
    void Add(T t);
    void Delete(T t);
    void Update(T t);
    List<T> GetList();
    T GetById(int id);
    List<T> GetAllFilter(Expression<Func<T, bool>> filter);

}
