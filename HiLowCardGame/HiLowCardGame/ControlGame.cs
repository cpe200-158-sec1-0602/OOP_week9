using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class ControlGame
    {
        static Player player1 = new Player("Gibson");
        static Player player2 = new Player("P.");
       
        public static void SetUp()
        {
            
            int rand ;
            Random inrand = new Random();
            int count=0,count1=0;

            for(int i = 0;i<13;i++)
                for(int j = 0;j<4;j++)
                {
                    rand = inrand.Next(0, 2);

                    if (((rand==0)&&(player1.Deck.Count!=26))||((rand==1)&&(player2.Deck.Count==26)))
                        player1.SetUpDeck(i, j);
                    else
                        player2.SetUpDeck(i, j);
                }

            player1.shuffle();
            player2.shuffle();

            Console.WriteLine("\nPlayer1's Dack : " +player1.Name);
            player1.PrintDeck();

            Console.WriteLine("\nPlayer2's Dack : " + player2.Name);
            player2.PrintDeck();

           
            



        } 

        public static void Playing()
        {
            bool exit = false;
            Card swap = new Card(0,0);
            do
            {
                if (player1.Deck[0].Value < player2.Deck[0].Value)
                {
                    Console.WriteLine("\n"+player1.Deck[0] + ">" + player2.Deck[0]);
                    player1.addPile(player1.Deck[0]);
                    player1.addPile(player2.Deck[0]);
                    player1.delDeck(0);
                    player2.delDeck(0);

                    Console.WriteLine("\nPlayer1's Deck (WIN): " + player1.Name);
                   // player1.PrintDeck();
                    //player1.PrintPile();



                }
                else if (player1.Deck[0].Value > player2.Deck[0].Value)
                {
                    Console.WriteLine("\n" + player1.Deck[0] + "<" + player2.Deck[0]);
                    player2.addPile(player1.Deck[0]);
                    player2.addPile(player2.Deck[0]);
                    player1.delDeck(0);
                    player2.delDeck(0);

                    Console.WriteLine("\nPlayer2's Dack (WIN): " + player2.Name);
                   // player2.PrintDeck();
                   // player2.PrintPile();


                }
                else
                {
                    int index;

                    do
                    {
                        if (player1.Deck.Count == 1)
                        {
                            exit = true;
                            Console.WriteLine("!!");
                            break;
                        }
                        else if(player1.Deck.Count == 2)
                        {
                            swap = player1.Deck[0];
                            player1.Deck[0]=player1.Deck[1];
                            player1.Deck[1] = swap;
                            break;
                        }

                        player1.shuffle();
                        player2.shuffle();
                        

                        if (player1.Deck.Count < 5)
                            index = player1.Deck.Count - 1;
                        else if (player2.Deck.Count < 5)
                            index = player2.Deck.Count - 1;
                        else
                            index = 4;



                        //Console.WriteLine("index = "+index);


                        if (player1.Deck[index].Value < player2.Deck[index].Value)
                        {
                            Console.WriteLine("\n[=]" + player1.Deck[index] + ">" + player2.Deck[index]);

                            for (int i = 0; i <= index; i++)
                            {
                                player1.addPile(player1.Deck[0]);
                                player1.addPile(player2.Deck[0]);
                                player1.delDeck(0);
                                player2.delDeck(0);

                            }



                            Console.WriteLine("\nPlayer1's Deck (WIN): " + player1.Name);
                           // player1.PrintDeck();
                           // player1.PrintPile();
                            break;


                        }
                        else if (player1.Deck[index].Value > player2.Deck[index].Value)
                        {
                            Console.WriteLine("\n[=]" + player1.Deck[index] + "<" + player2.Deck[index]);

                            for (int i = 0; i <= index; i++)
                            {
                                player2.addPile(player1.Deck[0]);
                                player2.addPile(player2.Deck[0]);
                                player1.delDeck(0);
                                player2.delDeck(0);

                            }

                            Console.WriteLine("\nPlayer2's Dack (WIN): " + player2.Name);
                           // player2.PrintDeck();
                           // player2.PrintPile();
                            break;

                        }
                       

                    } while (true);


                }

                Console.WriteLine("Deck = "+player1.Deck.Count);
                //player1.PrintDeck();
                //Console.WriteLine("Deck2 = " + player2.Deck.Count);
                //player2.PrintDeck();
                Console.WriteLine("Pile1=" + player1.Pile.Count);
                Console.WriteLine("Pile2=" + player2.Pile.Count);
                Console.WriteLine("Exit=" + exit);
                player1.PrintDeck();
                player2.PrintDeck();
                Console.WriteLine("------------------------------------");

                if (exit) break;

            } while (player1.Deck.Count != 0 && player2.Deck.Count != 0 );

           Console.WriteLine("END GAME");
            if (player1.Pile.Count > player2.Pile.Count)
                Console.WriteLine(player1.Name + "(player1) IS THE WINNER.");
            else if (player1.Pile.Count == player2.Pile.Count)
                Console.WriteLine("DONT HAVE THE WINNER.");
            else
                Console.WriteLine(player2.Name + "(player2) IS THE WINNER.");

            Console.WriteLine("Pile1="+player1.Pile.Count);
            Console.WriteLine("Pile2=" + player2.Pile.Count);

            //if(player1.Deck.Count>0)
            {
                
            }

            
            }



        }

        
    
}
