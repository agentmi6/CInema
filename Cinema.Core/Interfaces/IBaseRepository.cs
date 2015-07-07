﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Cinema.Core.Entities;namespace Cinema.Core.Interfaces
{
    public interface IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        void Add(TEntity entity);

        TEntity GetById(int id);

        List<TEntity> GetAll();
        void Save(); 
    }
}
