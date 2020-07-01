using System;

namespace Strategy
{
    public interface IUnit
    {
        int Position { get; set; }
        void Move();
        IMoveBehavior MoveBehavior { get; set; }
    }
    public interface IMoveBehavior
    {
        void Move(IUnit unit);
    }

    public class Fly : IMoveBehavior
    {
        public void Move(IUnit unit)
        {

        }
    }

    public class Walk : IMoveBehavior
    {
        public void Move(IUnit unit)
        {

        }
    }

    public class Viking : IUnit
    {
        public Viking()
        {

        }

        public IMoveBehavior MoveBehavior { get; set; }

        public int Position { get; set; }

        public void Move()
        {

        }
    }
}