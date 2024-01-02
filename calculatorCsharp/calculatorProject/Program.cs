Console.WriteLine("Welcome to Calculator App");

int FirstNum;
int SecondNum;
double result;
string op;
Console.WriteLine("Enter the first Number");
 FirstNum = int.Parse(Console.ReadLine());
 

 Console.WriteLine("Enter the Second Number");
 SecondNum = int.Parse(Console.ReadLine());

 System.Console.WriteLine("Enter the operation \n Multiply press M  \n Division press D \n Subtraction press S\n Addition press A");
op =  Console.ReadLine(); 

if(op == "M")
{
result = FirstNum * SecondNum;
 Console.WriteLine(result);
 
}
else if(op=="D")
{
    result = FirstNum / SecondNum;
   Console.WriteLine(result);
}
else if(op=="S")
{
    result = FirstNum - SecondNum;
 Console.WriteLine(result);
}
else if(op=="A")
{
    result = FirstNum + SecondNum;
 Console.WriteLine(result);
}
else{
    Console.WriteLine("Error");
}
 
