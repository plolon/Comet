using System.Collections.ObjectModel;

namespace Comet.DTOs.Vehicle
{
    public class VehicleDto
    {
        public int Id { get; set; }
        public virtual KeyValuePairDto Model { get; set; }
        public virtual KeyValuePairDto Make { get; set; }
        public bool IsRegistered { get; set; }
        public VehicleContactDto Contact { get; set; }
        public DateTime LastUpdate { get; set; }
        public virtual ICollection<KeyValuePairDto> Features { get; set; }
        public VehicleDto()
        {
            Features = new Collection<KeyValuePairDto>();
        }
    }
}
