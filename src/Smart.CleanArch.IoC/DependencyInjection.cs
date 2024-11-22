using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Smart.CleanArch.Application.DataTransfer.Produto.Profiles;
using Smart.CleanArch.Application.Services.Interfaces.Produtos;
using Smart.CleanArch.Application.Services.ProdutoService;
using Smart.CleanArch.Domain.Interfaces.Base;
using Smart.CleanArch.Domain.Interfaces.Produto;
using Smart.CleanArch.Infra.Data;
using Smart.CleanArch.Infra.Mappings.Produto.Validator;
using Smart.CleanArch.Infra.Repositories.Base;
using Smart.CleanArch.Infra.Repositories.Produto;


namespace Smart.CleanArch.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("Smart.CleanArch.API")));

        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        services.AddAutoMapper(typeof(ProdutosProfile));

        ConfiguraRepositories(services);
        ConfiguraServices(services);

        ConfiguraFLuentValidation(services);

        return services;
    }

    private static void ConfiguraServices(IServiceCollection services)
    {
        services.AddScoped<IProdutosServices, ProdutosService>();
    }

    private static void ConfiguraRepositories(IServiceCollection services)
    {
        services.AddScoped<IProdutosRepository, ProdutosRepository>();
    }

    private static void ConfiguraFLuentValidation(IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation();
        services.AddValidatorsFromAssemblyContaining<ProdutosValidator>();
    }
}
