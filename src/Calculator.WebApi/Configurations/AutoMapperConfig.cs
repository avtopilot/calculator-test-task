using AutoMapper;
using Calculator.Domain.Calculation;
using Calculator.WebApi.Dtos.Calculation;

namespace Calculator.WebApi.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CalculatorHistory, CalculationResultDto>()
                .ForMember(dest => dest.Input, opt => opt.MapFrom(src => src.Input))
                .ForMember(dest => dest.Result, opt => opt.MapFrom(src => src.Result.Value))
                .ForMember(dest => dest.ErrorText, opt => opt.MapFrom(src => src.Result.ErrorText))
                ;
        }
    }
}