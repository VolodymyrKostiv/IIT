using AutoMapper;
using IIT.BLL.DTOs.Warehouses;
using IIT.Shared.ViewModels.Warehouses;

namespace IIT.Server.Mapping.Warehouses
{
    public class Warehouse : Profile
    {
        public Warehouse()
        {
            CreateMap<WarehouseDTO, WarehouseViewModel>().ReverseMap();
            CreateMap<WarehouseDetailsDTO, WarehouseDetailsViewModel>().ReverseMap();
            CreateMap<WarehouseTypeDTO, WarehouseTypeViewModel>().ReverseMap();
        }
    }
}
