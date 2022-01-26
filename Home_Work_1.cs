using cs = System.Console;
using cv = System.Convert;


namespace Home_Work_1
{
    class Home_Work_1
    {
        public static void Main()
        {
            cs.WriteLine("Enter the temperature in degrees Celsius :");
            double temp = cv.ToDouble(cs.ReadLine());
            double res = Implementation.Convert_Temperature(temp);
            cs.WriteLine("Temperature in degrees Fahrenheit - " + res);


            cs.WriteLine("Enter the amount in rubles BYN :");
            double BYN = cv.ToDouble(cs.ReadLine());
            double EUR = Implementation.Currency_Convert(BYN);
            cs.WriteLine("Amount in Euro EUR - " + EUR);


            cs.WriteLine("Enter the number :");
            int num = cv.ToInt32(cs.ReadLine());
            int reverse = Implementation.Reverse_Number(num);
            cs.WriteLine("Number after reverse - " + reverse);


            cs.WriteLine("Enter the number of hours :");
            double numb = cv.ToInt32(cs.ReadLine());
            double result = Implementation.Hours_to_Second(numb);
            cs.WriteLine("Number of seconds - " + result);


            cs.WriteLine("Enter there numbers");

            double a = cv.ToDouble(cs.ReadLine());
            double b = cv.ToDouble(cs.ReadLine());
            double c = cv.ToDouble(cs.ReadLine());
            double d = cv.ToDouble(cs.ReadLine());
            result = Implementation.Average(a, b, c, d);
            cs.WriteLine("Average - " + result);


            cs.ReadKey();
        }
    }
}
