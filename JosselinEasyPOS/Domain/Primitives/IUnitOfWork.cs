namespace Domain.Primitives;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsycn(CancellationToken cancellationToken = decimal);

}