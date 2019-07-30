using AutoMapper;
using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
   public class BaseService
    {
        protected static MapperConfiguration autoMapperConfig;
        static BaseService()
        {
            autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Suggest, DTOSuggest>();
            });
#if DEBUG   
            autoMapperConfig.AssertConfigurationIsValid();
#endif
        }
        protected IMapper mapper
        {
            get
            {
                return autoMapperConfig.CreateMapper();
            }
        }
    }
}
