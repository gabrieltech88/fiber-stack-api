using FiberStack.Api.Data.Models;

namespace FiberStack.Api.Interfaces;
public interface IRepository<T>
{
    public Task<T> CreateRegisterAsync(T dto);
}