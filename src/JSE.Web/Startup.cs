using JSE.Web.Data;
using JSE.Web.Extensions.Login;
using JSE.Web.Extensions.Middleware;
using JSE.Web.Extensions.SessaoUsuario;
using JSE.Web.Repositories;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace JSE.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            /*
             * Trabalhando com sessao � necess�rio adicionar: 
             * services.AddHttpContextAccessor();
             *  services.AddMemoryCache(); //guardar dados da sessao em memoria
             *  services.AddSession(options =>{});
             *  services.AddScoped<Sessao>(); - Classe que gerencia sessao 
             *  services.AddScoped<LoginUsuario>(); - Classe que trabalha com login do usuario
             */

            services.AddDbContext<JSEContext>(options => options.UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection")));



            //Sessao Configuracao
            services.AddScoped<IServicoRepository, ServicoRepository>();
            services.AddScoped<IServicoCategoriaRepository, ServicoCategoriaRepository>();
            services.AddScoped<IDepoimentoRepository, DepoimentoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddControllersWithViews();
            
            services.AddMemoryCache(); //guardar dados da sessao em memoria
            services.AddSession();
            services.AddScoped<Sessao>();      
            services.AddScoped<LoginUsuario>();

            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
            services.AddCloudscribePagination();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithRedirects("/Error/{0}");
                //app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            //Session Configura��o
            app.UseSession();
            //Middleware para validar token nos metodos POST
            app.UseMiddleware<ValidateAntiForgeryTokenMiddleware>();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
               
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
               );


            });

        }
    }
}
