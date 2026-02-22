try
{
    Console.Write("Shomare Fasl: ");
    var fasl=int.Parse(Console.ReadLine()??"0");
    if (fasl==1)
    {
        Console.WriteLine("Bahar");
    }
    if (fasl==2)
    {
        Console.WriteLine("Tabestan");
    }
    if (fasl==3)
    {
        Console.WriteLine("Paeez");
    }
    if (fasl==4)
    {
        Console.WriteLine("Zemestan");

    }
    if (fasl<1 || fasl>4)
    {
        Console.WriteLine("Nadarim");
    }
}
catch 
{
    
    Console.WriteLine("Error");
}
