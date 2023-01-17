using System;

namespace Project
{
    public class Program
    {     

        static void Main(string[] args)
        { 
            
            Player _player;
            Console.WriteLine("Please enter the player's name: ");
            string player_name = Console.ReadLine();
            Console.WriteLine("Please enter the player's description: ");
            string player_description = Console.ReadLine();
            _player = new Player(player_name, player_description);

           
            Item item1 = new Item(new string[] { "item1", "firstItem" },"Sword", "This is the first item" );
            Item item2 = new Item(new string[] { "item2", "secondItem" },"Spear", "This is the second item");
            _player.Inventory.Put(item1);
            _player.Inventory.Put(item2);

         
            Bag _bag = new Bag(new string[] { "playerBag", "bag" },"Player's bag", "This is the bag of the player" );
            _player.Inventory.Put(_bag);

           
            Item item3 = new Item(new string[] { "item3", "thirdItem" },"Shield", "This item is in the Player's bag" );
            _bag.Inventory.Put(item3);

           
            LookCommand _lookCommand = new LookCommand();
            while (true)
            {
                string user_command = Console.ReadLine();
                string[] command_array = user_command.Split(' ');
                string output = _lookCommand.Execute(_player, command_array);
                Console.WriteLine(output);
            }
        
        }
    }
}
