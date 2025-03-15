using Core.src.Shared.ResultPattern;

namespace Core.src.Shared.Abstractions;

public interface IRepositoryBase<T> where T : class
{
    Task<Result<T>> GetById(int id);

    Task<Result<IEnumerable<T>>> GetAll();

    Task<Result> Create(T entity);

    Task<Result> Update(T entity);

    Task<Result> Delete(int id);
}