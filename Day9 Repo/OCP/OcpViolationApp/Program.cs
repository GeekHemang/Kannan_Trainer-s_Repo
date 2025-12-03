
using OcpViolationApp.Domain;

FixedDeposit fd1 = new FixedDeposit(1, "Hemang", 100000,10, FestivalOptions.NewYear);
Console.WriteLine(fd1.SimpleInterest);


foreach (var item in fd1) { 
}

