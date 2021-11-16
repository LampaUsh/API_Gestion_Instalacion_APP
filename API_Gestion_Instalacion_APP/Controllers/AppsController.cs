using API_Gestion_Instalacion_APP.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Gestion_Instalacion_APP.Controllers
{
    [Route("api/1.0/[controller]")]
    [ApiController]
    public class AppsController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public AppsController(ApplicationDBContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Apps>>> Get()
        {
            return await context.Apps.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult>Post (Apps apps)
        {
            context.Add(apps);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
