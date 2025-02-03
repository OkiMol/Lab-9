namespace Lab_9;

public class CarParking
{
    static int count;
    int numSlots;
    int numCars;
    public int NumSlots
    {
        get => numSlots;
        set
        {
            if (value < 0)
                throw new Exception("Количество мест не может быть меньше 0.");
            else
                numSlots = value;

        }
    }   
    public int NumCars
    {
        get => numCars;
        set
        {
            if (value > NumSlots)
                throw new Exception("Количество занятых мест не может быть меньше 0 и превышать количество мест.");
            else
                numCars = value;

        }
    }
    public CarParking()
    {
        numSlots = 1;
        numCars = 1;
        count++;
    }
    public CarParking(int numSlots, int numCars)
    {
        NumSlots = numSlots;
        NumCars = numCars;
    }

    public void Show()
    {
        Console.WriteLine($"numSlots = {numSlots}\nnumCars = {numCars}");
    }
    public double CalculateParkingCongestion()
    {
        return Math.Round((double)NumCars / NumSlots * 100, 2);
    }
    public static double CalculateParkingCongestion(CarParking parking)
    {
        return Math.Round((double)parking.NumCars / parking.NumSlots * 100, 2);
    }
    public static CarParking operator ++ (CarParking parking)
    {
        parking.NumCars++;
        return parking;
    }
    public static CarParking operator -- (CarParking parking)
    {
        parking.NumCars++;
        return parking;
    }
    public static CarParking operator + (CarParking parking1, CarParking parking2) 
    {
        var cp1Slots = parking1.NumSlots;
        var cp2Slots = parking2.NumSlots;
        var cp1Cars = parking1.NumCars;
        var cp2Cars = parking2.NumCars;
        return new CarParking(cp1Slots + cp2Slots, cp1Cars + cp2Cars);
    }
    public static bool operator > (CarParking parking1, CarParking parking2)
    {
        var isBigger = false;
        if (parking1.NumSlots > parking2.NumSlots && parking1.CalculateParkingCongestion() < parking2.CalculateParkingCongestion())
            isBigger = true;
        return isBigger;
    }
    public static bool operator < (CarParking parking1, CarParking parking2)
    {
        var isBigger = false;
        if (parking1.NumSlots < parking2.NumSlots && parking1.CalculateParkingCongestion() > parking2.CalculateParkingCongestion())
            isBigger = true;
        return isBigger;
    }
    public static implicit operator bool(CarParking parking)
    {
        return parking.NumCars == parking.NumSlots ? false : true;
    }
    public static explicit operator int(CarParking parking)
    {
        var count = 0;
        while (parking.CalculateParkingCongestion() < 80)
        {
            parking++;
            count++;
        }
        return count;
    }
}