using AutoMapper;
using Ecomm_Api.Helper;
using EcommCore.DTO;
using EcommCore.Entites.product;
using EcommCore.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm_Api.Controllers
{

    public class CategoryController : BaseController
    {
        public CategoryController(IunitOfWork work, IMapper mapper) : base(work, mapper)
        {
        }

        //generate constructor for category controller and pass the IunitOfWork to the base controller

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var categories = await Work.catogeryRepository.GetAllAsync();
                if (categories is null)
                {
                    return BadRequest(new ResponseApi(400));
                }
                return Ok(categories);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var category = await Work.catogeryRepository.GetByIdAsync(id);
                if (category is null)
                {
                    return BadRequest(new ResponseApi(400));
                }
                return Ok(category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("addasync")]
        public async Task<IActionResult> addasync(CategoryDTO categorydto)
        {
            try
            {
                //var category = new Category()
                //{
                //    Name = categorydto.name,
                //    Description = categorydto.description
                //}; -->عملت mapping بين ال DTO وال entity عشان ما اعملش كود كتير
                var category=Mapper.Map<Category>(categorydto);
                await Work.catogeryRepository.addasync(category);
                return Ok(new ResponseApi(200));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("updateasync")]
        public async Task<IActionResult> updateasync(UpdateCategoryDTO categorydto)
        {
            try
            {
              var category=Mapper.Map<Category>(categorydto);
                await Work.catogeryRepository.updateasync(category);
                return Ok(new ResponseApi(200));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("removeasync/{id}")]
        public async Task<IActionResult> removeasync(int id)
        {
            try
            {
                await Work.catogeryRepository.removeasync(id);
                return Ok(new ResponseApi(200,"item is removed"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }



        }
}