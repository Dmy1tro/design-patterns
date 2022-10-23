using System.Collections;
using Patterns.Adapter.V1;

namespace Patterns.Adapter.V2
{
    internal class LegacyCodeAdapter : IUpToDateService
    {
        // Wrapping legacy methods and use up-to-date interface
        public Task<ICollection<User>> Filter(IEnumerable<User> users, UserFilter userFilter)
        {
            var arrayList = new ArrayList(users.ToList());
            var minAge = userFilter.MinAge;
            var maxAge = userFilter.MaxAge;

            var result = LegacyService.Filter(arrayList, minAge, maxAge);

            var typedResult = result.ToArray(typeof(User)).Cast<User>().ToList() as ICollection<User>;

            return Task.FromResult(typedResult);
        }

        public Task<HandleResult> HandleEvent<TSender, TArgs>(TSender sender, TArgs args)
        {
            var eventArgs = new LegacyEventArgsAdapter<TArgs>(args);

            var isSuccess = LegacyService.HandleEvent(sender, eventArgs);

            if (isSuccess)
            {
                return Task.FromResult(new HandleResult { IsSuccess = true });
            }
            else
            {
                return Task.FromResult(new HandleResult { IsSuccess = false, ErrorMessage = "Something went wrong." });
            }
        }

        private class LegacyEventArgsAdapter<TArgs> : EventArgs
        {
            public LegacyEventArgsAdapter(TArgs args)
            {
                // Proceed mapping
            }
        }
    }
}
