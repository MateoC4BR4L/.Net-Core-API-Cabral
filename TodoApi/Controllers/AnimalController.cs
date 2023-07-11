using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalController : ControllerBase
{
    private static List<Animal> animales_list = new List<Animal>();
    private int id { get; set; } = 0;

    [HttpGet]
    [Route("listar")]
    public dynamic listar()
    {
        if(animales_list.Count >= 1)
            return animales_list;
        
        Response.StatusCode = 404;
        return new
        {
            success = false, 
            message = "No hay elementos.",
        };
    }
    
    [HttpGet]
    [Route("listarID")]
    public dynamic listarID(string id)
    {
        foreach (Animal i in animales_list)
        {
            if (id == i.id)
                return i;
        }

        Response.StatusCode = 404;
        return new
        {
            success = false, 
            message = "Dicho ID no se encuentra en nuestra base de datos.",
        };
    }
    
    [HttpPost]
    [Route("guardar")]
    public dynamic guardar(Animal animal)
    {
        animales_list.Add(animal);

        return new
        {
            success = true,
            message = "El animal ha sido ingresado satisfactoriamente a la base de datos.", 
            result = animal
        };
    }
    
    [HttpPut]
    [Route("actualizar")]
    public dynamic actualizar(string id)
    {
        
    }
    
}