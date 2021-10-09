using System;


namespace EA1 {
class Triangulos : ITag {
    private double lado1;
	private double lado2;
	private double hipotenusa;

    //Construtores
    
    public Triangulos(double l1, double l2) {
        lado1 = l1;
        lado2 = l2;
    }

    public Triangulos(double l1, double l2, double hip){
        lado1 = l1;
        lado2 = l2;
        hipotenusa = hip;
    }

        //Metodos
        public double encontrarHipotenusa() {
        double h = Math.Sqrt((lado1 * lado1)+(lado2 * lado2));
        return h;
    }
    
    public double encontrarPerimetro() {
        double perimetro = lado1 + lado2 + hipotenusa;
        return perimetro;
    }

    public double encontrarArea() {
        double area = (lado1 * lado2)/2;
        return area;
    }
    
    public static int compararArea(double a, double b) {
        int maiorArea = 0;

        if(a > b) {
            maiorArea = 1;
        }
        if (a < b) {
            maiorArea = 2;
        }
        return maiorArea;
    }
   

  }
}