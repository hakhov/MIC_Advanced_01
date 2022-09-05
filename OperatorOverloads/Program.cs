using OperatorOverloads;

Point2D point1 = new(10,20);
point1.ShowInfo();

Point2D point2 = new(5, 15);
point2.ShowInfo();

Point2D point3 = point1 + point2;
Point2D point31 = point1 + 20;
Point2D point32 = 20+ point1;

Point3D point3D1 = new();
Point3D point3D = point1 + point3D1;
point3.ShowInfo();