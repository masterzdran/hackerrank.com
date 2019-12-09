package pt.nunocancelo.hackerrank;
//https://www.hackerrank.com/challenges/find-digits
public class FindDigits {
	
	public static int findDigits(double value)
    {
      
      int remain = 0;
      int div = 0;
      int newValue = (int)value;
      double operationResult =0;
      
      do
      {
    	  remain = newValue%10;
          if(remain != 0) 
          {      
        	  operationResult = value/remain;
        	  if((operationResult - Math.floor(operationResult)) == 0)
        	  {
        		  ++div;
        	  }
        		  
          }
      }
      while((newValue = newValue/10) !=0);

      return div;
    }
}
