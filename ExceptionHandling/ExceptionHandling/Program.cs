using System;
using System.Collections.Generic;

    class Program
    {
    static void Main()
    {
        try
        {
            List<int> Number = new List<int>();
            List<int> Number2 = new List<int>();
            Number.Add(2);
            Number.Add(5);
            Number.Add(34);
            Number.Add(42);
            Number.Add(58);
            Number.Add(10);
            Console.WriteLine("Please type a whole number:");
            int x = Convert.ToInt32(Console.ReadLine());

            foreach (int Num in Number)

                if (!Number2.Contains(x))
                {
                    int Result = Num / x;
                    Console.WriteLine("Your number divided by every number in the array is:" + Result);

                }
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please dont divide by zero.");
        }

        catch (FormatException ex)
        {
            Console.WriteLine("Please use the right format");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("The Program has emerged from the try catch block");
        Console.ReadLine();
        }      
    

        //{
        //try
        //{
        //    Console.WriteLine("Pick a number:");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick another number:");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two...");
           
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals" + numberThree);
        //    Console.ReadLine();
        //}
        //    catch (FormatException ex)
        //{
        //    Console.WriteLine("Please type a whole number");
        //    return;
        //}
        //    catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Please dont divide by zero");
        //}
        //    catch ( Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //    finally
        //{
        //    Console.ReadLine()
        //}
        //}
    }
