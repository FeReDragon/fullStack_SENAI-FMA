using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using FichaCadastroApi.Model;

namespace FichaCadastroApi.HealthCheck
{
    public class HealthCheckCustom : IHealthCheck
    {
        private readonly FichaCadastroDbContext _fichaCadastroDbContext;
        private readonly IWebHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        public HealthCheckCustom(FichaCadastroDbContext fichaCadastroDbContext, IWebHostEnvironment environment, IConfiguration configuration)
        {
            _fichaCadastroDbContext = fichaCadastroDbContext;
            _environment = environment;
            _configuration = configuration;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            bool comunicaoSQL = false;
            bool healthStatus = false;
            Exception? exMessage = null;

            var objeto = new Dictionary<string, object>()
            {
                { "detalhe_app", new { ambiente = _environment.EnvironmentName } },
                { "ultima_consulta", DateTime.Now }
            };

            try
            {
                int returns = _fichaCadastroDbContext.Database.ExecuteSqlRaw("SELECT 1 AS HealthCheck");
                comunicaoSQL = returns == 1;
                var connectionString = _configuration.GetConnectionString("DefaultConnection"); // Obtenha isto do seu appsettings.json
                var dados = new { sqlSucesso = comunicaoSQL, connectionString = connectionString };
                objeto.Add("informacao_db", dados);
                healthStatus = true;
            }
            catch (Exception ex)
            {
                exMessage = ex;
            }

            if (healthStatus)
            {
                return await Task.FromResult(HealthCheckResult.Healthy("Tudo certo com a aplicação", data: objeto));
            }

            return await Task.FromResult(HealthCheckResult.Unhealthy("Serviço indisponível.", data: objeto, exception: exMessage));
        }
    }
}
