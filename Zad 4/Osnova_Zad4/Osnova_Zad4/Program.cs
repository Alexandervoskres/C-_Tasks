using Osnova_Zad4;

Point p1 = new Point(1,1);
p1.Show();
Point p2 = new Point(124, 200);
p2.Show();
Segment r = new Segment(p1, p2);
r.Show();
double d = r.Length();
Console.WriteLine("Длина отрезка: {0}", d);