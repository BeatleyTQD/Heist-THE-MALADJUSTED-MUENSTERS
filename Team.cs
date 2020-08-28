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

    }
}