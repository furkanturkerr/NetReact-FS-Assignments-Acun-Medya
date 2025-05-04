using AutoMapper;
using Business.DTOs.Bootcamp;
using DTOs.Application;
using DTOs.Blacklist;
using DTOs.Bootcamp;
using Entities;

namespace Mappings;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Application, ApplicationResponse>();
        CreateMap<ApplicationRequest, Application>();

        CreateMap<Blacklist, BlacklistResponse>();
        CreateMap<BlacklistRequest, Blacklist>();

        CreateMap<Bootcamp, BootcampResponse>();
        CreateMap<BootcampRequest, Bootcamp>();

    }
}
