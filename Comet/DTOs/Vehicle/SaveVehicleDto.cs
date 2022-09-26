using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Comet.DTOs.Vehicle
{
    public class SaveVehicleDto
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public bool IsRegistered { get; set; }
        [Required]
        public VehicleContactDto Contact { get; set; }
        public virtual ICollection<int> Features { get; set; }
        public SaveVehicleDto()
        {
            Features = new Collection<int>();
        }
    }
}
