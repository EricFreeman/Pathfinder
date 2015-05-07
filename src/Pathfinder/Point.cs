namespace Pathfinder
{
    public class Point
    {
        public readonly float X;
        public readonly float Y;  

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        protected bool Equals(Point other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode()*397) ^ Y.GetHashCode();
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            return Equals((Point) obj);
        }

        public override string ToString()
        {
            return X + "," + Y;
        }
    }
}