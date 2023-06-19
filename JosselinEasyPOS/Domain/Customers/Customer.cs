using Domain.primitives;

namespace Domain.Customers;

public sealed class Customers : AggregateRoot

{
public Customer(CustomersId id, string name, string LastName, string email, PhoneNumber phoneNumber, Address address, bool Active)
    {
    Id = id;
    Name = name;
    LastName = lastName;
    Email = email;
    PhoneNumber = phoneNumber;
    Address = address;
    Active = active;

    }
    private Customers()
    {
        
    }


    public CustomersId Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string LastName {i get; private set;} = string.Empty;

    public string FullName => $"{Name} {LastName}";
    public string Email { get; private set;} = string.Empty;
    public PhoneNumber PhoneNumber  { get; private set;}
    public Address Address {get; private set;} 
    public bool Active { get; set; }

}