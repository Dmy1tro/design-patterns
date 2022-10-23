using System.Collections;

namespace Patterns.Adapter.V1
{
    // Exactly that one service with 5k line of legacy code =)
    internal class LegacyService
    {
        // Of course all methods are static =)
        public static ArrayList Filter(ArrayList users, int minAge, int maxAge)
        {
            foreach (var item in users)
            {
                // some logic
            }

            return users;
        }

        public static bool HandleEvent(object sender, EventArgs args)
        {
            // some logic

            return true;
        }
    }
}
