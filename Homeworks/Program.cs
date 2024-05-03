using Homeworks;

try
{
    Mercedes car1 = new Mercedes("A200", "sedan");
    Mercedes car2 = new Mercedes("E400", "universal");

    Console.WriteLine(car1.length);
    Console.WriteLine(car2.width);
    Console.WriteLine(car1.isFast("C300"));
    Console.WriteLine(car1.isCompact("B200"));
    Console.WriteLine(car1.isComfy("S550"));
}
catch (Exception e) {  Console.WriteLine("tenc avto chka"); }