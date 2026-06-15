namespace EmployeePayrollSystem.Utitlities;



public static class InputValidator
{
    public static int GetInt(string message)
    {
        while (true)
        {

            try
            {
                Console.WriteLine(message);
                    return Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }

    }



    public static double GetDouble(string message)
{
        while (true)
        {

            try
            {
                Console.WriteLine(message);
                    return Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }

    }
}