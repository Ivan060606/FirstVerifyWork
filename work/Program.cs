// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void input(string h)
{
    Console.WriteLine("Введите строку: ");
    string o = Console.ReadLine();
    if (o != "")
        {
            if (o != "")
            {
                if (o.length<4)
                {
                    h = h + " " + search(o);
                }
            }
            input(h);
        }
    else
    {
        Console.Write(h + " ");
    }
}
string z = "";
input(z);