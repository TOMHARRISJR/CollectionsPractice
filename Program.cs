int[] numArray = new int[9];
for (int idx = 1; idx < numArray.Length;idx++)
{
numArray[idx] = idx;
}
Console.WriteLine(numArray[1]);  

string[] nameArray = new string[]{"Tim","Martin","Nikki","Sara"};

bool[] array = new bool[10];

for(int i=0; i<array.Length; i++)
{
    if( i % 2 == 0)
    {
        array[i] = true;
    } 
    else
    {
        array[i] = false;
    }
}

foreach (bool item in array)
{
    Console.WriteLine(item);
}

List<string> icecream = new List<string>(){
   "Vanilla","Chocolate","Strawberry","Mint","Rasberry" 
};


icecream.RemoveAt(2);

Console.WriteLine($"{icecream.Count}");
Console.WriteLine(icecream[2]);

Dictionary<string,string?> dict = new Dictionary<string, string>();

Random random =new Random();


foreach(string name in nameArray)
{
    dict.Add(name,null);
}
foreach (string name in nameArray)
{
    int rName = random.Next(icecream.Count);
    dict[name]= icecream[rName];
}

// dict.Add(nameArray[rName],"Tom");
// dict.Add("Color","Brown");
foreach(var item in dict)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}




