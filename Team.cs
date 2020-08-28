using System;
using System.Collections.Generic;

namespace heist
{
    public class Team
    {
        private List<TeamMember> _teamMembers = new List<TeamMember>();

        public void AddMember(TeamMember newMember)
        {
            _teamMembers.Add(newMember);
        }
        public void PrintMembers()
        {
            Console.WriteLine($"\nTEAM:");
            foreach (TeamMember n in _teamMembers)
            {
                Console.WriteLine($"Name:    {n.Name}");
                Console.WriteLine($"Skill:   {n.SkillLevel}");
                Console.WriteLine($"Courage: {n.CourageFactor}\n");
            }
        }
    }
}
