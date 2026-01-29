namespace PeZetSpice.Types
{
    public enum GridType
    {
        None,
        Lines,
        Dots,
        Isometric,
    }

    public class Paper
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public GridType Grid { get; set; } = GridType.Dots;
    }

    public interface IConnectable
    {
        public List<IConnectable> Connections { get; }
        public void ConnectTo(IConnectable other)
        {
            if (!Connections.Contains(other))
            {
                Connections.Add(other);
            }
            if (!other.Connections.Contains(this))
            {
                other.Connections.Add(this);
            }
        }
        public void DisconnectFrom(IConnectable other)
        {
            if (Connections.Contains(other))
            {
                Connections.Remove(other);
            }
            if (other.Connections.Contains(this))
            {
                other.Connections.Remove(this);
            }
        }
        public IConnectable[] GetConnections()
        {
            return Connections.ToArray();
        }
        public bool IsConnectedTo(IConnectable other)
        {
            return Connections.Contains(other);
        }
    }


    public class Wire : IConnectable
    {
        public List<IConnectable> Connections => [];        
    }
}
