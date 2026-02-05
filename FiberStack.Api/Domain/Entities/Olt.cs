using Microsoft.EntityFrameworkCore;

namespace FiberStack.Api.Domain.Entities;

public class Olt
{
    public int Id { get; set; }
    public string Ip { get; set; }
    public string Name { get; set; }

}