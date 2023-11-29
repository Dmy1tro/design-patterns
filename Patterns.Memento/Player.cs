namespace Patterns.Memento;

internal class Player
{
    private int _health = 50;
    private Gun _gun = new();

    public void Heal()
    {
        _health++;
    }

    public void Shoot()
    {
        _gun.Shoot();
    }

    public PlayerSnapshot CreateSnapshot()
    {
        return new PlayerSnapshot
        {
            Health = _health,
            Gun = _gun.CreateSnapshot()
        };
    }

    public static Player FromSnapshot(PlayerSnapshot snapshot)
    {
        var player = new Player
        {
            _health = snapshot.Health,
            _gun = Gun.FromSnapshot(snapshot.Gun)
        };

        return player;
    }

    internal class Gun
    {
        public int Amo { get; set; }

        public void Shoot()
        {
            Amo--;
        }

        public GunSnapshot CreateSnapshot()
        {
            return new GunSnapshot
            {
                Amo = Amo
            };
        }

        public static Gun FromSnapshot(GunSnapshot snapshot)
        {
            var gun = new Gun
            {
                Amo = snapshot.Amo
            };

            return gun;
        }
    }
}
