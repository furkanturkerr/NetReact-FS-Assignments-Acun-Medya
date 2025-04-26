using Core.Entities;
using Entities.Enums;

namespace Entities
{
    public class Car : BaseEntitiy<Guid>
    {
        public Guid Modelid { get; set; }
        public int ModelYear { get; set; }
        public string Plate {  get; set; }
        public CarState State { get; set; }
        public double DailyPrice { get; set; }

        public virtual Model Model { get; set; }
        public Car() { }

        public Car(Guid modelid, int modelYear, string plate,CarState state, double dailyPrice)
        {
            Modelid = modelid;
            ModelYear = modelYear;
            Plate = plate;
            DailyPrice = dailyPrice;
        }
    }
}
