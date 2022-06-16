﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Insert(T parameter);
        void Delete(T parameter);
        void Update(T parameter);
        List<T> getList();
        T getById(int id);
    }
}
