namespace ReactPizzeriaAPI.DTOs.Pizza
{
    public class GetPizzasDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Filter { get; set; }
        public string Image { get; set; }
    }
}
