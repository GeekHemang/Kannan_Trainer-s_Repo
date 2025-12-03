
using ISPRefactored.Domain;

void AtCafeteria(ICanDoEat worker)
{
    Console.WriteLine("At the cafeteria");
    worker.StartEat();
    worker.StopEat();
}

void AtTheWorkStation(ICanDoWork worker)
{
    Console.WriteLine("At the workstation");
    worker.StartWork();
    worker.StopWork();
}

var manager1 = new Manager();
var bot1 = new Robot();

AtCafeteria(manager1);
AtCafeteria(bot1);// violation of LSP

AtTheWorkStation(manager1);
AtTheWorkStation(bot1);

