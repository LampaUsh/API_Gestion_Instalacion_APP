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

        [HttpGet("{Id}")]

        public async Task<ActionResult<Apps>> Get(int id)
        {
            var app = await context.Apps.FirstOrDefaultAsync(x => x.Id == id);
            if (app == null)
            {
                return NotFound($"No existe una Apps con la id {app.Id}");
            }

            return app;
        }

        [HttpPost]

        public async Task<ActionResult> Post(Apps apps)
        {
            var yaexiste = await context.Apps.AnyAsync(x => x.Nombre == apps.Nombre);

            if (yaexiste)
            {
                return BadRequest($"Ya existe una aplicacion con el nombre {apps.Nombre}");
            }

            context.Add(apps);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> Put(Apps apps, int id)
        {
            if(apps.Id != id)
            {
                return BadRequest("El id de la APP no coincide con el id de la URL");
            }

            var yaexiste = await context.Apps.AnyAsync(x => x.Id == id);

            if (!yaexiste)
            {
                return NotFound($"No existe el APP con el id {apps.Id}");
            }

            //context.Entry(apps).State = EntityState.Modified;
            context.Update(apps);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete ("{id=int}")]

        public async Task<ActionResult> Delete (int id)
        {
            var yaexiste = await context.Apps.AnyAsync(x => x.Id == id);

            if (!yaexiste)
            {
                return BadRequest();
            }

            context.Remove(new Apps() { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}



