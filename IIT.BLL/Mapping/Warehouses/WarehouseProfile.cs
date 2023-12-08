using AutoMapper;
using IIT.BLL.DTOs.Warehouses;
using IIT.DAL.Entities.Warehouses;

namespace IIT.BLL.Mapping.Warehouses
{
    public class WarehouseProfile : Profile
    {
        public WarehouseProfile()
        {
            CreateMap<Warehouse, WarehouseDTO>().ReverseMap();
            CreateMap<WarehouseDetails, WarehouseDetailsDTO>().ReverseMap();
            CreateMap<WarehouseType, WarehouseTypeDTO>().ReverseMap();
        }
    }
}
