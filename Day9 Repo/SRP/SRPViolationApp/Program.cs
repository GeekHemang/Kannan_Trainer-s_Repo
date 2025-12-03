
using SRPViolationApp.Domain;

class Program
{
    static void Main() {


        var foodInvoice = new Invoice(1, "MacD ", 100, .20);
        foodInvoice.PrintInvoice();

      
    }

    

}
