
using SRPRefactored.Domain;
using SRPRefactored.Presentation;

var starBucksInvoice = new Invoice(1, "Star bucks", 1000, .20);
InvoiceFilePrinter.PrintInvoice(starBucksInvoice);


