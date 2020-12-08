using BakedInHeaven.DataAccess.Entities;
using System.Collections.Generic;

namespace BakedInHeaven.DataAccess.Repositories
{
    public interface IProductsRepository
    {
        List<Products> GetAllProducts();
        void Add(Products productEntity);
    }
}