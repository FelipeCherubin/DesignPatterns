namespace Builder.Componentes
{
    class Motor
    {
        private int power;

        public int Power
        {
            get => power;
            set => power = value;
        }

        public Motor(int power)
        {
            this.Power = power;
        }
    }
}
