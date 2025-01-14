﻿using Business.Abstract;
using Entities.Conctre;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public ImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }


        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = "ImagePath")] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Add(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]

        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPatch("update")]
        public IActionResult Update([FromForm(Name = "ImagePath")] IFormFile file, [FromForm]  CarImage carImage)
        {
            var result = _carImageService.Update(file, carImage);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getimagesbycarid")]
        public IActionResult GetImagesByCarId(int id)
        {
            var result = _carImageService.GetImagesByCarId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
