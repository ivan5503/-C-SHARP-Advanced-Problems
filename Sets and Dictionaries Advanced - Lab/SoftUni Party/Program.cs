HashSet<string> reservationList = new HashSet<string>();

while (true)
{
    string guestReservation = Console.ReadLine();
    if (guestReservation == "PARTY")
    {
        break;
    }
    reservationList.Add(guestReservation);
}
while (true)
{
    string arrivingGuest = Console.ReadLine();
    if (arrivingGuest == "END")
    {
        break;
    }
    reservationList.Remove(arrivingGuest);
}
Console.WriteLine(reservationList.Count);
foreach (var reservationNumber in reservationList)
{
    char ch = reservationNumber[0];
    if (char.IsDigit(ch))
    {
        Console.WriteLine(reservationNumber);
    }
}
foreach (var reservationNumber in reservationList)
{
    char ch = reservationNumber[0];
    if (!char.IsDigit(ch))
    {
        Console.WriteLine(reservationNumber);
    }
}
