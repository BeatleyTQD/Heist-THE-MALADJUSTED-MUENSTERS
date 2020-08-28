using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Team myTeam = new Team();
            bool nameCheck = true;
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("-----------------");
            while (nameCheck)
            {

                Console.Write("Member name:");
                string name = Console.ReadLine();
                if (name == "")
                {
                    nameCheck = false;
                }
                else
                {
                    Console.Write("Skill Level?:");
                    string skillLevel = Console.ReadLine();
                    int skillLevelNum = int.Parse(skillLevel);

                    Console.Write("What is your Courage Level 0 - 2.0?:");
                    string courageFactor = Console.ReadLine();
                    double courageFactorNum = double.Parse(courageFactor);

                    TeamMember aNewMember = new TeamMember()
                    {
                        Name = name,
                        SkillLevel = skillLevelNum,
                        CourageFactor = courageFactorNum
                    };
                    Console.WriteLine();

                    myTeam.AddMember(aNewMember);
                }
            }
            myTeam.PrintMembers();
            // Console.WriteLine($"{aNewMember.Name}\n{aNewMember.SkillLevel}\n{aNewMember.CourageFactor}");

        }

    }
}