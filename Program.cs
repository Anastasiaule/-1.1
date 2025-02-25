namespace лаба_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка расписания поезда");
            Console.WriteLine("Введите время прибытия поезда (часы и минуты):");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите время отправления поезда (часы и минуты):");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите время прихода пассажира (часы и минуты):");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            var messege = new TrainScheduleChecker();
            var message = messege.IsTrainAtPlatform(a, b, c, d, n, m);
            Console.WriteLine(message);
        }
    }

    public class TrainScheduleChecker
    {
        public string IsTrainAtPlatform(int a, int b,
                                      int c, int d,
                                      int n, int m)
        {
            int trainArrival = a * 60 + b;
            int trainDeparture = c * 60 + d;
            int passengerTime = n * 60 + m;
            string messege = "";

           
            if (trainDeparture < trainArrival)
            {
                if (passengerTime >= trainArrival || passengerTime <= trainDeparture)
                {
                    messege = "Да, поезд будет стоять на платформе";
                }
                else
                {
                    messege = "Нет, поезда не будет на платформе";
                }
            }
            else
            {
                if (passengerTime >= trainArrival && passengerTime <= trainDeparture)
                {
                    messege = "Да, поезд будет стоять на платформе";
                }
                else
                {
                    messege = "Нет, поезда не будет на платформе";
                }
            }

            return messege;
        }
    }
}




