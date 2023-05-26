using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    class IntFc
    {
        public void DrawEdges(int x1, int x2)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.SetCursorPosition(x1, i);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write('║');
            }
            for (int i = 0; i < 30; i++)
            {
                Console.SetCursorPosition(x2, i);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write('║');
            }
        }
        public void DrawHearts()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("♥   ♥   ♥");

        }
        public void UndrawHearts(int Heart)
        {
            Console.SetCursorPosition(0, 0);
            if (Heart == 1)
                Console.WriteLine(" ");
            if (Heart == 2)
                Console.WriteLine("       ");
            if (Heart == 3)
                Console.WriteLine("         ");
        }
        public void GameOver()
        {
            System.Media.SoundPlayer GO = new System.Media.SoundPlayer(@"C:\Users\IDAN\Desktop\AI\sound effects\over.wav");
            GO.Play();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"                                    
                                        ███▀▀▀██ ███▀▀▀███ ███▀█▄█▀███ ██▀▀▀
                                        ██    ██ ██     ██ ██   █   ██ ██   
                                        ██   ▄▄▄ ██▄▄▄▄▄██ ██   ▀   ██ ██▀▀▀
                                        ██    ██ ██     ██ ██       ██ ██   
                                        ███▄▄▄██ ██     ██ ██       ██ ██▄▄▄
                                    
                                        ███▀▀▀███ ▀███  ██▀ ██▀▀▀ ██▀▀▀▀██▄ 
                                        ██     ██   ██  ██  ██    ██     ██ 
                                        ██     ██   ██  ██  ██▀▀▀ ██▄▄▄▄▄▀▀ 
                                        ██     ██   ██  █▀  ██    ██     ██ 
                                        ███▄▄▄███   ─▀█▀  ─ ██▄▄▄ ██     ██▄
                                    
                                                ██               ██         
                                              ████▄   ▄▄▄▄▄▄▄   ▄████       
                                                 ▀▀█▄█████████▄█▀▀          
                                                   █████████████            
                                                   ██▀▀▀███▀▀▀██            
                                                   ██   ███   ██            
                                                   █████▀▄▀█████            
                                                    ███████████             
                                                ▄▄▄██  █▀█▀█  ██▄▄▄         
                                                ▀▀██           ██▀▀         
                                                  ▀▀           ▀▀         

                                    ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(@"
                   ██████  ██       █████  ██    ██      █████   ██████   █████  ██ ███    ██ ██████  
                   ██   ██ ██      ██   ██  ██  ██      ██   ██ ██       ██   ██ ██ ████   ██      ██ 
                   ██████  ██      ███████   ████       ███████ ██   ███ ███████ ██ ██ ██  ██   ▄███  
                   ██      ██      ██   ██    ██        ██   ██ ██    ██ ██   ██ ██ ██  ██ ██   ▀▀    
                   ██      ███████ ██   ██    ██        ██   ██  ██████  ██   ██ ██ ██   ████   ██   ");
        }
        public bool Menu()
        {
            bool OnExit = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@"


                                          /$$$$$$                                                /$$$$$$                                     /$$                              
                                         /$$__  $$                                              |_  $$_/                                    | $$                              
                                        | $$  \__/  /$$$$$$   /$$$$$$   /$$$$$$$  /$$$$$$         | $$   /$$$$$$$  /$$    /$$ /$$$$$$   /$$$$$$$  /$$$$$$   /$$$$$$   /$$$$$$$
                                        |  $$$$$$  /$$__  $$ |____  $$ /$$_____/ /$$__  $$        | $$  | $$__  $$|  $$  /$$/|____  $$ /$$__  $$ /$$__  $$ /$$__  $$ /$$_____/
                                        \____  $$| $$  \ $$  /$$$$$$$| $$      | $$$$$$$$        | $$  | $$  \ $$ \  $$/$$/  /$$$$$$$| $$  | $$| $$$$$$$$| $$  \__/|  $$$$$$ 
                                        /$$  \ $$| $$  | $$ /$$__  $$| $$      | $$_____/        | $$  | $$  | $$  \  $$$/  /$$__  $$| $$  | $$| $$_____/| $$       \____  $$
                                        |  $$$$$$/| $$$$$$$/|  $$$$$$$|  $$$$$$$|  $$$$$$$       /$$$$$$| $$  | $$   \  $/  |  $$$$$$$|  $$$$$$$|  $$$$$$$| $$       /$$$$$$$/
                                         \______/ | $$____/  \_______/ \_______/ \_______/      |______/|__/  |__/    \_/    \_______/ \_______/ \_______/|__/      |_______/ 
                                                  | $$                                                                                                                        
                                                  | $$                                                                                                                        
                                                   |__/                                          


               ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(@"



                                                                                ██████  ██████████  ████████  ████████  ██████████    
                                                                              ██            ██      ██    ██  ██    ██      ██        
                                                                              ████████      ██      ████████  ████████      ██        
                                                                                    ██      ██      ██    ██  ██  ██        ██        
                                                                              ████████      ██      ██    ██  ██    ██      ██   

                    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"





                                                                                           ________   _______ _______ 
                                                                                          |  ____\ \ / /_   _|__   __|
                                                                                          | |__   \ V /  | |    | |   
                                                                                          |  __|   > <   | |    | |   
                                                                                          | |____ / . \ _| |_   | |   
                                                                                          |______/_/ \_\_____|  |_|                                                                               ");
            ;
            ConsoleKeyInfo ky = Console.ReadKey();
            while (ky.Key != ConsoleKey.Enter)
            {
                ky = Console.ReadKey();
                if (OnExit && ky.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(@"


                                          /$$$$$$                                                /$$$$$$                                     /$$                              
                                         /$$__  $$                                              |_  $$_/                                    | $$                              
                                        | $$  \__/  /$$$$$$   /$$$$$$   /$$$$$$$  /$$$$$$         | $$   /$$$$$$$  /$$    /$$ /$$$$$$   /$$$$$$$  /$$$$$$   /$$$$$$   /$$$$$$$
                                        |  $$$$$$  /$$__  $$ |____  $$ /$$_____/ /$$__  $$        | $$  | $$__  $$|  $$  /$$/|____  $$ /$$__  $$ /$$__  $$ /$$__  $$ /$$_____/
                                        \____  $$| $$  \ $$  /$$$$$$$| $$      | $$$$$$$$        | $$  | $$  \ $$ \  $$/$$/  /$$$$$$$| $$  | $$| $$$$$$$$| $$  \__/|  $$$$$$ 
                                        /$$  \ $$| $$  | $$ /$$__  $$| $$      | $$_____/        | $$  | $$  | $$  \  $$$/  /$$__  $$| $$  | $$| $$_____/| $$       \____  $$
                                        |  $$$$$$/| $$$$$$$/|  $$$$$$$|  $$$$$$$|  $$$$$$$       /$$$$$$| $$  | $$   \  $/  |  $$$$$$$|  $$$$$$$|  $$$$$$$| $$       /$$$$$$$/
                                         \______/ | $$____/  \_______/ \_______/ \_______/      |______/|__/  |__/    \_/    \_______/ \_______/ \_______/|__/      |_______/ 
                                                  | $$                                                                                                                        
                                                  | $$                                                                                                                        
                                                   |__/                                          


               ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(@"



                                                                                ██████  ██████████  ████████  ████████  ██████████    
                                                                              ██            ██      ██    ██  ██    ██      ██        
                                                                              ████████      ██      ████████  ████████      ██        
                                                                                    ██      ██      ██    ██  ██  ██        ██        
                                                                              ████████      ██      ██    ██  ██    ██      ██   

                    ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(@"





                                                                                           ________   _______ _______ 
                                                                                          |  ____\ \ / /_   _|__   __|
                                                                                          | |__   \ V /  | |    | |   
                                                                                          |  __|   > <   | |    | |   
                                                                                          | |____ / . \ _| |_   | |   
                                                                                          |______/_/ \_\_____|  |_|                                                                             
                    ");
                }
                else if (!OnExit && ky.Key == ConsoleKey.DownArrow)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(@"


                                          /$$$$$$                                                /$$$$$$                                     /$$                              
                                         /$$__  $$                                              |_  $$_/                                    | $$                              
                                        | $$  \__/  /$$$$$$   /$$$$$$   /$$$$$$$  /$$$$$$         | $$   /$$$$$$$  /$$    /$$ /$$$$$$   /$$$$$$$  /$$$$$$   /$$$$$$   /$$$$$$$
                                        |  $$$$$$  /$$__  $$ |____  $$ /$$_____/ /$$__  $$        | $$  | $$__  $$|  $$  /$$/|____  $$ /$$__  $$ /$$__  $$ /$$__  $$ /$$_____/
                                        \____  $$| $$  \ $$  /$$$$$$$| $$      | $$$$$$$$        | $$  | $$  \ $$ \  $$/$$/  /$$$$$$$| $$  | $$| $$$$$$$$| $$  \__/|  $$$$$$ 
                                        /$$  \ $$| $$  | $$ /$$__  $$| $$      | $$_____/        | $$  | $$  | $$  \  $$$/  /$$__  $$| $$  | $$| $$_____/| $$       \____  $$
                                        |  $$$$$$/| $$$$$$$/|  $$$$$$$|  $$$$$$$|  $$$$$$$       /$$$$$$| $$  | $$   \  $/  |  $$$$$$$|  $$$$$$$|  $$$$$$$| $$       /$$$$$$$/
                                         \______/ | $$____/  \_______/ \_______/ \_______/      |______/|__/  |__/    \_/    \_______/ \_______/ \_______/|__/      |_______/ 
                                                  | $$                                                                                                                        
                                                  | $$                                                                                                                        
                                                   |__/                                          


               ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(@"



                                                                                ██████  ██████████  ████████  ████████  ██████████    
                                                                              ██            ██      ██    ██  ██    ██      ██        
                                                                              ████████      ██      ████████  ████████      ██        
                                                                                    ██      ██      ██    ██  ██  ██        ██        
                                                                              ████████      ██      ██    ██  ██    ██      ██   

                    ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(@"





                                                                                           ________   _______ _______ 
                                                                                          |  ____\ \ / /_   _|__   __|
                                                                                          | |__   \ V /  | |    | |   
                                                                                          |  __|   > <   | |    | |   
                                                                                          | |____ / . \ _| |_   | |   
                                                                                          |______/_/ \_\_____|  |_|                                                                               ");
                }
            }
            return OnExit;


        }
    }

}
    

