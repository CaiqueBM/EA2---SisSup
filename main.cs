using System;

namespace EA1 {
    class Program {
        static void Main() {
        int l1, l2, hipotenusa;
        
        Console.WriteLine ("Escolha a opção:\n 1 - Encontrar a hipotenusa\n 2 - Achar area e perimetro\n 3 - Comparar dois triangulos\n");
        Console.WriteLine("Opção: ");
        int control = Int32.Parse(Console.ReadLine());

        if (control == 1){
            Console.WriteLine("Digite os 2 lados");
            Console.WriteLine("Digite o lado 1: " );
            l1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2: " );
            l2 = Int32.Parse(Console.ReadLine());
        
        Triangulos valor = new Triangulos();
        int hip = valor;

        } else if (control == 2){
            Console.WriteLine("Digite os 2 lados");
            Console.WriteLine("Digite o lado 1: " );
            l1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2: " );
            l2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hipotenusa: " );
            hipotenusa = Int32.Parse(Console.ReadLine());


        
        } else if (control == 3){
            Console.WriteLine("Digite os 2 lados");
            Console.WriteLine("Digite o lado 1: " );
            l1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2: " );
            l2 = Int32.Parse(Console.ReadLine());

        

        }
        }
    }
}