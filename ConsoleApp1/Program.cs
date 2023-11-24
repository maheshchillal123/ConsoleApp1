using System.Collections;

int noOfQueries = Convert.ToInt32(Console.ReadLine());
List<int> outputList = new List<int>();

for (int i = 0; i < noOfQueries; i++)
{
	string input = Console.ReadLine();
	int firstValue = Convert.ToInt32(input.Split(" ")[0]);
	int secondValue = Convert.ToInt32(input.Split(" ")[1]);

	switch (firstValue)
	{
		case 1:
			InsertData(secondValue);
			break;
		case 2:
			DeleteData(secondValue);
			break;
		case 3:
			FindData(secondValue);
			break;
		default:
			break;
	}
}

void FindData(int secondValue)
{
	if(outputList.GroupBy(x => x).Where(a => a.Count() == secondValue).Count() > 0)
		Console.WriteLine("1");
	else
		Console.WriteLine("0");
}

void DeleteData(int secondValue)
{
	outputList.Remove(secondValue);
}

void InsertData(int secondValue)
{
	outputList.Add(secondValue);
}