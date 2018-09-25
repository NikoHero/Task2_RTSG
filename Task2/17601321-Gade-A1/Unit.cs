namespace _17601321_Gade_A1
{
    //17601321 Nicholas Statheros
    //Unique code : Sazu0
    class Unit
    {
        protected int XPosition;
        protected int YPosition;
        protected int Health;
        protected int MaxHealth;
        protected int Speed;
        protected int Attack;
        protected int AttackRange;
        protected string team;
        protected string Symbol;
        protected int IsAttacking;

        protected string Name;
        public Unit ()
        {

        }

        public abstract void NewPosition();
        public abstract void Combat();
        public abstract void RangeAttack();
        public abstract Unit ReturnPosition();
        public abstract void Death();
        public abstract override string ToString(); 


    }
}
