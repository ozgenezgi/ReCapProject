using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using ReCapEntities.Concrete;

namespace ReCapBusiness.Abstarct
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GeyById(int customerId);
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
    }
}
