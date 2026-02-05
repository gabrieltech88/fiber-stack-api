using FiberStack.Api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using FiberStack.Api.Infrastructure.Repository;
using FiberStack.Api.Domain.Interfaces;

namespace FiberStack.Api.Controllers;

[ApiController]
[Route("api/secret/access")]
public class AcessoController : ControllerBase
{
    public IRepository<Acesso> _acessoRepository { get; set; }
    public AcessoController(IRepository<Acesso> acessoRepository)
    {
        _acessoRepository = acessoRepository;
    }

    [HttpPost("create")]
    public async Task<IActionResult> RegisterAcesso(Acesso acesso)
    {
        try
        {
            var responseRegisterAcesso = await _acessoRepository.CreateRegisterAsync(acesso);

            if (responseRegisterAcesso == null)
            {
                throw new Exception("Algo deu errado ao registrar a Acesso");
            }

            return Ok("Acesso de OLT cadastrado");
        }
        catch (Exception ex)
        {
            throw new Exception("Algo deu errado ao registrar a Acesso", ex);
        }
    }
}