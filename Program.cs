internal class Program
{
    private static void Main(string[] args)
    {
       Dog Dogwhite;
    }
}
interface Coloring
{

}

interface ResizeRing
{

}

class ColorAnimal
{

}

class Animal:ColorAnimal
{
    int mat=2;
    int mieng=1;
    int chan=4;
}
class Cat:Animal
{
    int khoiluong = 4;
}
class Dog:Animal
{
    int khoiluong = 10;
}
class Dogwhite: Dog,Coloring,ResizeRing
{
    string maulong = "vang";
}