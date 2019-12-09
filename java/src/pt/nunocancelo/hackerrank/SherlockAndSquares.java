package pt.nunocancelo.hackerrank;

import java.util.Scanner;

public class SherlockAndSquares {
	
	public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        
        do{

          System.out.println(numberOfSquares(in.nextInt(),in.nextInt()));
        }
        while((t--)>0);
        in.close();
    }
	
	public static int numberOfSquares(double begin, double end)
	{
		int result = 0;
		double partialResult = 0;
		
		double beginSqrt = Math.floor(Math.sqrt(begin));
		double endSqrt = Math.floor(Math.sqrt(end));
		
		
		
		for(double d = beginSqrt;d<=endSqrt;d++)
		{
			partialResult = Math.pow(d, 2);
			
			if (partialResult >= begin && partialResult<=end) result++;
		}
		
		return result;
	}

}
