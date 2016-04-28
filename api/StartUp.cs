using Microsoft.AspNet.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;

namespace Api
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc().AddJsonOptions(options => {
        options.SerializerSettings
        .ContractResolver = new CamelCasePropertyNamesContractResolver();
      });
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseMvc();
    }
  }
}
