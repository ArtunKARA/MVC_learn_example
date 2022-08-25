﻿using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IServices<T> where T : class
    {

        Task<T> GetByID(int id);

        Task<T> GetAll(Expression<Func<T, bool>> expression);

        IQueryable<T> Where(Expression<Func<T, bool>> expression); //Yapılan sorguda hangileri doğru ise getirir
        //               fonksiyon alıp true yda false değer döndürür
        Task<bool> Any(Expression<Func<T, bool>> expression);  //Var yok sorguları yapmak için kullanılır
        //               fonksiyon alıp true yda false değer döndürür
        Task Add(T entity);   //ekleme işlemi yapıyoruz

        Task AddRange(IEnumerable<T> entities);

        Task Update(T entity);//güncelme yapılıcak

        Task Remove(T entity);//silme işlemi yapmak için

        Task RemoveRange(IEnumerable<T> entities);


    }
}
