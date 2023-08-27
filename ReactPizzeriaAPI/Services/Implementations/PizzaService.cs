using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ReactPizzeriaAPI.Data;
using ReactPizzeriaAPI.DTOs.Pizza;
using ReactPizzeriaAPI.Model;
using ReactPizzeriaAPI.Services.Interfaces;

namespace ReactPizzeriaAPI.Services.Implementations
{
    public class PizzaService : IPizzaService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _db;

        public PizzaService(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<GetPizzaDTO>> GetPizzaById(int id)
        {
            var serviceResponse = new ServiceResponse<GetPizzaDTO>();
            try
            {
                var pizza = await _db.pizzas.FirstOrDefaultAsync(x => x.Id == id);
                if (pizza != null)
                {
                    serviceResponse.Data = _mapper.Map<GetPizzaDTO>(pizza);
                }
                else
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Pizza not found.";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Pizza not found " + ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetPizzasDTO>>> GetPizzas()
        {
            return new ServiceResponse<List<GetPizzasDTO>>()
            {
                Data = _db.pizzas.Select(x => _mapper.Map<GetPizzasDTO>(x)).ToList()
            };
        }
    }
}
