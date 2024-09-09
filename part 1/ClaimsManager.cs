using System.Collections.Generic;

namespace CMCS
{
    public static class ClaimsManager
    {
        private static readonly List<Claim> _claims = new List<Claim>();

        public static IReadOnlyList<Claim> Claims => _claims.AsReadOnly();

        public static void AddClaim(Claim claim)
        {
            _claims.Add(claim);
        }

    }

}
