int n = int.Parse(Console.ReadLine());

int[] litresPetrolFromEachPump = new int[n];
int[] distancesFromCurrentToTheNextPetrolPump = new int[n];

for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    litresPetrolFromEachPump[i] = input[0];
    distancesFromCurrentToTheNextPetrolPump[i] = input[1];
}

int lorryTankFuel = 0;
int distanceInKilometers = 0;
int petrolPumpStops = 0;
int index = 0;

Stack<int> stack = new Stack<int>();
while (true)
{
    int litres = litresPetrolFromEachPump[index];
    int distance = distancesFromCurrentToTheNextPetrolPump[index];

    lorryTankFuel += litres;
    distanceInKilometers = distance;

    if (lorryTankFuel >= distanceInKilometers) // lorry fuel consuption - liter per kilometer
    {
        lorryTankFuel -= distanceInKilometers;
        petrolPumpStops++;
        if (petrolPumpStops == 1)
        {
            stack.Push(index);
        }
    }
    else
    {
        lorryTankFuel = 0;
        petrolPumpStops = 0;
    }
    if (petrolPumpStops == n)
    {
        Console.WriteLine(stack.Pop());
        return;
    }
    index++;
    if (index == n)
    {
        index = 0;
    }
}
