using System.ComponentModel.DataAnnotations;

namespace IIT.DAL.Entities.Warehouses
{
    public class WarehouseType
    {
        [Key]
        public int WarehouseTypeId { get; set; }
        public string TypeName { get; set; }
        public ICollection<WarehouseDetails> WarehouseDetails { get; set; }
    }             
}
