namespace Task2
{
    class ShapeFactory
    {
        public IShape Shape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("CIRCLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Circle();

            }
            else if (shapeType.Equals("RECTANGLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("SQUARE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Square();
            }
            else if (shapeType.Equals("RHOMBUS", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Rhombus();
            }

            return null;
        }
    }
}