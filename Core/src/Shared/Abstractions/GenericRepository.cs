using Core.src.Infrastructure;
using Core.src.Shared.ResultPattern;
using Microsoft.EntityFrameworkCore;

namespace Core.src.Shared.Abstractions;

public class GenericRepository(AppDbContext context) : IGenericRepository
{
    public async Task<Result<T>> GetById<T>(int id) where T : class
    {
        try
        {
            var entity = await context.Set<T>()
                .FindAsync(id);

            if (entity != null)
            {
                return entity;
            }

            return new Error($"{typeof(T)} with id {id}, does not exist.");
        }
        catch (Exception ex)
        {
            return new Error(ex.Message, ex);
        }
    }

    public async Task<Result<IEnumerable<T>>> GetAll<T>() where T : class
    {
        try
        {
            return await context.Set<T>()
                .AsNoTracking()
                .ToListAsync();
        }
        catch (Exception ex)
        {
            return new Error(ex.Message, ex);
        }
    }

    public async Task<Result> Create<T>(T entity) where T : class
    {
        try
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return Result.Ok();
        }
        catch (Exception ex)
        {
            return new Error(ex.Message, ex);
        }
    }

    public async Task<Result> Update<T>(T entity) where T : class
    {
        try
        {
            context.Update(entity);
            await context.SaveChangesAsync();
            return Result.Ok();
        }
        catch (Exception ex)
        {
            return new Error(ex.Message, ex);
        }
    }

    public async Task<Result> Delete<T>(int id) where T : class
    {
        try
        {
            var result = await GetById<T>(id);

            if (result.IsError)
            {
                return result.Error;
            }

            var entity = result.Data;
            context.Remove(entity);
            await context.SaveChangesAsync();
            return Result.Ok();
        }
        catch (Exception ex)
        {
            return new Error(ex.Message, ex);
        }
    }
}