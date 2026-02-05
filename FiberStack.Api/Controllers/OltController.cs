using FiberStack.Api.Data.Models;
using Microsoft.AspNetCore.Mvc;
using FiberStack.Api.Repository;
using FiberStack.Api.Interfaces;

namespace FiberStack.Api.Controllers;

[ApiController]
[Route("api/olt")]
public class OltController : ControllerBase
{
    public IRepository<Olt> _oltRepository { get; set; }
    public OltController(IRepository<Olt> oltRepository)
    {
        _oltRepository = oltRepository;
    }

    [HttpPost("create")]
    public async Task<IActionResult> RegisterOlt(Olt olt)
    {
        try
        {
            var responseRegisterOlt = await _oltRepository.CreateRegisterAsync(olt);

            if (responseRegisterOlt == null)
            {
                throw new Exception("Algo deu errado ao registrar a Olt");
            }

            return Ok(new
            {
                Olt = responseRegisterOlt,
                Message = "Olt registrada com sucesso!"
            });
        }
        catch (Exception ex)
        {
            throw new Exception("Algo deu errado ao registrar a Olt", ex);
        }
    }
}