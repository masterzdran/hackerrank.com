package pt.nunocancelo.hackerrank;

public class CaesarCipher {
	private static final char UC_A = 65;
	private static final char UC_Z = 90;
	private static final char LC_A = 97;
	private static final char LC_Z = 122;
	private static final char ALPHABET_LETTERS = 26;
	
	public static String caesarCipher(int lenght, String message, int rotation)
	{
		StringBuffer caesarMessage = new StringBuffer();
		
		for(int idx =0;idx < lenght;idx++)
		{
			caesarMessage.append(caesarCipherEncrypt(message.charAt(idx),rotation));
		}
		
		return caesarMessage.toString();
	}
	


	
	private static char caesarCipherEncrypt(char c, int rotation)
	{
		int r = c;
		
		rotation = rotation % ALPHABET_LETTERS;
		
		if(c>=UC_A && c<=UC_Z)
		{
			r = shiftLetters(c,rotation,UC_A);
		}
		else if (c>= LC_A && c<=LC_Z)
		{
			r = shiftLetters(c,rotation,LC_A);
		}
		else
		{
			return c;
		}
		return (char) r;
		
	}
	private static int shiftLetters (char c, int rotation, char shift)
	{
		return (((c - shift) + rotation) % ALPHABET_LETTERS) + shift;
	}

}
