using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using NumpadChessBlazorServer.Data;

namespace NumpadChessBlazorServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor(opt =>
            {
                opt.DisconnectedCircuitRetentionPeriod = TimeSpan.FromHours(1);
            });
            builder.Services.AddSingleton<WeatherForecastService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }


            app.UseStaticFiles();

            app.UseRouting();

            //app.MapBlazorHub();
            app.MapBlazorHub(opt =>
            {
                opt.WebSockets.CloseTimeout = TimeSpan.FromHours(1);
                opt.LongPolling.PollTimeout = TimeSpan.FromHours(1);
                opt.TransportSendTimeout = TimeSpan.FromHours(1);
            });

            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}