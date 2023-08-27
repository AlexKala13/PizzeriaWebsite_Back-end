using ReactPizzeriaAPI.DTOs.Pizza;
using ReactPizzeriaAPI.Model;

namespace ReactPizzeriaAPI.Services.Interfaces
{
    public interface IPizzaService
    {
        Task<ServiceResponse<List<GetPizzasDTO>>> GetPizzas();
        Task<ServiceResponse<GetPizzaDTO>> GetPizzaById(int id);
    }
}
