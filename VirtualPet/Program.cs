using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //global variables
            int action = 0;
            string petName = "";
            string firstName = "";

            //first do while is a menu that allows you to choose your pet
            do
            {
                Console.WriteLine("Welcome to Virtual Pet! \n\nTo begin you will choose a pet.");
                Console.WriteLine("\n\nWhich pet would you like to adopt?");
                Console.WriteLine("For Larry the Lion, please enter 1");
                Console.WriteLine("For Melvin the Monkey, please enter 2");
                Console.WriteLine("For Cletus the Camel, please enter 3");
                int name = int.Parse(Console.ReadLine());

                switch (name)
                {
                    case 1:
                        petName = "Larry the Lion";
                        firstName = "Larry";
                        Console.WriteLine("\a\aYou picked Larry the Lion! He's a wild beast... and I ain't lion...");
                        Console.WriteLine("");
                        Console.Title = "ASCII Art";
                        string title = @"
       ,  ,, ,
           , ,; ; ;;  ; ;  ;
        , ; ';  ;  ;; .-''\ ; ;
     , ;  ;`  ; ,; . / /8b \ ; ;
     `; ; .;'         ;,\8 |  ;  ;
      ` ;/   / `_      ; ;;    ;  ; ;
         |/.'  /9)    ;  ; `    ;  ; ;
        ,/'          ; ; ;  ;   ; ; ; ;
       /_            ;    ;  `    ;  ;
      `?8P.      ; ; ; ; ; ; ; ;
      | ;  .:: `     ; ; ; ;   `  ; ;
      `' `--._      ;;  ;;  ; ;   ;   ;
       `-..__..--''; ; ; ; ; ; ;
                        ; ; ; ; ; ;


                        ";

                        Console.WriteLine(title);
                        break;
                    case 2:
                        petName = "Melvin the Monkey";
                        firstName = "Melvin";
                        Console.WriteLine("\a\aYou picked Melvin the Monkey! You're bananas!");
                        Console.WriteLine("");
                        Console.Title = "ASCII Art";
                        title = @"
                      __------__
                    /~          ~\
                   |    //^\\//^\|            
                 /~~\  ||  o| |o|:~\      
                | |6   ||___|_|_||:|     
                 \__.  /      o  \/'     Please give me more  
                  |   (       O   )    /     BANANAS!!
         /~~~~\    `\  \         /
        | |~~\ |     )  ~------~`\
       /' |  | |   /     ____ /~~~)\
      (_/'   | | |     /'    |    ( |
             | | |     \    /   __)/ \
             \  \ \      \/    /' \   `\
               \  \|\        /   | |\___|
                 \ |  \____/     | |
                 /^~>  \        _/ <
                |  |         \       \
                |  | \        \        \
                -^-\  \       |        )
                     `\_______/^\______/


                        ";
                        Console.WriteLine(title); 
                        break;
                    case 3:
                        petName = "Cletus the Camel";
                        firstName = "Cletus";
                        Console.WriteLine("You picked Cletus the Camel! Don't ever dessert him.");
                        Console.WriteLine("");
                        Console.Title = "ASCII Art";
                        title = @"

                    ,.                         
           .           :%%%.    .%%%.             
       __%%%(\        `%%%%%   .%%%%%             
     /a  ^  '%        %%%% %: ,%  %%`            
    '__..  ,' %     .-%:     % -'    %              
     ~~ %:. `     % '          .   `.            
          %% % `   %%           .%:  . \.          
          %%:. `-'   `        .%% . %: :\         
          % (%,%...   `%,     %%'   %% ) )       
            %)%%)%% '   )%%%.....- '    / (         
             % a:f %%\ % / \`%  %%% `   / \))        
            %(%'  % /-. \      '  \ |-. '.       
            `'    |%   `()         \|  `()       
                  ||    /          ()   /        
                  ()   0            |  o          
                   \  /\ AF         o /           
                   o  `            /-|            
                ,-/ `           ,-/


";
                        Console.WriteLine(title);
                        break;
                    default:
                        Console.WriteLine("\a\aYou stink at following directions. Please try again. \nThe program will now close.");
                        return;

                }


                //creating pet object outside of the main do while loop
                MyPet petMe = new MyPet(70, 65, 30, 25);               

                //main do while loop loops the main menu and the tick method
                do
                {
                    Console.WriteLine("Press any key to see " + firstName + "'s current state.");
                    Console.ReadLine();
                    petMe.Tick();
                    Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("What would you like to do with " + petName + " ?\nPlease enter a number from the following list.\n\n");
                    Console.WriteLine("1: Feed " + firstName);
                    Console.WriteLine("2: Give " + firstName + " water");
                    Console.WriteLine("3: Play with " + firstName);
                    Console.WriteLine("4: Let " + firstName + " catch up on some sleep");
                    Console.WriteLine("5: Take " + firstName + " to go potty");
                    Console.WriteLine("6: Do nothing");
                    Console.WriteLine("7: Exit the game");
                    Console.WriteLine("0: Pick a new pet and restart the game");
                    action = int.Parse(Console.ReadLine());

                    switch (action)
                    {
                        case 1:
                            Console.WriteLine(firstName + petMe.Eat());
                            Console.WriteLine("");
                            break;

                        case 2:
                            Console.WriteLine(firstName + petMe.Drink());
                            Console.WriteLine("");
                            break;

                        case 3:
                            Console.WriteLine(firstName + " loves playing with you!");
                            petMe.Play();
                            break;

                        case 4:
                            petMe.Sleep();
                            break;

                        case 5:
                            Console.WriteLine("That smells...");
                            petMe.Potty();
                            break;

                        case 6:
                            break;

                    }

                } while ((action != 7) && (action != 0 ));
            } while (action == 0);

            //program thanks the user for using once the user decides to quit
            Console.WriteLine("Thank you for taking care of My Virtual Pet, " + petName + ". \nPlease come back soon! " +firstName + " and his friends will miss you.");



        }
    }
}
