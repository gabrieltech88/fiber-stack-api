using FiberStack.Api.Infrastructure.Context;
using FiberStack.Api.Domain.Entities;
using FiberStack.Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FiberStack.Api.Infrastructure.Repository;

public class AcessoRepository : IRepository<Acesso>
{
    private readonly FiberStackDbContext _context;

    public AcessoRepository(FiberStackDbContext context)
    {
        _context = context;
    }

    public async Task<Acesso> CreateRegisterAsync(Acesso acessoInfos)
    {
        var resultRegister = await _context.Acesso.AddAsync(acessoInfos);


        if (resultRegister.State != Microsoft.EntityFrameworkCore.EntityState.Added )
        {
            throw new InvalidOperationException("Fluxo de casdastro está com erro");
        }

        await _context.SaveChangesAsync();

        return resultRegister.Entity;

    }
}