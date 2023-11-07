Queue<string> queue = new Queue<string>();
int nCarsCanPass = int.Parse(Console.ReadLine());

string input = string.Empty;
int passedCars = 0;
while ((input = Console.ReadLine()) != "end")
{
    string command = input;
    if (command == "green")
    {
        int pass = nCarsCanPass;

        while (queue.Count > 0 && pass != 0)
        {
            Console.WriteLine($"{queue.Dequeue()} passed!");
            pass--;
            passedCars++;
        }
    }
    else
    {
        string vehicle = input;
        queue.Enqueue(vehicle);
    }
}
Console.WriteLine($"{passedCars} cars passed the crossroads.");
