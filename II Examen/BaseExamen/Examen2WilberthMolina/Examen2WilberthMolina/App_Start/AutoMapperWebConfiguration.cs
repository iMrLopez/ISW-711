using AutoMapper;
using DATOS;

namespace Examen2WilberthMolina.App_Start
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Models.PaqueteModel, DATOS.Paquete>();
                cfg.CreateMap<DATOS.Paquete, Models.PaqueteModel>();
                cfg.CreateMap<Models.TourModel, DATOS.Tour>();
                cfg.CreateMap<DATOS.Tour, Models.TourModel>();
            });
        }
    }
   
}