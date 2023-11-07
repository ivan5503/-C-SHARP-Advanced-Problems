
int n = int.Parse(Console.ReadLine());
HashSet<string> usernameList = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string username = Console.ReadLine();
    usernameList.Add(username);
}
foreach (var user in usernameList)
{
    Console.WriteLine(user);
}