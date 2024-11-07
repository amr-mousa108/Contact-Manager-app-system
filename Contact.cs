using System.Reflection.Metadata;

class Contact : User
{
    private List<User> _users = new List<User>();
    public Contact()
    {
        _users = new List<User>();
    }
    public void AddUser(User user)
    {
        _users.Add(user);
    }
    public int CountUsers()

    {
        Console.Write("The number of users :");
        return _users.Count();
    }
    public void ShowAllUsers()
    {

        foreach (var user in _users)
        {
            Console.WriteLine("User info:");
            user.Show();
            Console.WriteLine();

        }
    }
}
