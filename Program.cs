using System;

class Program
{
    static void Main(string[] args)
    {
        AddressManager manager = new AddressManager();
        bool running = true;

        while (running)
        {
            Menu.ShowMenu(manager, ref running);
        }
    }
}
