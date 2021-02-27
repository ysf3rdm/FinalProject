using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //Business kodlar
            if (product.ProductName.Length<2)
            {
                return new ErrorResult(Messages.ProductNameİnvalid);
            }
            _productDal.Add(product); 
            return new Result(true,Messages.ProductAdded);
        }

        public DataResult<List<Product>> GetAll()
        {
            return new DataResult<List<Product>>(_productDal.GetAll(),true,"ürünler listelendi");
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int Id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);  
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        IDataResult<Product> IProductService.Add(Product product)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Product>> IProductService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Product> IProductService.GetById(int productId)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<ProductDetailDto>> IProductService.GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
