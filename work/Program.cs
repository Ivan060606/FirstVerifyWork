string search (string t)
    {
        string v = "";
        string m = (t);
        int len = t.Length;
        if (len < 4) 
        {
        return m;
        }
        else
        {
        return v;
        }
    }
void input(string h)
{
    Console.WriteLine("Введите строку: ");
    string o = Console.ReadLine();
    if (o != "")
        {
            if (search(o) != "")
            {
            h = h + " " + search(o);
            }
            input(h);
        }
    else
    {
        Console.Write(h);
    }
}
string z = "Ваши строки: ";
input(z);