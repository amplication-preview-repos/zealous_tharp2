using Microsoft.EntityFrameworkCore;

namespace Test.Infrastructure;

public class TestDbContext : DbContext
{
    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options) { }
}
