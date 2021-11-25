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
    public class OperariosController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public OperariosController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Operarios>>> Get()
        {
            return await context.Operarios.ToListAsync();
        }

        [HttpGet("{Id}")]

        public async Task<ActionResult<Operarios>> Get(int id)
        {
            var app = await context.Operarios.FirstOrDefaultAsync(x => x.Id == id);
            if (app == null)
            {
                return NotFound($"No existe una Operarios con la id {app.Id}");
            }

            return app;
        }

        [HttpPost]

        public async Task<ActionResult> Post(Operarios Operarios)
        {
            var yaexiste = await context.Operarios.AnyAsync(x => x.Nombre == Operarios.Nombre);

            if (yaexiste)
            {
                return BadRequest($"Ya existe una aplicacion con el nombre {Operarios.Nombre}");
            }

            context.Add(Operarios);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> Put(Operarios Operarios, int id)
        {
            if (Operarios.Id != id)
            {
                return BadRequest("El id de la APP no coincide con el id de la URL");
            }

            var yaexiste = await context.Operarios.AnyAsync(x => x.Id == id);

            if (!yaexiste)
            {
                return NotFound($"No existe el APP con el id {Operarios.Id}");
            }

            //context.Entry(Operarios).State = EntityState.Modified;
            context.Update(Operarios);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id=int}")]

        public async Task<ActionResult> Delete(int id)
        {
            var yaexiste = await context.Operarios.AnyAsync(x => x.Id == id);

            if (!yaexiste)
            {
                return BadRequest();
            }

            context.Remove(new Operarios() { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
