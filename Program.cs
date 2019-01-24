using System;

namespace p1
{
    class Program
    {
        static double calculateBmi(double weight, int height)
        {
        return weight / ( ( height / 100.0 ) * ( height / 100.0 ) );
        }
        static void Main(string[] args)
        {
            var name = "";
            var height = 0;
            var weight = 0.0;
            var bmi = 0.0;
            var bmiValue = "";
            var gender = "";
            var checkAgain = true;
            var cost = 0.0m;
            var END_CHAR='q';
            
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

            bmi = calculateBmi(weight,height);
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
           
            if(bmiValue == "UNDERWEIGHT")
            {
                Console.WriteLine($"You are {bmiValue}.\n In order to be fit we recommened you to use this product.\n If you would like to buy this product click 'Y' or else enter 'q' to quit.");
                var product = Console.ReadLine();
                if(product == "y")
                {
                   Console.WriteLine("The cost for the product is 2 dollars. \n 1.Please enter no of quantity or 'q' to quit.");
                   var quantity = Console.ReadLine();
                   if(quantity != "q")
                   {
                   cost = 2 * Convert.ToInt32(quantity);
                   }
                  if(quantity == "q")
                 {
                Console.WriteLine("DONE!");
                checkAgain = false;
                break;
                 }
                }
                else if(product == "q")
            {
                Console.WriteLine("DONE!");
                checkAgain = false;
                break;
            }
            Console.WriteLine($"Your order has been placed succesfully with an amount of: {cost} dollars.");
            }
            
            if(bmiValue == "NORMAL")
            {
                Console.WriteLine("You are perfectly fit and we recommend you to follow the same diet to be healthy like this.");
            }

            if(bmiValue == "OVERWEIGHT" || bmiValue == "OBESE")
            {
                Console.WriteLine($"You are {bmiValue}.\n In order to become thin we recommened you to use this product.\n If you would like to buy this product click 'Y' or else enter 'q' to quit");
                var product = Console.ReadLine();
                if(product == "y")
                {
                   Console.WriteLine("The cost for the product is 8 dollars. \n 1.Please enter no of quantity or 'q' to quit");
                   var quantity = Console.ReadLine();
                   if(quantity!= "q")
                   {
                   cost = 8 * Convert.ToInt32(quantity);
                   }
                  if(quantity== "q")
            {
                Console.WriteLine("DONE!");
                checkAgain = false;
                break;
            }
                }
                else if(product == "q")
            {
                Console.WriteLine("DONE!");
                checkAgain = false;
                break;
            }
            Console.WriteLine($"Your order has been placed succesfully with an amount of: {cost} dollars.");
            }
            
            Console.WriteLine("Enter 'y' to check again or 'q' to quit");
            var checking = Console.ReadLine();
            END_CHAR=Convert.ToChar(checking);
            if(END_CHAR=='q')
            {
                Console.WriteLine("DONE!");
                checkAgain = false;
                break;
            }
            }            
        }
    }
}
