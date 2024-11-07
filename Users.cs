using System.Data;
using System.Reflection.Metadata;

public class User
{
     public String? firstName { get; set; }
    public String? lastName { get; set; }
    public int? id { get; set; }
    public String? gender { get; set; }

    public string? city {  get; set; }
    public DateTime? addedDate { get; set; }
    internal List<Email> emails { get; set; }
    public List<Address> addresses { get; set; }
    public List<Phone> phones { get; set; }
    public List<User> users { get; set; }

    public User()
    {
        emails = new List<Email>();
        addresses = new List<Address>();
        phones = new List<Phone>();
    users= new List<User>();
    }
    public bool Search(string searchData)
    {
        foreach (var phone in phones)
        {
            if (phone.PhoneNumber == searchData)
            {
                return true;
            }
        }
        foreach (var email in emails)
        {
            if (email.setEmail == searchData || email.setDescripion == searchData || email.SetType == searchData)
            {
                return true;
            }
        }
        foreach (var address in addresses)
        {
            if (address.Place == searchData || address.AddressDescription == searchData || address.AddressType == searchData)
            {
                return true;
            }
        }
        foreach (var user in users)
        {
            if (user.id.ToString() == searchData || user.firstName == searchData || user.lastName == searchData || user.gender == searchData || addedDate.ToString() == searchData || user.city == searchData)
            {
                return true;
            }
        }
        return false;

    }
    public void Show()
    {
        Console.WriteLine($"ID :{id}");
        Console.WriteLine($"Name :{firstName} {lastName}");
        Console.WriteLine($"Gender :{gender}");
        Console.WriteLine($"City :{city}");
        Console.WriteLine($"Date :{addedDate}");

        Console.WriteLine("Phones");
        foreach (var phone in phones)
        {
            Console.WriteLine($"Number:{phone.PhoneNumber} , Type:{phone.PhoneNumbertType} ,Desctiption:{phone.NumberDescription} ");

        }
        Console.WriteLine("Address");
        foreach (var address in addresses)
        {
            Console.WriteLine($"Place:{address.Place},Type:{address.AddressType},Descrioption:{address.AddressDescription}");

        }

        Console.WriteLine("Emails");
        foreach (var email in emails)
        {
            Console.WriteLine($"Email:{email.setEmail},Type:{email.SetType}");
        }


    }

}