using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection;
Contact contact = new Contact();
User user1 =new User {id = 1, firstName = "Mousa", lastName = "Elewa", gender = "male", city = "Menouf", addedDate = DateTime.Now };
user1.phones.Add(new Phone { PhoneNumber="23324847",PhoneNumbertType="Vodafone",NumberDescription=" bcgbfxbg" });
user1.addresses.Add(new Address { Place = @"23 MENOUF Street", AddressDescription = "dcdac", AddressType = "dsa" });
user1.emails.Add(new Email { setEmail = "Amr@elewa.com", setDescripion = "cdsc" ,SetType="csd"});
Console.WriteLine(user1.Search("cdscd"));
user1.Show();

Console.WriteLine("-------------------");
User user2 = new User { id = 1, firstName = @"mousa elewa", lastName = "Elewa", gender = "male", city = "Menouf", addedDate = DateTime.Now };
user2.phones.Add(new Phone { PhoneNumber = "01920019", PhoneNumbertType = "orange", NumberDescription = "perssd" });
user2.addresses.Add(new Address { Place = @"273 MENOUF Street", AddressDescription = "personal", AddressType = "dsdsja" });
user2.emails.Add(new Email { setEmail = "elewa@elewa.com", setDescripion = "cdsc", SetType = "csd" });
Console.WriteLine(user2.Search("273 MENOUF Street"));
user2.Show();

Console.WriteLine("----------------");
User user3 = new User { id = 1, firstName = @"Amr Mousa", lastName = "Elewa", gender = "male", city = "Menouf.Menofia", addedDate = DateTime.Now };
user3.phones.Add(new Phone { PhoneNumber = @"20 0122884", PhoneNumbertType = "Vodafone", NumberDescription = " bcgbfxbg" });
user3.addresses.Add(new Address { Place = @"23ef MENOUF Street", AddressDescription = "dcdac", AddressType = "dsa" });
user3.emails.Add(new Email { setEmail = "mezo@elewa.com", setDescripion = "cdsc", SetType = "csd" });
Console.WriteLine(user3.Search("mezo@elewa.com"));
user3.Show();

Console.WriteLine("_______-------------------___");
contact.AddUser(user1);
contact.AddUser(user2);
contact.AddUser(user3);

contact.ShowAllUsers();
Console.WriteLine(contact.CountUsers()); 

Console.WriteLine();