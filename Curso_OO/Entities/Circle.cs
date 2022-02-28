using Curso_OO.Entities.Enums;

namespace Curso_OO.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle (double radius, Color color) : base (color)
        {

        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
