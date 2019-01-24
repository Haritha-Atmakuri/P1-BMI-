using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "";
            var height = 0;
            var weight = 0.0;
            var bmi = 0.0;
            var bmiValue = "";
            var gender = "";
            var checkAgain = true;

            
            while(checkAgain)
            {
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            while(name == "")
            {
             Console.WriteLine("Please enter your name to proceed forward");
             name = Console.ReadLine();
            }
            Console.WriteLine($"Hello {name}\n********\nWelcome to BMI CALCULATOR APP\n*************");
            Console.WriteLine("Please enter your height in cms:");
            height = Convert.ToInt32(Console.ReadLine());
            while(height <= 0 || height.ToString() == "" )
            {
             Console.WriteLine("Please enter valid height to proceed forward");
             height = Convert.ToInt32(Console.ReadLine());
            }
            //Console.WriteLine(height);
            Console.WriteLine("Please enter your Weight in kgs:");
            weight = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(weight);
             while(weight <= 0)
            {
             Console.WriteLine("Please enter valid weight to proceed forward");
             weight = Convert.ToInt32(Console.ReadLine());
            }
             Console.WriteLine("Enter your gender as 'm' or 'f':");
             gender = Console.ReadLine();
            bmi = weight / ( ( height / 100.0 ) * ( height / 100.0 ) );
            Console.WriteLine($"You bmi is: {bmi}");
            switch(gender){
            case "m":
              if(bmi<20)
            {
                bmiValue = "UNDERWEIGHT";
            }
            else if(bmi>=20 && bmi<=25)
            {
                bmiValue = "NORMAL";
            }
            else if(bmi>=25 && bmi<=30)
            {
                bmiValue = "OVERWEIGHT";
            }
            else
            {
                bmiValue = "OBESE";
            }
            break;
            case "f":
              if(bmi<19)
            {
                bmiValue = "UNDERWEIGHT";
            }
            else if(bmi>=19 && bmi<=24)
            {
                bmiValue = "NORMAL";
            }
            else if(bmi>=24 && bmi<=29)
            {
                bmiValue = "OVERWEIGHT";
            }
            else
            {
                bmiValue = "OBESE";
            }
            break;
            }
            Console.WriteLine($"Your weight status is {bmiValue}");
            
           
            Console.WriteLine("Enter 'y' to check again or 'q' to quit");
            var checking = Console.ReadLine();
            if(checking == "q")
            {
                Console.WriteLine("DONE!");
                checkAgain = false;
                break;
            }
            }            
        }
    }
}
