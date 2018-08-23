using System;
using System.Collections.Generic;

class Program {
    static void Main () {
        HashSet<string> showroom = new HashSet<string> ();

        showroom.Add ("Model S");
        showroom.Add ("Model 3");
        showroom.Add ("Model X");

        Console.WriteLine (showroom.Count);

        showroom.Add ("Model X");

        Console.WriteLine (showroom.Count);

        HashSet<string> UsedLot = new HashSet<string> ();
        UsedLot.Add ("Civic");
        UsedLot.Add ("F150");

        showroom.UnionWith (UsedLot);
        Console.WriteLine (showroom.Count);

        showroom.Remove ("F150");
        Console.WriteLine (showroom.Count);

        HashSet<string> Junkyard = new HashSet<string> ();
        Junkyard.Add ("Model 3");
        Junkyard.Add ("Model X");
        Junkyard.Add ("Nissan Versa");
        Junkyard.Add ("Nissan Altima");

        HashSet<string> clone = new HashSet<string> (showroom);
        Console.WriteLine (clone.Count);
        clone.IntersectWith(Junkyard);
        Console.WriteLine (clone.Count);

        showroom.UnionWith(Junkyard);
        Console.WriteLine (showroom.Count);

        showroom.Remove("Model 3");
        showroom.Remove("Model X");
        Console.WriteLine (showroom.Count);
    }

}