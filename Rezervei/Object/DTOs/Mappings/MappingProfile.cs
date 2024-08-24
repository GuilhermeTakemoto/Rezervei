

using AutoMapper;
using Rezervei.Object.DTOs.Entities;
using Rezervei.Object.Models;
using System.Security.Cryptography.X509Certificates;

namespace Rezervei.Object.DTOs.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() { 
        
        CreateMap<UserDTO, UserModel>().ReverseMap();

        }
    }
}
