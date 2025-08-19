Console.WriteLine("Generating Invoices for customer \"Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

//verbatim string literal
Console.WriteLine(@"     c:\source\invoices");

//unicode
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
//to generate japanese invoice
Console.WriteLine("\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
//user command
Console.WriteLine(@"c:\invoice\app.exe -j");
