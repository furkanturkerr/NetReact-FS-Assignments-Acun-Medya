using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Abstracts;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        //[HttpPost]
        //public void Add(Brand brand)
        //{
        //    _brandService.Add(brand);
        //}


        //[HttpGet]
        //public List<Brand> GetAll()
        //{
        //    return _brandService.GetAll();
        //}


        [HttpPost]
        public ActionResult<CreatedBrandResponse> Add([FromBody] CreateBrandRequest request)
        {
            return Created("", _brandService.Add(request));
        }


        [HttpGet]
        public ActionResult<List<GetListBrandResponse>> GetAll()
        {
            return Ok(_brandService.GetList());
        }
    }
}
    