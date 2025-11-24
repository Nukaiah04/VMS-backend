
namespace VMS.Models
{
    public class CarsEntity
    {
        public int CarId { get; set; }
        public required string CarName { get; set; }
        public required string CarImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
