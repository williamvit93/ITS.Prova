using AutoMapper;

namespace ITS.Prova.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ModelToDomainAndReverseMappingProfile>();
            });
        }

    }
}
