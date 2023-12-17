
Console.WriteLine(new Solution().IntToRoman(299));

public class Solution
{
	public string IntToRoman(int num)
	{
		var keys = new Dictionary<int, Dictionary<char, string>>()
		{
			{ 1, new Dictionary<char, string>
			{
				{'0',string.Empty},
				{'1',"I"},
				{'2',"II"},
				{'3',"III"},
				{'4',"IV"},
				{'5',"V"},
				{'6',"VI"},
				{'7',"VII"},
				{'8',"VIII"},
				{'9',"IX"},
			}},
			{ 2, new Dictionary<char, string>
			{
				{'0',string.Empty},
				{'1',"X"},
				{'2',"XX"},
				{'3',"XXX"},
				{'4',"XL"},
				{'5',"L"},
				{'6',"LX"},
				{'7',"LXX"},
				{'8',"LXXX"},
				{'9',"XC"},
			}},
			{ 3, new Dictionary<char, string>
			{
				{'0',string.Empty},
				{'1',"C"},
				{'2',"CC"},
				{'3',"CCC"},
				{'4',"CD"},
				{'5',"D"},
				{'6',"DC"},
				{'7',"DCC"},
				{'8',"DCCC"},
				{'9',"CM"},
			}},
			{ 4, new Dictionary<char, string>
			{
				{'0',string.Empty},
				{'1',"M"},
				{'2',"MM"},
				{'3',"MMM"},
			}},
		};

		string numStr = num.ToString();
		string result = "";

		try
		{
			for (int i = 0; i < numStr.Length; i++)
			{
				result += keys[numStr.Length - i][numStr[i]];
			}
		}
		catch(Exception e)
		{
            Console.WriteLine($"Exepcetion occured:{e.Message}");
        }

		return result;
	}
}