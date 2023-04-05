using StrictlyTyped;

namespace Example
{
    public static partial class TodoItems
    {
        [StrictLong]
        public partial record struct Id;

        [StrictString]
        public partial record struct Name;

        [StrictBool]
        public partial record struct IsComplete;
    }
}
