
HashSet<string> parkingLot = new HashSet<string>();

while (true)
{
    string input = Console.ReadLine();
    if (input == "END")
    {
        break;
    }
    string[] splitted = input.Split(",");
    string direction = splitted[0];
    string carNumber = splitted[1];

    if (direction == "IN")
    {
        parkingLot.Add(carNumber);
    }
    else
    {
        parkingLot.Remove(carNumber);
    }

}
if (parkingLot.Count == 0)
{
    Console.WriteLine("Parking Lot is Empty");
}
else
{
    foreach (var carNumber in parkingLot)
    {
        Console.WriteLine(carNumber);
    }
}