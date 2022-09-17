<Query Kind="Program" />

/*
https://leetcode.com/problems/reverse-integer/
*/

void Main()
{
	Int32.MaxValue.Dump("MAX");
	Int32.MinValue.Dump("MIN");

	int x = 1534236469;
	Reverse(x).Dump();
}


int Reverse(int x)
{
	Int32 MAX = Int32.MaxValue;
	Int32 MIN = Int32.MinValue;

	int result = 0;
	while(x != 0)
	{
		int digit = x%10;
		x = x / 10;
		
		if( result > (MAX/10) 
		|| (result == (MAX/10) && (digit >= (MAX%10))) )
		return 0;
		
		if( result < (MIN/10) 
		|| (result == (MIN/10) && (digit <= (MIN%10))) )
		return 0;
		
		result = (result*10) + digit;
	}
	return result;
}

