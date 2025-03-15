using Core.src.Shared.ResultPattern;

namespace Core.src.Shared.Abstractions;

public interface IGenericRepository
{
    Task<Result<T>> GetById<T>(int id) where T : class;

    Task<Result<IEnumerable<T>>> GetAll<T>() where T : class;

    Task<Result> Create<T>(T entity) where T : class;

    Task<Result> Update<T>(T entity) where T : class;

    Task<Result> Delete<T>(int id) where T : class;
}