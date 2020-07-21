using Core.Entidades;
using Core.Steps;
using Core.Strategies;
using Core.Validadores;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
            => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddScoped<IValidator<Workflow>, WorkflowValidador>();

            // Adicionar DI
            services.AddScoped<IStepStrategy, StepStrategy>();

            services.AddScoped<IDadosBasicosStep, DadosBasicosStep>();
            services.AddScoped<IFinanceiroStep, FinanceiroStep>();
            services.AddScoped<IContatoStep, ContatoStep>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
