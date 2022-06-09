using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ECommerceContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails(Product product)
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             join ph in context.Photos
                             on p.Id equals ph.ProductId
                             select new ProductDetailDto
                             {
                                 ProductId = p.Id,
                                 CategoryName = c.Name,
                                 ProductName = p.Name,
                                 UnitsInStock = p.UnitsInStock,
                                 Photos = (from photo in context.Photos where photo.ProductId == product.Id select photo).ToList()
                             };
                return result.ToList();
            }
        }
    }
}
