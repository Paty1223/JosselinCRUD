using Domain.primitives;

namespace Domain.Customers;

public sealed class Customers : AggregateRoot
{
    public CustomersId Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string LastName {i get; private set;} = string.Empty;

    public string FullName => $"{Name} {LastName}";
    public string Email { get; private set;} = string.Empty;
    public PhoneNumber PhoneNumber  { get; private set;}

}