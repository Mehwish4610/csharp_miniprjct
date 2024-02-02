using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        { 
			Console.WriteLine(" ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("CCCCC       #     #     MMMMMMM IIIII NN    N IIIII  PPPP   RRRR   OOOOO JJJJJ EEEE CCCC TTTTT");
			Console.WriteLine("C       ## # ### # #    M  M  M   I   N N   N   I   P    P R    R  O   O   J   E    C      T");
			Console.WriteLine("C         #     #       M  M  M   I   N  N  N   I   PPPPP  R R R   O   O   J   EEEE C      T"); 
			Console.WriteLine("C     ## # ### # #      M  M  M   I   N   N N   I   P      R    R  O   O   J   E    C      T");
			Console.WriteLine("CCCCC   #     #         M  M  M IIIII N    NN IIIII P      R     R OOOOO JJJ   EEEE CCCC   T");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("+----------------------------------------+ ");
            Console.WriteLine("+  Select a program to run (1-12):       +");
			Console.WriteLine("+----------------------------------------+ ");
            Console.WriteLine("+ 1.  + Arithmetic Operations            +");
			Console.WriteLine("+-----+----------------------------------+ ");
            Console.WriteLine("+ 2.  + Armstrong Number                 +");
			Console.WriteLine("+-----+----------------------------------+ ");
            Console.WriteLine("+ 3.  + Find Substrings                  +");
			Console.WriteLine("+-----+----------------------------------+ ");
            Console.WriteLine("+ 4.  + Divide by Zero Exception         +");
			Console.WriteLine("+-----+----------------------------------+ ");
            Console.WriteLine("+ 5.  + Pascal's Triangle                +");
			Console.WriteLine("+-----+----------------------------------+ ");
            Console.WriteLine("+ 6.  + Floyd's Triangle                 +");
			Console.WriteLine("+-----+----------------------------------+ ");
            Console.WriteLine("+ 7.  + Read and Copy Text File          +");
			Console.WriteLine("+-----+----------------------------------+ ");
            Console.WriteLine("+ 8.  + Stack Operations                 +");
			Console.WriteLine("+-----+----------------------------------+ ");
            Console.WriteLine("+ 9.  + Complex Numbers                  +");
			Console.WriteLine("+-----+----------------------------------+ ");
            Console.WriteLine("+ 10. + Polymorphic Shape Drawer         +");
			Console.WriteLine("+-----+----------------------------------+ ");
            Console.WriteLine("+ 11. + Area and Perimeter Calculator    +");
			Console.WriteLine("+-----+----------------------------------+ ");
            Console.WriteLine("+ 12. + Resizable Rectangle              +");
			Console.WriteLine("+-----+----------------------------------+ ");
            Console.WriteLine("+ 13. + Exit                             +");
			Console.WriteLine("+-----+----------------------------------+ ");
			Console.WriteLine(" ");
			Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PerformArithmeticOperations();
                    break;
                case 2:
                    CheckArmstrongNumber();
                    break;
                case 3:
                    FindSubstrings();
                    break;
                case 4:
                    DivideByZeroException();
                    break;
                case 5:
                    DrawPascalsTriangle();
                    break;
                case 6:
                    DrawFloydsTriangle();
                    break;
                case 7:
                    ReadAndCopyTextFile();
                    break;
                case 8:
                    PerformStackOperations();
                    break;
                case 9:
                    PerformComplexNumberOperations();
                    break;
                case 10:
                    ImplementPolymorphism();
                    break;
                case 11:
                    CalculateAreaAndPerimeter();
                    break;
                case 12:
                    ResizeRectangle();
                    break;
                case 13:
                    Environment.Exit(0);
                    break;
                default:
					Console.WriteLine(" ");
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 13.");
                    break;
            }
			Console.ResetColor();
			Console.WriteLine(" ");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }

    static void PerformArithmeticOperations()
    {
		Console.WriteLine(" ");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" CCCC  AAAAA  L      CCCC  U   U  L      AAAA TTTTT OOO  RRRR ");
        Console.WriteLine("C      A   A  L     C      U   U  L     A   A   T  O   O R   R");
        Console.WriteLine("C      AAAAA  L     C      U   U  L     AAAAA   T  O   O RRRR ");
        Console.WriteLine("C      A   A  L     C      U   U  L     A   A   T  O   O R   R");
        Console.WriteLine(" CCCC  A   A  LLLLL  CCCC   UUU   LLLLL A   A   T   OOO  R    R");
		Console.WriteLine(" ");
		
		Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
		
		double sum= (num1 + num2);
		double diff =(num1 - num2);
		double prod =(num1 * num2);
		double quot = (num1 / num2);
		double exp =Math.Pow(num1, num2);
		double sq1 =Math.Sqrt(num1);
		double sq2=  Math.Sqrt(num2);
		double cb1=Math.Pow(num1, 1.0 / 3);
		double cb2=Math.Pow(num2, 1.0 / 3);
		
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("+--------------------------------------------------------------------------------------+ ");
        Console.WriteLine("+  Sum of "+num1+" and "+ num2+":  + "+sum.ToString("F2"));
		Console.WriteLine("+--------------------------------------------------------------------------------------+ ");
        Console.WriteLine("+  Difference of "+num1+" and "+ num2+" : " +diff.ToString("F2"));
		Console.WriteLine("+--------------------------------------------------------------------------------------+ ");
        Console.WriteLine("+  Product of "+num1+" and "+ num2+" : " + prod.ToString("F2"));
		Console.WriteLine("+--------------------------------------------------------------------------------------+");
        Console.WriteLine("+  Quotient of "+num1+" divided by "+ num2+" : " +quot.ToString("F2"));
		Console.WriteLine("+--------------------------------------------------------------------------------------+ "); 
        Console.WriteLine("+  Exponential of " +num1 +"to the power of "+num2 +" is : " +exp.ToString("F2"));
		Console.WriteLine("+--------------------------------------------------------------------------------------+ ");
        Console.WriteLine("+  Square Root of " + num1 + ": " +sq1.ToString("F2"));
		Console.WriteLine("+--------------------------------------------------------------------------------------+ ");
        Console.WriteLine("+  Cube Root of " + num1 + ": " +cb1.ToString("F2"));
		Console.WriteLine("+--------------------------------------------------------------------------------------+ ");
		Console.WriteLine("+  Square Root of " + num2 + ": " + sq2.ToString("F2"));
		Console.WriteLine("+--------------------------------------------------------------------------------------+ ");
        Console.WriteLine("+  Cube Root of " + num2 + ": " +cb2.ToString("F2") );
		Console.WriteLine("+--------------------------------------------------------------------------------------+ ");
    }

    static void CheckArmstrongNumber()
    {
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("                                                               ''' ");
		Console.WriteLine("AAAAA  RRRR  MMMMMMM SSSSS TTTTT  RRRR   OOOOO NN   NN GGGGG   '' SSSSS");
		Console.WriteLine("A   A R    R M  M  M S       T   R    R  O   O N N   N G        ' S");
		Console.WriteLine("AAAAA R R R  M  M  M SSSSS   T   R R R   O   O N  N  N G  GG   '  SSSSS");
		Console.WriteLine("A   A R   R  M  M  M     S   T   R    R  O   O N   N N G   G          S");
		Console.WriteLine("A   A R    R M  M  M SSSSS   T   R     R OOOOO N    NN GGGGG      SSSSS");
		Console.WriteLine(" ");
		Console.WriteLine("NN   NN U  U MMMMMMM  BBBB  EEEEE  RRRR   SSSSS");
		Console.WriteLine("N N   N U  U M  M  M B    B E     R    R  S");
		Console.WriteLine("N  N  N U  U M  M  M BBBBB  EEEEE R R R   SSSSS");
		Console.WriteLine("N   N N U  U M  M  M B    B E     R    R      S");
		Console.WriteLine("N    NN UUUU M  M  M BBBBB  EEEEE R     R SSSSS");
		Console.WriteLine(" ");
		Console.WriteLine(" ");
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
		Console.WriteLine("+  Armstrong numbers are the sum of their own digits to the third power of the number of digits.   + ");
		Console.WriteLine("+                             Example: 153 = 1*1*1 +5*5*5 + 3*3*3                                  +");
		Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
		Console.WriteLine(" ");
		while(true)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("+-----------------------------------------------------------------+");
			Console.WriteLine("+ 1. + Check if the number entered is Armstrong's Number or not?  +");
			Console.WriteLine("+----+------------------------------------------------------------+");
			Console.WriteLine("+ 2. + List all the Armstrong's Numbers within the given range.   +");
			Console.WriteLine("+-----------------------------------------------------------------+");
			Console.WriteLine("+ 3. + Return to main menu                                        +");
			Console.WriteLine("+-----------------------------------------------------------------+");
			Console.WriteLine(" ");
			Console.ResetColor();
			Console.Write(" Enter your choice: ");
			int option = Convert.ToInt32(Console.ReadLine());
		
			switch (option)
			{
				case 1:
					CheckSingleArmstrongNumber();
					break;
				case 2:
					ListArmstrongNumbersInRange();
					break;
				case 3:
					return;
				default:
					Console.WriteLine(" Invalid choice. Please enter a number between 1 and 2.");
					break;
			}
		}
	}

	static void CheckSingleArmstrongNumber()
	{
		Console.Write(" Enter a number to check if it's an Armstrong number: ");
		int num = Convert.ToInt32(Console.ReadLine());

		int originalNumber = num;
		int sum = 0;
		int digitCount = CountDigits(num);

		while (num > 0)
		{
			int digit = num % 10;
			sum += (int)Math.Pow(digit, digitCount);
			num /= 10;
		}

		if (sum == originalNumber)
		{
			Console.WriteLine(originalNumber + " is an Armstrong number.");
		}
		else
		{
			Console.WriteLine(originalNumber + " is not an Armstrong number.");
		}
	}

	static void ListArmstrongNumbersInRange()
	{
		Console.Write(" Enter the starting number of the range: ");
		int start = int.Parse(Console.ReadLine());

		Console.Write(" Enter the ending number of the range: ");
		int end = int.Parse(Console.ReadLine());

		Console.WriteLine(" Armstrong numbers between " + start + " and " + end + " are:");

		for (int number = start; number <= end; number++)
		{
			if (IsArmstrongNumber(number))
			{
				Console.WriteLine(number);
			}
		}
	}

	static int CountDigits1(int num)
	{
		int count = 0;
		while (num != 0)
		{
			num /= 10;
			count++;
		}
		return count;
	}

	static bool IsArmstrongNumber(int num)
	{
		int originalNumber = num;
		int sum = 0;
		int digitCount = CountDigits1(num);

		while (num > 0)
		{
			int digit = num % 10;
			sum += (int)Math.Pow(digit, digitCount);
			num /= 10;
		}

		return sum == originalNumber;
	}

    static void FindSubstrings()
    {
		Console.WriteLine("");
        Console.Write(" Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine(" Substrings:");

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 1; j <= input.Length - i; j++)
            {
                Console.WriteLine(input.Substring(i, j));
            }
        }
    }

    static void DivideByZeroException()
    {
        try
        {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("DDDD   IIIII V       V IIIII DDDD   EEEE");
			Console.WriteLine("D   D    I    V     V    I   D   D  E");
			Console.WriteLine("D    D   I     V   V     I   D    D EEEE");
			Console.WriteLine("D   D    I      V V      I   D   D  E");
			Console.WriteLine("DDDD   IIIII     V     IIIII DDDD   EEEE");
			Console.WriteLine(" ");
			Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Enter numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            if (denominator == 0)
            {
				Console.ForegroundColor = ConsoleColor.Red;
                throw new DivideByZeroException(" Denominator cannot be zero.");
				
            }

            Console.WriteLine(" Result: " + numerator / (double)denominator);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(" Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(" Error: " + ex.Message);
        }
    }

    static void DrawPascalsTriangle()
    {
        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            int number = 1;

            for (int j = 0; j <= i; j++)
            {
                Console.Write(number + " ");
                number = number * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }

    static void DrawFloydsTriangle()
    {
        Console.Write("Enter the number of rows for Floyd's Triangle: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        int number = 1;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(number + " ");
                number++;
            }
            Console.WriteLine();
        }
    }

    static void ReadAndCopyTextFile()
    {
        Console.Write("Enter the path of the text file: ");
        string filePath = Console.ReadLine();

        try
        {
            string content = System.IO.File.ReadAllText(filePath);
            Console.WriteLine("File content:\n" + content);

            Console.Write("Enter the path to copy the file: ");
            string copyPath = Console.ReadLine();

            System.IO.File.Copy(filePath, copyPath, true);
            Console.WriteLine("File copied successfully.");
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (System.UnauthorizedAccessException)
        {
            Console.WriteLine("Unauthorized access to the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void PerformStackOperations()
    {
        Stack<int> stack = new Stack<int>();

        Console.WriteLine("Stack Operations:");
        Console.WriteLine("1. Push");
        Console.WriteLine("2. Pop");
        Console.WriteLine("3. Display");
        Console.WriteLine("4. Exit");

        while (true)
        {
            Console.Write("Enter your choice: ");
            int stackChoice = Convert.ToInt32(Console.ReadLine());

            switch (stackChoice)
            {
                case 1:
                    Console.Write("Enter element to push: ");
                    int element = Convert.ToInt32(Console.ReadLine());
                    stack.Push(element);
                    break;
                case 2:
                    if (stack.Count > 0)
                    {
                        int poppedElement = stack.Pop();
                        Console.WriteLine("Popped element: " + poppedElement);
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Stack elements:");
                    foreach (var item in stack)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }

    static void PerformComplexNumberOperations()
    {
        Console.Write("Enter real part of first complex number: ");
        double real1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter imaginary part of first complex number: ");
        double imag1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter real part of second complex number: ");
        double real2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter imaginary part of second complex number: ");
        double imag2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Sum: " + (real1 + real2) + " + " + (imag1 + imag2) + "i");
        Console.WriteLine("Difference: " + (real1 - real2) + " + " + (imag1 - imag2) + "i");
    }

    
	public abstract class Shape5
	{
		public virtual void Draw()
		{
			Console.WriteLine("Drawing Shape");
		}

		public virtual void Erase()
		{
			Console.WriteLine("Erasing Shape");
		}
	}

	public class Circle : Shape5
	{
		public override void Draw()
		{
			Console.WriteLine("Drawing Circle");
		}

		public override void Erase()
		{
			Console.WriteLine("Erasing Circle");
		}
	}

	public class Triangle : Shape5
	{
    public override void Draw()
    {
        Console.WriteLine("Drawing Triangle");
    }

    public override void Erase()
    {
        Console.WriteLine("Erasing Triangle");
    }
	}

	public class Square : Shape5
	{
		public override void Draw()
		{
			Console.WriteLine("Drawing Square");
		}

		public override void Erase()
		{
			Console.WriteLine("Erasing Square");
		}
	}

public static void ImplementPolymorphism()
{
    Shape5[] shapes = new Shape5[3];
    shapes[0] = new Circle();
    shapes[1] = new Triangle();
    shapes[2] = new Square();

    foreach (Shape5 shape in shapes)
    {
        shape.Draw();
        shape.Erase();
    }
}

public static void CalculateAreaAndPerimeter()
{
    PerimeterCalculator[] shapes = {
        new PerimeterCalculator(4),
        new PerimeterCalculator(6),
        new PerimeterCalculator(8)
    };
    ShapeDrawer.DrawShapes(shapes);
}
   

    static void ResizeRectangle()
    {
        IResizable resizableRectangle = new ResizableRectangle(10, 5);
        Console.WriteLine("The original dimensions of the rectangle are: 10, 5");
        Console.Write("Enter the new dimensions of width and height respectively:");
        int newWidth = Convert.ToInt32(Console.ReadLine());
        int newHeight = Convert.ToInt32(Console.ReadLine());
        resizableRectangle.ResizeWidth(newWidth);
        resizableRectangle.ResizeHeight(newHeight);
    }

    static int CountDigits(int num)
    {
        int count = 0;
        while (num != 0)
        {
            num /= 10;
            count++;
        }
        return count;
    }
}

interface IResizable
{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}

abstract class Shape5
{
    public abstract double CalculatePerimeter();
    public abstract void Draw();
    public virtual void Erase()
    {
        Console.WriteLine("Erasing the shape.");
    }
}

class PerimeterCalculator : Shape5  
{
    private double side;

    public PerimeterCalculator(double side)
    {
        this.side = side;
    }

    public override double CalculatePerimeter()
    {
        return 4 * side;
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing a square with side length: " + side);
    }
}

class ShapeDrawer
{
    public static void DrawShapes(Shape5[] shapes)
    {
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}


class ResizableRectangle : Shape5, IResizable
{
    private int width;
    private int height;

    public ResizableRectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void ResizeWidth(int newWidth)
    {
        width = newWidth;
        Console.WriteLine("Width resized to: " + width);
    }

    public void ResizeHeight(int newHeight)
    {
        height = newHeight;
        Console.WriteLine("Height resized to: " + height);
    }
	public override double CalculatePerimeter()
    {
        return 2 * (width + height);
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing a resizable rectangle with width: " + width + " and height: " + height);
    }  
}
