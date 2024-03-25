namespace ServiceStation.Web.Models
{
    public class VehicleService
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Coast { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
