using Core.src.Shared.ResultPattern;

namespace Core.src.Shared.Abstractions;

public interface IRepository<T> where T : IIdentity
{
    Task<Result<T>> GetById(int id);

    Task<Result<IEnumerable<T>>> GetAll();

    Task<Result> Create(T entity);

    Task<Result> Update(T entity);

    Task<Result> Delete(int id);
}