using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities;

namespace Business.Abstracts;
public interface IBrandService
{
    //void Add(Brand brand);
    //List<Brand> GetAll();


    //Request-Response Pattern

    CreatedBrandResponse Add(CreateBrandRequest request);
    List<GetListBrandResponse> GetList();
}
