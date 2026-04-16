using AutoMapper;
using EcommCore.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly IunitOfWork Work; //عشان يشوفه اللى وراث منه بس
       protected readonly IMapper Mapper;

     

        public BaseController(IunitOfWork work,IMapper mapper)
        {
            this.Work = work;
            this.Mapper = mapper;   
        }

       
    }
}
