using MahasiswaAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahasiswaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MahasiswaController : ControllerBase
    {
        private readonly MahasiswaRepository mahasiswaRepository;
        public MahasiswaController(MahasiswaRepository mahasiswaRepository)
        {
            this.mahasiswaRepository = mahasiswaRepository;
        }
        //Funtions Api Get
        [HttpGet]
        public ActionResult Get() {
            return Ok(mahasiswaRepository.Get());
        }
    }
}
