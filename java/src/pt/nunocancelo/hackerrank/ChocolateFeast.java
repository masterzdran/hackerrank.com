package pt.nunocancelo.hackerrank;

public class ChocolateFeast {
    public static int chocolateFeast(int dollars, int price, int warperExchange)
    {
    	
    	int chocolates = dollars / price;
    	int warpers = chocolates;
    	int w =0;
    	
    	while(warpers >= warperExchange)
    	{
    		w= warpers/warperExchange;
    		chocolates+=w;
    		warpers = warpers -(w*warperExchange) + w;
    	}
    	return chocolates;
   
    }

}
