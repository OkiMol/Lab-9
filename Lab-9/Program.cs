using System;

namespace Lab_9;

public class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Демонстрация работы класса CarParking");
                
            CarParking cp1 = new CarParking(10, 5);
            CarParking cp2 = new CarParking();
            CarParking cp3 = new CarParking(20, 20);
                
            cp1.Show();
            cp2.Show();
            cp3.Show();
                
            Console.WriteLine($"Загруженность парковки cp1: {cp1.CalculateParkingCongestion()}%");
            Console.WriteLine($"Загруженность парковки cp2: {cp2.CalculateParkingCongestion()}%");
            Console.WriteLine($"Загруженность парковки cp3: {cp3.CalculateParkingCongestion()}%");
                
            Console.WriteLine($"Количество созданных объектов CarParking: {CarParking.GetCount}");
                
            Console.WriteLine("\nТестирование операторов:");
            ++cp1;
            cp1.Show();
            --cp1;
            cp1.Show();
                
            CarParking cp4 = cp1 + cp2;
            Console.WriteLine("Результат сложения cp1 и cp2:");
            cp4.Show();
                
            bool isNotFull = cp1;
            Console.WriteLine($"Парковка cp1 не заполнена: {isNotFull}");

            int countToFill = (int)cp1;
            Console.WriteLine($"Необходимо добавить машин для достижения 80% загруженности: {countToFill}");
                
            Console.WriteLine("\nДемонстрация работы класса CarParkingArray");
                
            CarParkingArray array1 = new CarParkingArray(3);
            CarParkingArray array2 = new CarParkingArray(array1);
            CarParkingArray array3 = new CarParkingArray();
                
            Console.WriteLine("Содержимое array1:");
            array1.Show();

            Console.WriteLine("Содержимое array2 (копия array1):");
            array2.Show();

            Console.WriteLine("Содержимое array3 (пустой массив):");
            array3.Show();
                
            Console.WriteLine("Изменение первого элемента в array1:");
            array1[0] = new CarParking(50, 25);
            array1.Show();
            
                
            Console.WriteLine($"Количество созданных объектов CarParkingArray: {CarParkingArray.GetCount}");
                
            Console.WriteLine("Попытка доступа к несуществующему индексу...");
            array1[10].Show();
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nОшибка: {e.Message}");
        }
        finally
        {
            Console.WriteLine("\nКонец работы программы.");
        }
    }
}