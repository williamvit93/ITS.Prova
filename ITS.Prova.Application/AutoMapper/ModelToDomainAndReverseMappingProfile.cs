using AutoMapper;
using ITS.Prova.Application.ViewModels;
using ITS.Prova.Domain.Funcionario;

namespace ITS.Prova.Application.AutoMapper
{
    public class ModelToDomainAndReverseMappingProfile : Profile
    {
        public ModelToDomainAndReverseMappingProfile()
        {
            CreateMap<Funcionario, FuncionarioViewModel>().ReverseMap();
            CreateMap<FuncionarioFerias, FuncionarioFeriasViewModel>().ReverseMap();
        }
    }
}
