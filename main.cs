using System;

namespace EA1 {
    class Program {
        static void Main() {
        double l1, l2, hipotenusa;
        
        Console.WriteLine ("Escolha a opção:\n 1 - Encontrar a hipotenusa\n 2 - Achar area e perimetro\n 3 - Comparar dois triangulos\n");
        Console.WriteLine("Opção: ");
        int control = Int32.Parse(Console.ReadLine());

        if (control == 1){
            Console.WriteLine("Digite os 2 lados");
            Console.WriteLine("Digite o lado 1: " );
            l1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2: " );
            l2 = Int32.Parse(Console.ReadLine());
        
        Triangulos valor = new Triangulos(l1,l2);
        double hip = valor.encontrarHipotenusa();
        Console.WriteLine(hip);

        } else if (control == 2){
            Console.WriteLine("Digite os 2 lados");
            Console.WriteLine("Digite o lado 1: " );
            l1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2: " );
            l2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hipotenusa: " );
            hipotenusa = Int32.Parse(Console.ReadLine());

        Triangulos valor = new Triangulos(l1,l2,hipotenusa);
        double perimetro = valor.encontrarPerimetro();
        double area = valor.encontrarArea();
        Console.WriteLine("O perímetro é: " + perimetro);
        Console.WriteLine("A area é: " + area);
        
        } else if (control == 3){
            double area, area1=0, area2=0;
            int maiorArea = 0;
            
            for (int i=0; i < 2; i++) {
            Console.WriteLine("\nTriangulo " + (i+1));
            Console.WriteLine("Digite o lado 1: " );
            l1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2:" );
            l2 = Int32.Parse(Console.ReadLine());

            if (i == 0) {
                Triangulos valor1 = new Triangulos(l1,l2);
                area1 = valor1.encontrarArea();
                Console.WriteLine("A area é: " + area1 + " m²");
                
            } else {
                Triangulos valor2 = new Triangulos(l1,l2);
                area2 = valor2.encontrarArea();
                Console.WriteLine("A area é: " + area2 + " m²");
            }

            }
                maiorArea = Triangulos.compararArea(area1, area2);

                if (maiorArea == 1) {
                    area = area1;
                } else {
                    area = area2;
                }

                Console.WriteLine("A maior area é a do triangulo " + maiorArea + " e ele tem " + area + "m².");
            

        }
        }
    }
}