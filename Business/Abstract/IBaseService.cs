﻿using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBaseService<T> where T : IEntity
    {
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int id);
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
        IResult AddTransactionalTest(T entity);
    }
}
