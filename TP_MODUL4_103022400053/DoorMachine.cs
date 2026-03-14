namespace TP_MODUL4_103022400053
{
    internal class DoorMachine
    {
        public enum State { Terkunci, Terbuka }
        public enum Trigger { KunciPintu, BukaPintu };
        public State currentState = State.Terkunci;
        public DoorMachine()
        {
            Console.WriteLine("Pintu " + currentState);
        }
        public void UbahState(Trigger trigger)
        {
            switch (currentState)
            {
                case State.Terkunci:
                    if (trigger == Trigger.BukaPintu)
                    {
                        currentState = State.Terbuka;
                    }
                    else if (trigger == Trigger.KunciPintu)
                    {
                        currentState = State.Terkunci;
                    }
                    break;

                case State.Terbuka:
                    if (trigger == Trigger.KunciPintu)
                    {
                        currentState = State.Terkunci;
                    }
                    else if (trigger == Trigger.BukaPintu)
                    {
                        currentState = State.Terbuka;
                    }
                    break;
            }

            if (currentState == State.Terkunci)
            {
                Console.WriteLine("Pintu terkunci");
            }
            else if (currentState == State.Terbuka)
            {
                Console.WriteLine("Pintu tidak terkunci");
            }
        }
    }
}
