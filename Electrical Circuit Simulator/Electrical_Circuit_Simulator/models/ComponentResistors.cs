namespace Electrical_Circuit_Simulator
{
    public class ComponentResistors
    {
        public ComponentResistors(double res, string name, int Junction)
        {
            Res = res;
            Name = name;
            Junction = junction;
        }
        public double Res { get; set; }
        public string Name { get; set; }
        public int junction { get; set; }

    }
}
