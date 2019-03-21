using System;

namespace Atlantida.Models
{
    public static class Role
    {
        public const string Administrator = "Administrator";
        public const string Guest = "Guest";
        public const string Applicant = "Applicant";
        public const string Member = "Member";
        public const string InitiativeGroup = "InitiativeGroup";
        public const string SMM = "SMM";

        public static string[] Roles = new string[] {
            Role.Administrator,
            Role.Guest,
            Role.Applicant,
            Role.Member,
            Role.InitiativeGroup,
            Role.SMM
        };
    }
}
