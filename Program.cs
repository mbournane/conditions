namespace LogicalOperators;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Entrez une valeur minimum: ");
        int minValue = Int32.Parse(Console.ReadLine());
        
        
        Console.WriteLine("Entrez une valeur maximum: ");
        int maxValue = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Entrez une valeur entre :" + minValue + " et " +maxValue);
        int intValue = Int32.Parse(Console.ReadLine());

        if(intValue < minValue)
        {
            Console.WriteLine("Valeur 1 : " + maxValue);
            Console.WriteLine("Valeur 2 : " + minValue);
            Console.WriteLine("Intreger : " + intValue);
            Console.WriteLine("You have entred: "+ intValue + " which is lower than " + minValue + " which is the minimum");
            Console.WriteLine("Resulting integer: " + minValue);                
        }else
        if(intValue> maxValue)
        {
            Console.WriteLine("Valeur 1 : " + maxValue);
            Console.WriteLine("Valeur 2 : " + minValue);
            Console.WriteLine("Intreger : " + intValue);
            Console.WriteLine("You have entred: "+ intValue + " which is greater than " + maxValue + " which is the maximum");
            Console.WriteLine("Resulting integer: " + maxValue);  
        }else
            Console.WriteLine("good");

    }
}
