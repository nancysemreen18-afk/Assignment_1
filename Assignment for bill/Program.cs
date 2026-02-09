
Console.WriteLine("Please Enter Your Bill "); 
double billAmount = Convert.ToDouble(Console.ReadLine()); //input from  user and convert to double 
double discount = 0;
if  (billAmount >= 500)
{
    discount= billAmount - (billAmount * 0.20);
}
else if  (billAmount >= 300 && billAmount <= 499)
{
    discount = billAmount -  (billAmount * 0.10);
}

else
{
    discount= billAmount;
}
Console.WriteLine($"The Final Price : {discount}  ");


