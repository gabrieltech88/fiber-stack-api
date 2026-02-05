using FiberStack.Api.Data;
using FiberStack.Api.Data.Models;
using FiberStack.Api.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FiberStack.Api.Repository;

public class OltRepository : IRepository<Olt>
{
    private readonly FiberStackDbContext _context;

    public OltRepository(FiberStackDbContext context)
    {
        _context = context;
    }

    public async Task<Olt> CreateRegisterAsync(Olt olt)
    {
        var resultRegister = await _context.Olts.AddAsync(olt);


        if (resultRegister.State != Microsoft.EntityFrameworkCore.EntityState.Added )
        {
            throw new InvalidOperationException("Fluxo de casdastro está com erro");
        }

        await _context.SaveChangesAsync();

        return resultRegister.Entity;

    }
}