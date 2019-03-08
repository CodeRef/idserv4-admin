using IdentityModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace WebClient2
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            //var guestPolicy = new AuthorizationPolicyBuilder()
            //    .RequireAuthenticatedUser()
            //    .RequireClaim("scope", "role")
            //    .Build();

            //services.AddMvc(options =>
            //{
            //    //options.Filters.Add(new AuthorizeFilter(guestPolicy));
            //}).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc();
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "Cookies";
                options.DefaultChallengeScheme = "oidc";
            })
                .AddCookie("Cookies")
                .AddOpenIdConnect("oidc", options =>
                {
                    options.SignInScheme = "Cookies";
                    options.Authority = "http://idserve.excel.com:5010";
                    options.RequireHttpsMetadata = false;

                    options.ClientId = "mvc-client2";
                    options.ClientSecret = "wut123";
                    options.ResponseType = "code id_token";

                    options.SaveTokens = true;
                    options.ClaimActions.MapAllExcept("iss", "nbf", "exp", "aud", "nonce", "iat", "c_hash");
                    options.GetClaimsFromUserInfoEndpoint = true;

                    options.Scope.Add("api3");
                    options.Scope.Add("offline_access");
                    options.ClaimActions.MapJsonKey("website", "website");
                });

            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("Policy1", policy1 =>
            //    {
            //        policy1.RequireAuthenticatedUser();
            //        policy1.RequireClaim("role", "Standard");
            //        //policy1.RequireClaim("role", "role2");
            //        //policy1.RequireClaim("role", "role3");
            //        policy1.Build();
            //    });
            //});
            services.AddAuthorization(options => options.AddPolicy("Founder", policy => policy.RequireClaim("name", "StandardUser")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
