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
            foreach (TeamMember n in _teamMembers)
            {
                Console.WriteLine(n.Name);
                Console.WriteLine(n.SkillLevel);
                Console.WriteLine(n.CourageFactor);
            }
        }
    }
}