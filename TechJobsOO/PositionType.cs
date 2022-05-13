using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.

        public override bool Equals(object obj) //FG <===
        {
            return obj is PositionType position &&
                 Id == position.Id;   //FG <=== 
        }

        public override int GetHashCode() //FG <===
        {
            return HashCode.Combine(Id);
        }

        public override string ToString() //FG <===
        {
            return Value;
        }

    }
}
