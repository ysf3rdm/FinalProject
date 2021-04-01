using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryDal;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryDal = categoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Thread.Sleep(500);

            var result = _categoryDal.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }

            return BadRequest(result);

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _categoryDal.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
