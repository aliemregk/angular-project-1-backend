using Core.Utilities.Results;
using Core.Utilities.Results.DataResults;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPhotoService
    {
        IResult Add(Photo photo);
        IResult Delete(Photo photo);
        IResult Update(Photo photo);
        IDataResult<List<Photo>> GetByCategoryId(int categoryId);
        IDataResult<List<Photo>> GetAllByProductId(int productId);
    }
}
