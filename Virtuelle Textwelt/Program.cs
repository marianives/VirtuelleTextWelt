using System;

namespace Virtuelle_Textwelt
{
    class Program
    { 
        static void Main(string[] args)
        {
            string Title = "\r\n" + 
"████████╗██╗  ██╗███████╗    ███╗   ███╗██╗███████╗████████╗███████╗██████╗ ██╗   ██╗     ██████╗ ███████╗     ██████╗  █████╗ ██████╗ ██████╗  █████╗ ███╗   ██╗██╗ █████╗ " +
"╚══██╔══╝██║  ██║██╔════╝    ████╗ ████║██║██╔════╝╚══██╔══╝██╔════╝██╔══██╗╚██╗ ██╔╝    ██╔═══██╗██╔════╝    ██╔════╝ ██╔══██╗██╔══██╗██╔══██╗██╔══██╗████╗  ██║██║██╔══██╗" +
"   ██║   ███████║█████╗      ██╔████╔██║██║███████╗   ██║   █████╗  ██████╔╝ ╚████╔╝     ██║   ██║█████╗      ██║  ███╗███████║██████╔╝██║  ██║███████║██╔██╗ ██║██║███████║" +
"   ██║   ██╔══██║██╔══╝      ██║╚██╔╝██║██║╚════██║   ██║   ██╔══╝  ██╔══██╗  ╚██╔╝      ██║   ██║██╔══╝      ██║   ██║██╔══██║██╔══██╗██║  ██║██╔══██║██║╚██╗██║██║██╔══██║" +
"   ██║   ██║  ██║███████╗    ██║ ╚═╝ ██║██║███████║   ██║   ███████╗██║  ██║   ██║       ╚██████╔╝██║         ╚██████╔╝██║  ██║██║  ██║██████╔╝██║  ██║██║ ╚████║██║██║  ██║" +
"   ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝     ╚═╝╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝   ╚═╝        ╚═════╝ ╚═╝          ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝╚═╝  ╚═╝\r\n";
            string CharacterName = "Blaire";

           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("(First press Enter\r\nto start the Game)");
            Console.WriteLine("\r\n" +
                "\r\n" +
                "\r\n" +
                "Then please adapt this Window, so that you can read the title: THE MISTERY OF GARDANIA right"
                +  "\r\n" + "you may have to scroll up a bit");
            Console.ReadLine();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(Title);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(
"                                                                                         o\r\n"+
"                                                                                       o   o\r\n" +
"                                                                                       o   o\r\n" +
"                                                                                        ooo\r\n" +
"                                                                                        o o\r\n" +
"                                                                                       o   o\r\n" +
"                                                                 oo $$$   oo$  ooo    o     o    ooo $oo  $$$ o\r\n" +
"                                                    o o o      oo   o        o    $$o$      o o$    o$       $   oo   o o o o\r\n" +
"                                                     o      o$$   $          $          o         o           $    o$$     o\r\n" +
"                                                       o       o  $           $        $$$$$      o           $  ooo    o \r\n" +
"                                                         o   $$$$o $o       o$         $$$$$       o          $$$$   o\r\n" +
"                                                          o $$$$o  oo o  o$            $$$$$         o o o o   $$$$ o\r\n" +
"                                                            $                            $                         $\r\n" +
"                                                            oooooooooooooooooooooooooooooooooooooooooooooooooooooo$\r\n" +
"                                                             $$$$ $$$$  $$$$$$$ $$$$$$    $$$$$ $$$$$$   $$$  $$$$\r\n" +
"                                                             $$$oo$$$$   $$$$$$o$$$$$$   $$$$$$$$$$$$$$ o$$$$o$$$$\r\n" +
"                                                             $                                                   $\r\n" +
"                                                             $                                                   $\r\n" +
"                                                             $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" \r\n" +
                " \r\n" +
                "                                                                                    Welcome!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("What name do you want to give your character?");
            CharacterName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(Title);
            Console.WriteLine("Wonderful! Your character is now named " + CharacterName + "!" );
            Console.WriteLine("Let's start! \r\n \r\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("You are 17 years old, with pale skin, blue eyes, and long blonde hair.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(CharacterName + " Willows, a regular girl who lives in a slum of the kingdom of Gardania.\r\n" +
                "She works as a café waitress to earn her family money.\r\n");
            Console.WriteLine("She lives with her adoptive mother, who is ill, and her adopted sister, Emily, \r\n" +
                "who loves watching the annual Princess Procession, a televised event where\r\n " +
                "princesses and Lady Royals \r\n" +
                "from different kingdoms arrive in Gardania to attend Princess Charm School. \r\n" +
                "The Princess Charm School's aim is to teach princesses and lady royals how to fulfill their princess potential. \r\n" +
                "Every year, there is a lottery in which a commoner's name is chosen and if they graduate, they can be chosen as a Lady Royal.\r\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("\r\nAfter Emily enters your name several times in the lottery, your name is picked out and almost immediately,\r\n" +
                CharacterName + " is taken to the Princess Charm School.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("Suddenly a well dressed stranger appears");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("Brock: ");
            Console.ReadLine();
            Console.WriteLine("“Hello!\r\n" +
                "You don’t have to take anything with you, you will find everything you need in the Academy.\r\n" +
                "Say goodbye to your family, you won’t see them for a year!”");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("(Choose an option)");
            Console.WriteLine("\r\n" +
                "                                                            … S a y  g o o d b y e   t o   y o u r   f a m i l y …");
            Console.WriteLine("\r\n" +
                "\r\n" +
                "                                                            1 Goodbye Emily, goodbye Mum, I love you!\r\n" +
                "                                                            2 Goodbye Fam, hopefully I won’t see you again!\r\n" +
                "                                                            3 Thank you Emily, take care of our mother, goodbye mom, Love You\r\n");
            Choice("                                                            Mum: Goodbye,\r\n" + CharacterName + " have fun!",
                "                                                            You are a very rude person! Be nicer to your family next time!",
                "                                                            Mum: Goodbye "+ CharacterName + ", have fun, we love you!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("In the School you meet a dog named Prince who seems to recognize you somehow. \r\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine  ( "Isn’t it weird? ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("\r\n" +
                "\r\n" +
                "                                                            … P r i n c e   w a n t s   t o   p l a y   w i t h   y o u … ");
            Console.WriteLine("\r\n" +
                "\r\n" +
                "                                                            1 Cuddle and pet him\r\n" +
                "                                                            2 Throw the ball and let him bring it back\r\n" +
                "                                                            3 Walk away\r\n");
            Choice("                                                            He really liked your cuddling",
                   "                                                            He ran after the ball and doesn't come back",
                   "                                                            Prince was sad when you walked away");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("Arrived at the palace, are you given a tour by the Headmistress Privet.\r\n"+
                "Later you receive your school uniform from a sprite named Grace, who is your personal assistant.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("                                                           … C h o o s e   y o u r   u n i f o r m …");
            Console.WriteLine("\r\n" +
                "                                                            1 white shirt, blue vest, pink tie\r\n" +
                "                                                            2 pink shirt, white vest, blue tie\r\n" +
                "                                                            3 white shirt, green vest, blue tie\r\n");
            Choice("                                                            You changed your regular clothes to a white shirt with a blue vest and a pink tie",
                   "                                                            You changed your regular clothes to a pink shirt with a white vest and a blue tie",
                   "                                                            You changed your regular clothes to a white shirt with a green vest and a blue tie");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("By mistake you bump into Delancy, the future princess of Gardania,\r\n" +
                "who acts mean towards you as she doesn't think you deserve to be at this school.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("You ignored her and meet two princesses, Isla and Hadley.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("                                                            … I n t r o d u c e    y o u r s e l f    t o    H a d l e y    a n d     I s l a …");
            Console.WriteLine("\r\n" +
               "\r\n" +
               "                                                            1 Hello, my name is " + CharacterName + ", how are you? \r\n" +
               "                                                            2 Hii, oh your dresses are so beautiful! My name is " + CharacterName + " I hope we'll have it well.\r\n" +
               "                                                            3 Hey what’s poppin’? I’m " + CharacterName + "\r\n");
            Choice("                                                            Nice to meet you, I’m Hadley and this is Isla.",
                    "                                                            Hey, thank you.You’ll get one too, for sure.",
                    "                                                            Wassup, I’m Hadley and this is Isla.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("After a long talk you three become best friends.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("They support you even when Delancy and her mother and your teacher,\r\n" +
                "Dame Devin, are rude to you.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("During a dance lesson, you pair up with a prince named Nicholas.\r\n" +
                "He kisses your hand and you begin the reverence.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("\r\n"
               + "Prince Nicholas:");
            Console.ReadLine();
            Console.WriteLine("“Milady, I am Nicholas, young swain from the east, most privileged to make your acquaintance!”");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("                                                         … T a l k   a   l i t l e   b i t   w i t h    P r i n c e    N i c h o l a s …");
            Console.ReadLine();
            Console.WriteLine("                                                            Write what you want to say to Prince Nicholas (be kind and use appropriate words):\r\n");
            Console.ReadLine();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("You two get along well.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("During another lesson, Dame Devine notices that you resemble the queen,");
            Console.ReadLine();
            Console.WriteLine("who was killed in the car crash with the rest of the royal family\r\n" +
                "and recognizes you as Queen Isabella's daughter,");
            Console.ReadLine();
            Console.WriteLine("Princess Sophia,");
            Console.ReadLine();
            Console.WriteLine("who was already suspected to still be alive.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("She is shocked.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("And from that day onwards,\r\n" +
                "she tries everything she can to get you kicked out of school");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine("TO BE CONTINUED... \r\n "
                + "\r\n" +
                "\r\n" +
                 "\r\n" +
                  "\r\n" +
                "press 2x ENTER to close the game");







            Console.ReadKey();

           
        }
        static void Choice(string text1, string text2, string text3)
        {
            string input = "";

            input = Console.ReadLine();


            if (input == "1")
            {
                Console.WriteLine(text1);
            }
            if (input == "2")
            {
                Console.WriteLine(text2);
            }
            if (input == "3")
            {
                Console.WriteLine(text3);

                Console.ReadKey();
            }
        }
    }
}
        
       

