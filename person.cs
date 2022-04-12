public class person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string DateTime;
    public string Adress { get; set; }
    public int Sociolsecuritynumber { get; set; }
    public person (int id, string name, int age,string dateTime,string adress,int socialsecuritynumber)
    {
        Id = id;
        Name = name;
        Age = age;
        DateTime = dateTime;
        Adress = adress;
        Sociolsecuritynumber = socialsecuritynumber;
    }
        
}
