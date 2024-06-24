using Task2;

ShapeFactory shapeFactory = new ShapeFactory();

IShape shape1 = shapeFactory.Shape("CIRCLE");

shape1.Draw();

IShape shape2 = shapeFactory.Shape("RECTANGLE");

shape2.Draw();

IShape shape3 = shapeFactory.Shape("SQUARE");

shape3.Draw();

IShape shape4 = shapeFactory.Shape("RHOMBUS");

shape4.Draw();