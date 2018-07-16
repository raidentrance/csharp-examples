using System;
					
public class Program
{
	
	public static void suma(double x,double y){
		Console.Writ eLine("El resultado de la suma es "+(x+y));
	}
	
	public static void resta(double x, double y){
		Console.WriteLine("El resultado de la resta es "+(x-y));
	}
	
	public static void multiplicacion(double x, double y){
		Console.WriteLine("El resultado de la multiplicacion es "+(x*y));
	}
	
	public static void division(double x, double y){
		if(y!=0){
			Console.WriteLine("El resultado de la division es "+(x/y));
		}else{
			Console.WriteLine("No se puede realizar la división entre 0");
		}
	}
	
	public static void residuo(double x,double y){
		if(y!=0){
			Console.WriteLine("El residuo es "+(x%y));
		}else{
			Console.WriteLine("No se puede calcular el residuo para una división entre 0");
		}	
	
	}
	
	public static void Main()
	{
		Console.WriteLine("Escribe el primer número : ");
		double x=double.Parse(Console.ReadLine());
		Console.WriteLine("Escribe el segundo número ste men : ");
		double y=double.Parse(Console.ReadLine());
		Console.WriteLine("La suma es : "+x+y);
		suma(x,y);
		resta(x,y);
		multiplicacion(x,y);
		division(x,y);
		residuo(x,y);
		
		
		
	}
}