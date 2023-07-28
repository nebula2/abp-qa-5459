using AutoMapper;
using Qa5459.Entities;

namespace Qa5459;

public class Qa5459ApplicationAutoMapperProfile : Profile
{
    public Qa5459ApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<ChildEntity, ChildEntityDto>();
        CreateMap<ChildEntityCreateDto, ChildEntity>();
        CreateMap<ChildEntityUpdateDto, ChildEntity>();

        CreateMap<ParentEntity, ParentEntityDto>();
        CreateMap<ParentEntityCreateUpdateDto, ParentEntity>();
    }
}
