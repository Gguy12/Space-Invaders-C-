using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace AI
{
    class AAMain
    {
        static void Main(string[] args)
        {
            Start:
            Console.SetWindowSize(130, 30);
            IntFc Interface = new IntFc();
            Console.CursorVisible = false;
            //if(Interface.Menu())
           // {
              //  goto exit;
            //}
            
               
            int levels = 1;
        StartGame:
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            
            bool autofire = false;
            System.Media.SoundPlayer Shoot = new System.Media.SoundPlayer(@"C:\Users\IDAN\Desktop\AI\sound effects\shoot.wav");
            PlayerShip ship = new PlayerShip();
            
            ship.Draw();
            Swarm sw = new Swarm(levels);
            
            Interface.DrawEdges(21, 104);
            bool right = true;
            sw.Draw();
            int FrameCount = 0;
            int lives = 1;
            Interface.DrawHearts();
            bool Game = true;
            while (Game)
            {

                FrameCount++;
                if (sw.TryToKillAlien(ship.GetBuletX(), ship.GetBuletY()))
                {
                    ship.UndrawBul();
                    ship.SetBUllety(27);
                    ship.SetBUlletx(ship.GetCurBltX());
                    ship.SetIsShooting(false);
                    sw.DecCount();

                }
                if (FrameCount % (sw.GetCount()) == 0)
                {
                    if (right)
                    {
                        sw.MoveRight();
                        if (sw.GetRightX() >= 99)
                        {
                            sw.MoveDown();
                            right = false;
                        }
                    }

                    else if (!right)
                    {
                        sw.MoveLeft();
                        if (sw.GetLeftX() <= 25)
                        {
                            sw.MoveDown();
                            right = true;
                        }
                    }
                }


                int x = ship.GetBuletX();
                int y = ship.GetBuletY();
                
                if (Console.KeyAvailable)
                {

                    ConsoleKeyInfo k = Console.ReadKey(true);
                    if (k.Key == ConsoleKey.RightArrow && ship.GetShipRightx() <= 98)
                    {

                        ship.MoveRight();
                    }

                    if (k.Key == ConsoleKey.LeftArrow && ship.GetShipLeftX() >= 23)
                    {
                        ship.MoveLeft();
                    }
                    if (k.Key == ConsoleKey.Spacebar)
                    {
                        if (!ship.GetIsShooting())
                            ship.SetIsShooting(true)
                        ;
                        if (ship.GetBuletY() <= 3)//add an && 2 if i hit the alien
                        {
                            ship.SetBUllety(22);
                            ship.SetIsShooting(false);

                        }
                    }
                    if (k.Key == ConsoleKey.A)
                    {
                        if (autofire)
                            autofire = false;
                        else
                            autofire = true;
                    }
                    if (k.Key == ConsoleKey.N)
                    {
                        System.Media.SoundPlayer rick = new System.Media.SoundPlayer(@"C:\Users\IDAN\Desktop\AI\sound effects\NEVER.wav");
                        rick.Play();
                    }



                }
                if (ship.GetIsShooting() || autofire)
                {
                    ship.Shoot();
                    

                }
                if (ship.GetBuletY() <= 1)
                {
                    ship.UndrawBul();
                    ship.SetBUllety(27);
                    ship.SetBUlletx(ship.GetCurBltX());
                    ship.SetIsShooting(false);

                }
                
                if (ship.GetBuletY() == 26)
                {
                    Shoot.Play();
                }
                if (!sw.GetIsShooting())
                    sw.StartShooting();
                sw.Shoot();
                sw.ReDraw();
                sw.TryStopShooting();
                sw.TryStopShooting(ship);
                if(sw.TryToKillPlayer(ship))
                {
                    ship.UnDraw();
                    Interface.UndrawHearts(lives);
                    lives++;
                    Thread.Sleep(200);
                }
                while (Console.KeyAvailable)
                    Console.ReadKey(true);
                if (FrameCount % 50 == 0)
                    Interface.DrawEdges(21, 104);
                if(lives == 4)
                {
                    Interface.GameOver();
                    Thread.Sleep(3000);
                    Game = false;

                    
                }
                if(sw.GetCount() == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"










                                            $$\      $$\ $$$$$$\ $$\   $$\ $$\   $$\ $$$$$$$$\ $$$$$$$\  
                                            $$ | $\  $$ |\_$$  _|$$$\  $$ |$$$\  $$ |$$  _____|$$  __$$\ 
                                            $$ |$$$\ $$ |  $$ |  $$$$\ $$ |$$$$\ $$ |$$ |      $$ |  $$ |
                                            $$ $$ $$\$$ |  $$ |  $$ $$\$$ |$$ $$\$$ |$$$$$\    $$$$$$$  |
                                            $$$$  _$$$$ |  $$ |  $$ \$$$$ |$$ \$$$$ |$$  __|   $$  __$$< 
                                            $$$  / \$$$ |  $$ |  $$ |\$$$ |$$ |\$$$ |$$ |      $$ |  $$ |
                                            $$  /   \$$ |$$$$$$\ $$ | \$$ |$$ | \$$ |$$$$$$$$\ $$ |  $$ |
                                            \__/     \__|\______|\__|  \__|\__|  \__|\________|\__|  \__
");
                    Thread.Sleep(500000);
                    goto exit;
                }
                Thread.Sleep(50);

            }
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
                goto StartGame;
            else
                goto Start;

            exit:
            Console.Clear();




        }


    }

}
