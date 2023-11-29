namespace Patterns.Memento;

internal class Game
{
    void Play()
    {
        var saves = new LinkedList<PlayerSnapshot>();
        var player = new Player();

        player.Heal();
        player.Shoot();

        var snapshot = player.CreateSnapshot();
        saves.AddLast(snapshot);

        player.Heal();
        player.Shoot();

        var lastSnapshot = saves.Last.Value;
        player = Player.FromSnapshot(lastSnapshot);
    }
}
