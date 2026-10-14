/*GRADAE LETTER*/
    
Console.WriteLine("Enter your grade score:  ");
int score=int.Parse(Console.ReadLine());

while (score > 100 || score <0)
{
  
   
        Console.WriteLine("İNVALİD SCORE");break;
}

if (score <= 100 && score >= 90)
    Console.WriteLine("Yur letter grade is A");
if (score <= 89 && score >= 80)
    Console.WriteLine("Yur letter grade is B");
if (score <= 79 && score >= 70)
    Console.WriteLine("Yur letter grade is C");
if (score <= 69 && score >= 60)
    Console.WriteLine("Yur letter grade is D");
if (score <= 59 && score >= 0)
    Console.WriteLine("Yur letter grade is F\n\n\n*******************************************************\n\n\n");


/*SUM UNTİL ZERO*/

int total = 0;
int counter = 0;
Console.Write("Enter the 0(zero) to STOP:\nEnter your numbers: ");
int numbers=int.Parse(Console.ReadLine());


while (numbers != 0)
{
    total += numbers;
    counter++;
    Console.Write("Enter your numbers: ");
    numbers=int.Parse(Console.ReadLine());
    
}

double average = (double)total / counter;
Console.WriteLine($"Count: {counter}\tSum: {total}\tAverage: {average:F2}  ");

