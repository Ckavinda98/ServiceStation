using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ServiceStation.Web.Models
{
    public class Vehicle
    {
       public int Id { get; set; }  
       public string Make { get; set; }
       public string Model { get; set; } 
       public int Year { get; set; }
       public string  Color { get; set; }
       public bool IsDeleted { get; set; }
       
    }
}
