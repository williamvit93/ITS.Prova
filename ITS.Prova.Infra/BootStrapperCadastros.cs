using ITS.Prova.Application;
using ITS.Prova.Application.Interfaces;
using ITS.Prova.Domain.Interfaces;
using ITSProva.Data.Context;
using ITSProva.Data.Interfaces;
using ITSProva.Data.Repository;
using ITSProva.Data.Services;
using SimpleInjector;

namespace ITS.Prova.Infra
{
    public class BootStrapperCadastros
    {
        public static Container MyContainer { get; set; }

        public static void Register(Container container)
        {
            MyContainer = container;

            //AppServices
            container.Register<IFuncionarioAppService, FuncionarioAppService>(Lifestyle.Scoped);
            container.Register<IFuncionarioFeriasAppService, FuncionarioFeriasAppService>(Lifestyle.Scoped);

            //Services
            container.Register<IFuncionarioService, FuncionarioService>(Lifestyle.Scoped);
            container.Register<IFuncionarioFeriasService, FuncionarioFeriasService>(Lifestyle.Scoped);

            //Repository
            container.Register<IFuncionarioRepository, FuncionarioRepository>(Lifestyle.Scoped);
            container.Register<IFuncionarioFeriasRepository, FuncionarioFeriasRepository>(Lifestyle.Scoped);

            //Data
            container.Register<ProvaContext>(Lifestyle.Scoped);

        }
    }
}

