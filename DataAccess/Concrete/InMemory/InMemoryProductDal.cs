﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product {ProductId =  1, CategoryId  =1, ProductName = "Bardak", UnitPrice=15,UnitsInStock=15},
                new Product { ProductId = 2, CategoryId = 1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3 },
                new Product { ProductId = 3, CategoryId = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2 },
                new Product { ProductId = 4, CategoryId = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65 },
                new Product { ProductId = 5, CategoryId = 2, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1 },
            };
        }
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.FirstOrDefault(w => w.ProductId == product.ProductId);

            if (product != null)
                _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(w=> w.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductsDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToDelete = _products.FirstOrDefault(w => w.ProductId == product.ProductId);

            if (product != null)
            {
                product.CategoryId = product.CategoryId;
                product.ProductId = product.ProductId;
                product.ProductName = product.ProductName;
                product.UnitPrice = product.UnitPrice;
                product.UnitsInStock = product.UnitsInStock;
            }
              
        }
    }
}
