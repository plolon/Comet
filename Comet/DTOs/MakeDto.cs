using System.Collections.ObjectModel;

namespace Comet.DTOs
{
    public class MakeDto :KeyValuePairDto
    {
        public ICollection<KeyValuePairDto> Models { get; set; }
        public MakeDto()
        {
            Models = new Collection<KeyValuePairDto>();
        }
    }
}
