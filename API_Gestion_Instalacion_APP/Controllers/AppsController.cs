using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Gestion_Instalacion_APP.Modelos;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<List<App>>> Get()
        {
            return await context.App.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<App>> Post(App app)
        {
            {
                context.Add(app);
                await context.SaveChangesAsync();
                return Ok();
            };
        }
    }
}
