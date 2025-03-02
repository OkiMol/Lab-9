namespace Lab_9
{
    public class CarParkingArray
    {
        static int count;
        static Random random = new Random();

        CarParking[] carParkingArray;

        public int Length => carParkingArray.Length;

        public CarParkingArray()
        {
            carParkingArray = new CarParking[0];
            count++;
        }

        public CarParkingArray(int length)
        {
            if (length < 0)
                throw new Exception("Длина массива не может быть меньше 0.");

            carParkingArray = new CarParking[length];
            var randomSlots = random.Next(1, 101);
            int randomCars;

            for (int i = 0; i < length; i++)
            {
                randomCars = random.Next(0, randomSlots + 1);
                carParkingArray[i] = new CarParking(randomSlots, randomCars);
            }
            count++;
        }
        
        public CarParkingArray(CarParkingArray other)
        {
            carParkingArray = new CarParking[other.Length];
            for (int i = 0; i < other.Length; i++)
            {
                carParkingArray[i] = new CarParking(other[i].NumSlots, other[i].NumCars);
            }
            count++;
        }
        
        public static int GetCount
        {
            get => count;
        }

        public void Show()
        {
            for (int i = 0; i < carParkingArray.Length; i++)
                carParkingArray[i].Show();
        }
        
        public CarParking this[int index]
        {
            get
            {
                if (index >= 0 && index < carParkingArray.Length)
                    return carParkingArray[index];
                throw new Exception("Выход за границы массива");
            }
            set
            {
                if (index >= 0 && index < carParkingArray.Length)
                    carParkingArray[index] = value;
                else
                    throw new Exception("Выход за границы массива");
            }
        }
        
        public IEnumerator<CarParking> GetEnumerator()
        {
            return ((IEnumerable<CarParking>)carParkingArray).GetEnumerator();
        }
    }
}
