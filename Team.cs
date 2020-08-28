using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    public class Team
    {
        public List<TeamMember> teamMembers = new List<TeamMember>();
        public int successes { get; set; }
        public int failures { get; set; }

        public void AddMember(TeamMember newMember)
        {
            teamMembers.Add(newMember);
        }
        public void PrintMembers()
        {
            foreach (TeamMember n in teamMembers)
            {
                Console.WriteLine($"Name:    {n.Name}");
                Console.WriteLine($"Skill:   {n.SkillLevel}");
                Console.WriteLine($"Courage: {n.CourageFactor}\n");
            }
        }

        public void TeamSkillCheck(int bankDifficulty)
        {
            int sumSkill = teamMembers.Sum(teamMember => teamMember.SkillLevel);
            Console.WriteLine($"\nYour Team's Skill Level: {sumSkill}");
            Console.WriteLine($"Bank Difficulty: {bankDifficulty}");
            if (sumSkill >= bankDifficulty)
            {
                Console.WriteLine("Success");
                successes++;
            }
            else
            {
                Console.WriteLine("Failure");
                failures++;
            }
        }

        public void DisplayWinRate()
        {
            Console.WriteLine($"Successes: {successes} \nFailures: {failures}\n");
        }
    }
}
