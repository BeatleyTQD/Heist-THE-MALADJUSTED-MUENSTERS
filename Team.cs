using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    public class Team
    {
        public List<TeamMember> teamMembers = new List<TeamMember>();

        public void AddMember(TeamMember newMember)
        {
            teamMembers.Add(newMember);
        }
        public void PrintMembers()
        {
            foreach (TeamMember n in teamMembers)
            {
                Console.WriteLine(n.Name);
                Console.WriteLine(n.SkillLevel);
                Console.WriteLine(n.CourageFactor);
            }
        }

        public void TeamSkillCheck(int bankDifficulty)
        {
            int sumSkill = teamMembers.Sum(teamMember => teamMember.SkillLevel);
            if (sumSkill >= bankDifficulty)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failure");
            }
        }
    }
}