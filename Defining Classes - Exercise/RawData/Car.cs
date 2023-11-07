
namespace RowData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public Car(
           string model,
           int speed,
           int power,
           int weight,
           string type,
           double tire1pressure,
           int tire1age,
           double tire2pressure,
           int tire2age,
           double tire3pressure,
           int tire3age,
           double tire4pressure,
           int tire4age)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight,type);
            Tires = new Tire[4];
            Tires[0] = new Tire(tire1age, tire1pressure);
            Tires[1] = new Tire(tire2age, tire2pressure);
            Tires[2] = new Tire(tire3age, tire3pressure);
            Tires[3] = new Tire(tire4age, tire4pressure);
        }
        public string Model { get { return model; } set { model = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public Cargo Cargo { get { return cargo; } set { cargo = value; } }
        public Tire[] Tires { get { return tires; } set { tires = value; } }
        
    }
}
