using EShop.Domain.Enums;

namespace EShop.Domain.Entities
{
     public class User
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string Phone { get; private set; } = string.Empty;
        public decimal Balance { get; private set; }
        public UserRole Role { get; private set; }


        private User() { }

        public User(Guid id, string firstName, string lastName, string phone, UserRole userRole)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Balance = 0;
            Role = userRole;
        }
    }
}
