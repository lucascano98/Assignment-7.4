public class ParkingSystem
{
    public int Big;
    public int Medium;
    public int Small;

    public ParkingSystem(int big, int med, int small)
    {
        Big = big;
        Medium = med;
        Small = small;
    }

    public bool addCar(int carType)
    {
        switch(carType) {
            case 1:
                if (Big <= 0)
                    return false;
                else
                {
                    Big--;
                    return true;
                }
            case 2:
                if (Medium <= 0)
                    return false;
                else
                {
                    Medium--;
                    return true;
                }
            case 3:
                if (Small <= 0)
                    return false;
                else
                {
                    Small--;
                    return true;
                }
            default:
                return false;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Input: [1, 1, 0] [1, 2, 3, 1]");
        Console.WriteLine("\nOutput:");


        ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
        Console.WriteLine(parkingSystem.addCar(1));
        Console.WriteLine(parkingSystem.addCar(2));
        Console.WriteLine(parkingSystem.addCar(3));
        Console.WriteLine(parkingSystem.addCar(1));
    }
}