using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using ReCapEntities.Concrete;

namespace ReCapBusiness.Abstarct
{
    public interface ICarImagesServices
    {
        IResult Add(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IDataResult<CarImage> Get(int id);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetImagesByCarId(int id);
    }
}
