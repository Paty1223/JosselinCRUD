namespace Domain.Customer;

public interface ICustomerRepository
{
    Task<Customer?> GetBydAsync(CustomerId id);
    Task Add (Customer);
}
