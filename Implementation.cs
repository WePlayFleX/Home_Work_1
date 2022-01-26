namespace Home_Work_1
{
    class Implementation
    {
        public static double Convert_Temperature(double temp)
        {
            return ((temp * 1.8) + 32);
        }


        public static double Currency_Convert(double summ)
        {
            return (summ * 0.3377);
        }


        public static int Reverse_Number(int num)
        {
            bool mF = false;
            if ((mF = num < 0))
            {
                num = -num;
            }

            int tmp = 0;
            while (num != 0)
            {
                tmp = 10 * tmp + num % 10;
                num /= 10;
            }
            return (mF ? -tmp : tmp);
        }


        public static double Hours_to_Second(double num)
        {
            return (num * 3600);
        }


        public static double Average(double a, double b, double c, double d)
        {
            return ((a + b + c + d) / 4);
        }



    }

    
}
