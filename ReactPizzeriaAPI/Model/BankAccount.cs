using System.Data.SqlTypes;

namespace ReactPizzeriaAPI.Model
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public User CardHolderId { get; set; }
    }
}
