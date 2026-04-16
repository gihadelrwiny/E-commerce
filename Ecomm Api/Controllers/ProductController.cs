using AutoMapper;
using Ecomm_Api.Helper;
using EcommCore.DTO;
using EcommCore.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm_Api.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController(IunitOfWork work, IMapper mapper) : base(work, mapper)
        {
        }
        [HttpGet("getall")]
        public async Task<IActionResult> getAll()
        {
            try
            {
                var products=await Work.productRepository.GetAllAsync(x=>x.Category,x=>x.Photos);
                var result=Mapper.Map<List<ProductDTO>>(products);
                if (products is null)
                {
                    return BadRequest(new ResponseApi(400));

                }
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> getById(int id)
        {
            try
            {
                var product = await Work.productRepository.GetByIdAsync(id, x => x.Category, x => x.Photos);
                var result = Mapper.Map<ProductDTO>(product);
                if (product is null)
                {
                    return BadRequest(new ResponseApi(400));
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        }
}
