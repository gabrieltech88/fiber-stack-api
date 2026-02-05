using Microsoft.EntityFrameworkCore;

namespace FiberStack.Api.Data.Models;

public class Olt
{
    public int Id { get; set; }
    public string Ip { get; set; }
    public string Name { get; set; }

}