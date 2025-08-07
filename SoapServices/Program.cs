using SoapCore;//installed via NuGet(>1M downloads)
namespace SoapServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<ISoapService, SoapService>();
            builder.Services.AddSoapCore();
            var app = builder.Build();
            app.UseRouting();
            (app as IApplicationBuilder).UseSoapEndpoint<ISoapService>((sco)=> {
                sco.HttpPostEnabled = true;
                sco.Path = "/FirstSoap.svc";
                sco.SoapSerializer = SoapSerializer.XmlSerializer;
                 });
            app.Run();
        }
    }
}
