package pt.nunocancelo.hackerrank;
//https://www.hackerrank.com/challenges/is-fibo
public class IsFibo {
	
	//https://en.wikipedia.org/wiki/Fibonacci_number#Recognizing_Fibonacci_numbers
	public static boolean isFibonacci(double x)
	{
		double aa = Math.sqrt((5*Math.pow(x, 2))+4);
		double bb = Math.sqrt((5*Math.pow(x, 2))-4);
		return (aa - Math.floor(aa)) == 0 || (bb - Math.floor(bb)) == 0;   	
	}
	//https://en.wikipedia.org/wiki/Fibonacci_number#Matrix_form
	//http://mathworld.wolfram.com/BinetsFibonacciNumberFormula.html
    public static double fibonacciNthNumber(double n)
    {
    	return (Math.pow((1 + Math.sqrt(5)), n) - Math.pow((1 - Math.sqrt(5)), n))/(Math.pow(2, n)*Math.sqrt(5));
    }

}
