﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Team myTeam = new Team();
            bool nameCheck = true;
            Console.Write("Choose your difficulty: ");
            string initialBankDifficulty = Console.ReadLine();
            int initialBankDifficultyNum = int.Parse(initialBankDifficulty);

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("-----------------");

            while (nameCheck)
            {

                Console.Write("Member name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    nameCheck = false;
                }
                else
                {
                    Console.Write("Skill Level?: ");
                    string skillLevel = Console.ReadLine();
                    int skillLevelNum = int.Parse(skillLevel);

                    Console.Write("What is your Courage Level 0 - 2.0?: ");
                    double courageFactor = double.Parse(Console.ReadLine());

                    if (courageFactor > 2 || courageFactor < 0)
                    {
                        Console.Write("Courage Level must be 0 - 2.0?: ");
                        courageFactor = double.Parse(Console.ReadLine());
                    }

                    TeamMember aNewMember = new TeamMember()
                    {
                        Name = name,
                        SkillLevel = skillLevelNum,
                        CourageFactor = courageFactor
                    };
                    Console.WriteLine();

                    myTeam.AddMember(aNewMember);
                }
            }

            Console.Write("How many times would you like to run this scenario? ");
            string trialRuns = Console.ReadLine();
            int trialRunsNum = int.Parse(trialRuns);

            for (int i = 0; i < trialRunsNum; i++)
            {
                int Luck = new Random().Next(-11, 11);
                int bankDifficulty = initialBankDifficultyNum + Luck;
                myTeam.TeamSkillCheck(bankDifficulty);
            }
            Console.WriteLine();
            myTeam.DisplayWinRate();
            // myTeam.PrintMembers();



        }

    }
}
