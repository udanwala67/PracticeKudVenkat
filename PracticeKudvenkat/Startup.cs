using Microsoft.EntityFrameworkCore;
using PracticeKudvenkat.Models;

public class Startup
{
    private IConfiguration _config;

    public Startup(IConfiguration config)
    {
        _config = config;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContextPool<AppDbContext>(
            options => options.UseSqlServer(_config.GetConnectionString("EmployeeDBConnection")));

        services.AddMvc().AddXmlSerializerFormatters();
        services.AddTransient<IEmployeeRepository, MockEmployeeRepository>();
    }

    // Rest of the code
}