namespace DesignePatterns.Behavioral.State
{
    public class ATM
    {
        private IATMState _state;

        public ATM() => _state = new NoCardState(this);
        public void SetState(IATMState state) => _state = state;
        public void InsertCard() => _state.InsertCard();
        public void EjectCard() => _state.EjectCard();
        public void WithdrawMoney(int amount) => _state.WithdrawMoney(amount);
    }
    // Base state
    public interface IATMState
    {
        void InsertCard();
        void EjectCard();
        void WithdrawMoney(int amount);
    }
    // Card not in
    public class NoCardState : IATMState
    {
        private readonly ATM _atm;
        public NoCardState(ATM atm) => _atm = atm;

        public void InsertCard()
        {
            Console.WriteLine("Card Inserted.");
            _atm.SetState(new HasCardState(_atm));
        }

        public void EjectCard() => Console.WriteLine("No card to eject.");
        public void WithdrawMoney(int amount) => Console.WriteLine("Insert card first.");
    }

    // Card in
    public class HasCardState : IATMState
    {
        private readonly ATM _atm;
        public HasCardState(ATM atm) => _atm = atm;

        public void InsertCard() => Console.WriteLine("Card already inserted.");
        public void EjectCard()
        {
            Console.WriteLine("Card Ejected.");
            _atm.SetState(new NoCardState(_atm));
        }
        public void WithdrawMoney(int amount)
        {
            Console.WriteLine($"Dispensed {amount}$");
            _atm.SetState(new NoCardState(_atm));
        }
    }
}
