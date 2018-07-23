using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using ITS.Prova.API;
using ITS.Prova.Infra;
using Newtonsoft.Json.Serialization;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.WebApi;
using WebActivatorEx;

[assembly: PostApplicationStartMethod(typeof(SimpleInjectorInitializer), "Initialize")]
namespace ITS.Prova.API
{
    public class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            var httpConfig = new HttpConfiguration();

            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            ConfigureDependencyInjection(container);
            ConfigureWebApi(httpConfig);

            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

        }

        private static void ConfigureDependencyInjection(Container container)
        {
            BootStrapperCadastros.Register(container);
        }

        private static void ConfigureWebApi(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}