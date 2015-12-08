using System;
public class Player
{
    
    public int wins;
    public int rounds;



    public Player()
    {

        wins = 0;
        rounds = 0;
    }

    // Play function compares the user's choice with random A.I. choice and a win is allocated
    public int[] Play(int choice, Player npc)
    {
        int[] npcShow =  new int[2];

        int winner;
        int npcChoice = npc.randomChoice();

        winner = Compare(choice, npcChoice);
        npcShow[0] = winner;
        npcShow[1] = npcChoice;

        if (winner == 0)
        {
            wins += 1;
        }
        else if (winner == 1)
        {
            npc.wins += 1;
        }
        if (wins == 3 && wins > npc.wins)
        {
            rounds += 1;
        }
        else if (npc.wins == 3 && npc.wins > wins)
        {
            npc.rounds += 1;
        }
        return npcShow;
        


    }
    // Generates random choice for AI
    public int randomChoice()
    {

        Random random = new Random();
        int randomNum = random.Next(0, 3);

        return randomNum;


    }

    // Compare function to compare the users choice against the AI's randomly generated choice
    public int Compare(int choice, int npcChoice)
    {
        // Player = 0, NPC = 1 , Tie = 2
        int winner = 0;


        if (choice == 0 && npcChoice == 1)
        {
            winner = 1;
        }
        else if (choice == 0 && npcChoice == 2)
        {
            winner = 0;
        }
        else if (choice == 0 && npcChoice == 0)
        {
            winner = 2;
        }
        else if (choice == 1 && npcChoice == 0)
        {
            winner = 0;
        }
        else if (choice == 1 && npcChoice == 1)
        {
            winner = 2;
        }
        else if (choice == 1 && npcChoice == 2)
        {
            winner = 1;
        }
        else if (choice == 2 && npcChoice == 0)
        {
            winner = 1;
        }
        else if (choice == 2 && npcChoice == 1)
        {
            winner = 0;
        }
        else if (choice == 2 && npcChoice == 2)
        {
            winner = 2;
        }


        Console.WriteLine("{0},{1},{2}", choice, npcChoice, winner);


        return winner;


    }





}