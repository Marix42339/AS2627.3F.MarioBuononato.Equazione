namespace AS2627._3F.MarioBuononato.Equazione;

class Program
{
    static void Main()
    {
        Console.Write("Inserisci a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Inserisci b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Inserisci c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a != 0) 
        {
            double delta = (b * b) - (4 * a * c);

            if (delta > 0) 
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0) 
            {
                double x = -b / (2 * a);
                
                Console.WriteLine($"x = {x}");
            }
            else 
            {
                Console.WriteLine("l'equazione non ha radici reali");
            }
        }
        else 
        {
            Console.WriteLine("l'equazione non è di secondo grado");
        }
    }
}