namespace AreaLib
{
    public abstract class Shape
    {
        public const double pi = 3.141592;
        public int Properties { get; set; }     // quantity of values to be passed for calculation
        public string Name { get; set; }
        public abstract double CalculateArea(double[] values);
    }
}
