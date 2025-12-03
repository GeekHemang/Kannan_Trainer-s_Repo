using OcpRefactoredApp.Domain;
using OcpRefactoredApp.HDFC;
using OcpRefactoredApp.ICICBank;

FixedDeposit fd1 = new FixedDeposit(1, "Hemang", 100000, 10,new IcIcIQ1RatePolicy());
Console.WriteLine(fd1.SimpleInterest);