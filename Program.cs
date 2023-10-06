 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TextAdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                WriteLine("Enter username.");
                string username = ReadLine();
                WriteLine("Hello " + username + " Would you like to play a game?(yes/no)");
                string answer = ReadLine();
                if (answer.ToLower() == "yes")
                {
                    WriteLine("Welcome to the Enchanted Library, where ancient tomes and dusty scrolls hold untold mysteries within the house's ancient walls.\nThe air is thick with the scent of parchment, and dim light dances upon countless shelves.\n As you step deeper into this mystical chamber, the books themselves seem to call out, their spines adorned with cryptic languages. \nYour journey awaits, beckoning you to explore, decipher, and immerse yourself in the enchanting narratives hidden within these pages. \nWill you be the one to unveil the secrets and embark on this thrilling adventure? \nThe choice is yours, so let your curiosity guide you into the heart of the unknown. \nYour adventure in the Enchanted Library is about to begin!");

                    WriteLine("\r\n\r\nWould you like to enter the house alone, or would you prefer to bring a friend along for this mysterious journey?\n Select 1 to enter alone or 2 to enter with a friend.");
                    int enter_house = Convert.ToInt32(ReadLine());
                    if (enter_house == 1)
                    {
                        WriteLine("\r\nSorry, brave adventurer," + username + "Your journey has come to end as one cannot take on the Enchanted Libary within this house of magic and fantasy by themself.");
                    }
                    else if (enter_house == 2)
                    {
                        WriteLine("\r\nInside the house, you discover an immense library filled with ancient tomes and scrolls.\n Each book seems to contain a different world or story. \nAs you and your friend explore, you come across a particularly intriguing book titled \"The Dragon's Labyrinth.\"\n The book appears old and worn, but it emits a faint, magical glow. \n As you reach for the book,your friend suddenly turns hostile towards you.\n A brief conversation ensues, during which your friend reveals their true intentions and motivations for comming to the libary. \nIt becomes clear that they were using you to access the house and take the power within the book.\nYour friend grabs the book and starts to open it,once the book is fully opened you will be trapped iside.");

                        WriteLine("\r\nDo you try to stop your friend or do you runaway? \nSelect 1 to stop your friend, select 2 to runaway and let them take the book.");
                        int option = Convert.ToInt32(ReadLine());
                        if (option == 1)
                        {
                            WriteLine("\r\n\r\nIn a sinister twist, your once-trusted friend, driven by their treacherous intentions, casts a malevolent spell that \ndrains the very life force from your surroundings, leaving you gasping for breath as your world fades to black.\nYOU DIE! ");
                        }
                        else if (option == 2)
                        {
                            WriteLine("\r\n\r\nAs you run towards the door your friend casts a powerful spell from an ancient incantation scroll, causing the book to glow even brighter. A surge of magical energy you, and you are transported into the world of \"The Dragon's Labyrinth.\"");

                            WriteLine("You arrive in the Dragon's Lair in a lush forest glade, bewildered and disoriented.");
                            WriteLine("As you explore the forest,you encounter a fairy.\nYou befriend the fairy and the fairy tells you that the only creatures in this world with magic strong enough to leave the book are the dragons but casting such a powerful spell is extremly difficult and can only be done by the Great Dragon,an ancient dragon that kills all whom anger it.");
                            WriteLine("You and the fairy navigate through the Dragon's Lair, encountering mesmerizing but treacherous terrain.\n The fairy explains that the Great Dragon resides deep within the heart of the lair and to reach the Great Dragon's lair, the player must cross a chasm spanned by a mystical bridge. \nThe bridge is shrouded in an ethereal mist, and its path appears to shift and change as if it has a mind of its own.");

                            WriteLine("To safely cross the bridge,you must solve a riddle presented by the bridge's guardian spirit:\r\n\r\n\"I'm always hungry, I must always be fed,\r\nThe finger I touch, will soon turn red.\r\nWhat am I?\"");

                            WriteLine("\r\n\r\nThe guardian spirit gives you two possibel answers: rust or fire.\n Select 1 for rust or select 2 for fire.");
                            int riddle_answer = Convert.ToInt32(ReadLine());
                            if (riddle_answer == 1)
                            {
                                WriteLine("\r\nYou are denied passage and the spirit devoures your body whole for answering incorrectly.\nYOU DIE!");
                            }
                            else if (riddle_answer == 2)
                            {
                                WriteLine("\r\nYou successfully cross the bridge and finally arrive at the Great Dragon's lair, a massive cavern with walls adorned in shimmering gemstones. \nThe Great Dragon, an awe-inspiring and majestic creature, awaits for your arrival.\nYou humbly present your request to the Great Dragon, explaining your predicament and the need for the dragon's powerful magic to escape the book.");

                                WriteLine("The Great Dragon, intrigued by the your courage and intelligence, agrees to consider helping but presents the player with a daunting challenge: to prove their worthiness by retrieving a rare and magical gem from the lair of a rival dragon, thereby demonstrating your resourcefulness and bravery.");

                                WriteLine("You set out on your quest guided by the mystical fairy and armed with clues from the Great Dragon. \nYou venture deeper into the Dragon's Lair towards the territory of the rival dragon.");
                                WriteLine("As you progress, you navigate treacherous terrain filled with lava pits, fiery geysers, and crumbling volcanic rocks. \nTiming and agility are crucial to avoid hazards.");
                                WriteLine("You encounter minions of the rival dragon, fierce creatures and guardians protecting the gem.\n You can choose to sneak past them stealthily or engage in strategic battles.\nSelect 1 to sneak past or select 2 to engage in battle.");
                                int ans = Convert.ToInt32(ReadLine());
                                if (ans == 1)
                                {
                                    WriteLine("\r\nWith careful and silent maneuvering, you manage to evade the watchful eyes of the rival dragon's minions, slipping past them unnoticed and moving forward without alerting any danger.");

                                    WriteLine("You reach the heart of the rival dragon's lair—a chamber filled with molten gold and guarded by the rival dragon itself. \nThe gem is prominently displayed within the chamber.");
                                    WriteLine("You must confront the rival dragon in a high-stakes showdown. \nYou can either engage in a battle of wits and strategy to outsmart the rival dragon or engage in a thrilling aerial duel.\nSelect 1 for battle of wit or select 2 for a duel.");
                                    int rival_dragon_ans = Convert.ToInt32(ReadLine());
                                    if (rival_dragon_ans == 1)
                                    {
                                        WriteLine("Drawing upon your cunning and intelligence, you engage the rival dragon in a battle of wits, exploiting its weaknesses and cleverly outmaneuvering its attacks. \nYour strategic brilliance prevails, and you emerge victorious, leaving the rival dragon stunned and humbled.");

                                        WriteLine("After outsmarting the rival dragon,you retrieve the rare and magical gem from the chamber.\nYou return to the Great Dragon's lair with the gem, ready to present it as proof of your resourcefulness and bravery.");

                                        WriteLine("With the rare and magical gem in your possession, you harness the Great Dragon's powerful magic, breaking free from the book's enchantment.\n As you escape its pages, the spell that once entrapped you is redirected, ensnaring your former friend, who betrayed you, within the very same tome they used to trap you.\nCongradulations you have WON the game!");
                                    }
                                    else if (rival_dragon_ans == 2)
                                    {
                                        WriteLine("\r\nIn the midst of a thrilling aerial duel with the rival dragon, despite your courageous efforts, the dragon's superior aerial prowess and fiery breath prove insurmountable. \nThe intense battle takes its toll, and you succumb to the relentless assault, plummeting to the molten ground below. \nYOU DIE!");
                                    }
                                }
                                else if (ans == 2)
                                {
                                    WriteLine("Despite your valiant effort in battle, the sheer strength and ferocity of the rival dragon's minions overwhelm you, and your valiant struggle ends in defeat, \nleaving you incapacitated within the fiery lair.\nYOU DIE!");
                                }
                                else
                                {
                                    WriteLine("\r\n\r\nThe answer you entered is invalid. Please try something else.");
                                }

                            }
                            else
                            {
                                WriteLine("\r\n\r\nThe answer you entered is not valid.");
                            }

                        }
                        else
                        {
                            WriteLine("\r\n\r\nThe option you entered is not valid.Please select something else.");
                        }

                    }
                    else
                    {
                        WriteLine("\r\n\r\nThe option you entered is not valid Please select something else.");
                    }
                }
                else if (answer.ToLower() == "no")
                {
                    WriteLine("If you decide not to embark on this adventure, we understand, and your journey ends here. \nShould you change your mind, the house's mysteries will patiently await your return.");

                }
                else
                {
                    WriteLine("The option you entered is not valid.Please select something else.");
                }

                WriteLine("Do you want to play again?(yes/no)");
                string playAgainInput =ReadLine().ToLower();
                if (playAgainInput == "yes")
                {
                    playAgain = true;
                }
                else if(playAgainInput == "no")
                {
                    WriteLine("If you decide not to embark on this adventure, we understand, and your journey ends here.");
                   WriteLine("Should you change your mind, the house's mysteries will patiently await your return.");
                    playAgain = false;
                }
                else
                {
                    WriteLine("The option you entered is not valid. Please select something else.");
                }

            }
            Read();
        }
    }
}
