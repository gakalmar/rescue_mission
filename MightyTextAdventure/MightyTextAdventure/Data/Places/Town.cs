﻿namespace MightyTextAdventure.Data.Places;
using MightyTextAdventure.Data.Player;
using MightyTextAdventure.UI;

public class Town : Area
{
    public override void Interaction(Player player)
    {
        Console.WriteLine("You encountered the fairy living in the woods.");
        Console.ReadLine();
        Console.WriteLine("She is asking you the following riddle:");
        Console.ReadLine();
        Console.WriteLine("`In the heart of the woods, under the moon's pale gaze,\n" +
                          "I dance without feet and sing without a voice.\n" +
                          "I can be captured but never held in your hands,\n" +
                          "I flicker with joy and vanish at dawn's first light.`");
        Console.ReadLine();
        Console.WriteLine("What am I?`");
        Console.WriteLine("[1] Starlight");
        Console.WriteLine("[2] Shadow");
        Console.WriteLine("[3] Wind");
        Console.WriteLine("[4] Mist");
        
        int input = int.Parse(_input.GetInputFromUser());
        
        if (input == 2)
        {
            Console.WriteLine("Congratulations, that is the correct answer!");
            Console.ReadLine();
            Console.WriteLine("You earned this 'Amulet of Protection'!");
            Console.ReadLine();
            player.Inventory.Add("Amulet of Protection");
            Console.WriteLine("'Amulet of Protection' was added to your inventory!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("I'm sorry, but that's not the right answer!");
            Console.WriteLine("*** The fairy vanished ***");
            Console.ReadLine();
        }
    }

    public Town(string description, Input input)
    {
        Description = description;
        ConnectedAreas = new List<Area>();
        _input = input;
    }
}