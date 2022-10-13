using InjecaoDependencia_CSharp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


//DiComHost();
DIAvulso();

void DiComHost()
{
    IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args);

    //Configurando Injeção de dependencia
    hostBuilder
        .ConfigureServices(services => services
            .AddScoped<IServico1, Servico1>()
            .AddScoped<IServico2, Servico2>()
        );


    IHost host = hostBuilder.Build();
    IServico2 servico2 = host.Services.GetRequiredService<IServico2>();
    servico2.Log();
    host.Run();
}


void DIAvulso()
{

    //Configurando Injeção de dependencia
    ServiceProvider serviceProvider = new ServiceCollection()
        .AddScoped<IServico1, Servico1>()
        .AddScoped<IServico2, Servico2>()
        .BuildServiceProvider();

    IServico2 servico2 = serviceProvider.GetService<IServico2>();
    servico2.Log();
}


