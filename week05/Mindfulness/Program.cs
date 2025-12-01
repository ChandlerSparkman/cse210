using System;

class Program
{
    static void Main(string[] args)
    {
        ListingActivity baseActivity = new ListingActivity("Base Activity", "Just the base activity for testing", 1);

        baseActivity.Run();
    }
}