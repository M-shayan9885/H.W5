List<person> persons = new List<person> ();

persons.Add(new person(1, "shayan", 23,"05/21/2014 12:32","ffdfdfrgregrg",123));
persons.Add(new person(2, "hamid", 24,"343434","sfgdgdfgd",454));
persons.Add(new person(3, "hamed", 19,"34343434","sdfdfgdgd",23434));


Console.WriteLine("please select action :");
Console.ReadLine();
Console.WriteLine("1-sort name of person by 20+ age");
Console.WriteLine("2-person who date of birth under 1999");
Console.WriteLine("3-person who has equle birtday");
Console.WriteLine("4-person sort by id && remove person number 4 of list");
Console.WriteLine("5-person sort by id && remove person number 50 till number 80");
Console.WriteLine("6-view person who has max age in list");
Console.WriteLine("7-view report of there is double of id");
Console.WriteLine("8-view person who live in tehran");
Console.WriteLine("9-view person who live in tehran + has same name");
Console.WriteLine("10-person has 1.2.3 in id");
Console.WriteLine("11-person who has age above 25+");
Console.WriteLine("ATTENTION");
Console.WriteLine("in number 11 you can only see soctioalsecuritynumber with adress");

var action = Convert.ToInt32(Console.ReadLine());

foreach (var person in persons)
{
    switch (action)
    {
        case 11:
            {
                
                break;
            }
    }
}

