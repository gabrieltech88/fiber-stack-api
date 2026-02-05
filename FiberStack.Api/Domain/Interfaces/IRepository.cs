using FiberStack.Api.Domain.Entities;

namespace FiberStack.Api.Domain.Interfaces;
public interface IRepository<T>
{
    public Task<T> CreateRegisterAsync(T dto);
}