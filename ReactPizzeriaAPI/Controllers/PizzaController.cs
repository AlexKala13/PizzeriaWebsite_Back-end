using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactPizzeriaAPI.DTOs.Pizza;
using ReactPizzeriaAPI.Model;
using ReactPizzeriaAPI.Services.Interfaces;

namespace ReactPizzeriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetPizzasDTO>>>> GetAll()
        {
            return await _pizzaService.GetPizzas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetPizzaDTO>>> GetSingle(int id)
        {
            return await _pizzaService.GetPizzaById(id);
        }
    }
}
