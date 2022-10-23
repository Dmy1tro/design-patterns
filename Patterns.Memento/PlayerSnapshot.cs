namespace Patterns.Memento
{
    // Snapshot contains only required data (kind of configurations or settings) that is needed to create a business entity
    internal class PlayerSnapshot
    {
        public int Health { get; init; }

        public GunSnapshot Gun { get; init; }
    }

    internal class GunSnapshot
    {
        public int Amo { get; init; }
    }
}
