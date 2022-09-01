using static System.Console;
using Day05;

Person yuli = new Customer("Yuli","Ayu", "yuli@gmail.com", new DateTime (1998,04,24), "131_001");
Customer widi = new Customer("Widi", "Amalia", "widi@gmail.com", new DateTime(1999, 09, 30), "131_002");
Customer rini = new Customer("Rini", "Marlina", "rini@gmail.com", new DateTime(1999, 08, 04), "131_003");
Owner zuha = new Owner("Zuha", "Farhanani", "zuha@gmail.com", new DateTime(1998, 07, 07), 2);
Owner ahmad = new Owner("Ahmad", "Vian", "vian@gmail.com", new DateTime(1997, 06, 05), 3);

var incomeYuli = new Dictionary<string, decimal> {

    {"Kontrakan", 10_000_000 },
    { "Toko", 100_000_000}
};

yuli.TotalRevenue = yuli.TotalIncome(incomeYuli);

var incomeWidi = new Dictionary<string, decimal> {

    {"Kosan", 20_000_000 },
    { "Jualan Online", 6_000_000}
};

widi.TotalRevenue = widi.TotalIncome(incomeWidi);

var incomeRini = new Dictionary<string, decimal> {

    {"Supermarket", 50_000_000 },
    { "Rental Mobil", 40_000_000}
};

rini.TotalRevenue = rini.TotalIncome(incomeRini);

var incomeZuha = new Dictionary<string, decimal> {

    {"Skincare", 100_000_000 },
    { "Catering", 200_000_000}
};
zuha.TotalRevenue = zuha.TotalIncome(incomeZuha);

var incomeAhmad = new Dictionary<string, decimal> {

    {"Mall", 110_000_000 },
    { "Rental", 50_000_000}
};
ahmad.TotalRevenue = ahmad.TotalIncome(incomeAhmad);

var listOfCustomer = new List<Person> { yuli, widi, rini, zuha, ahmad };
foreach (var item in listOfCustomer)
{
    WriteLine(item);
}

WriteLine("\n==================================================== REVENUE HIGHEST ====================================================\n");
var listRange = listOfCustomer.Where(c => c.TotalRevenue >= 50_000_000);
foreach (var item in listRange)
{
    WriteLine(item.ToString());
}

var listMin = listOfCustomer.Min(x => x.TotalRevenue);
WriteLine($"Cust Min Revenue : {listMin}");

var listMax = listOfCustomer.Max(x => x.TotalRevenue);
WriteLine($"Cust Min Revenue : {listMax}");

var listLessThanMax = listOfCustomer.Where(x => x.TotalRevenue < listMax);

WriteLine("\n================================================= REVENUE LOWER THAN MAX =================================================\n");
foreach (var item in listLessThanMax)
{
    WriteLine(item.ToString());
}

WriteLine("\n======================================================== SELECT ========================================================\n");
var query = listOfCustomer.Select(cust =>
    new
    {
        fullName = cust.FirstName + " " + cust.LastName,
        Email = cust.Email,
        TotalRevenue = cust.TotalRevenue
    }
);

foreach (var item in query)
{
    WriteLine(item);
}

WriteLine("\n======================================================== LIST OWNER ========================================================\n");
var listOfOwner = new List<Person> { zuha, ahmad };
foreach (var item in listOfOwner)
{
    WriteLine(item);
}
//WriteLine("=================================== LINQ ===================================");
//inQ.IntroLinq();