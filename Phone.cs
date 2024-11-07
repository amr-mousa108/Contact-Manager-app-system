using System.ComponentModel.Design;

public class Phone
{

    public string? PhoneNumber { get; set; }
    public string? PhoneNumbertType { get; set; }
    public string? NumberDescription { get; set; }
    public static void GetPhone(Phone phone)
    {
        if (phone.PhoneNumbertType == null)  
           Console.Write($"Here is the Phone Number:{phone.PhoneNumber}");
       
    }
}


