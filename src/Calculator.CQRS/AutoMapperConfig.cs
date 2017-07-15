using AutoMapper;
using Calculator.DataAccess.Entities.Calculation;
using Calculator.Domain.Calculation;
using Calculator.Domain.CommonType;

namespace Calculator.CQRS
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CalculationHistoryEntity, CalculatorHistory>()
                .ForMember(dest => dest.Result,
                    opt => opt.MapFrom(src =>
                        new Result<int>(src.Result, string.IsNullOrEmpty(src.ErrorMessage), src.ErrorMessage)))
                ;
        }
    }
}