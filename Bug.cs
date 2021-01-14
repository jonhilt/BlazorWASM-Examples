using System.Collections.Generic;
using Stateless;

namespace BlazorExamples.WASM
{
    public class Bug
    {
        public enum State {Open, Assigned, Deferred, Closed}

        public enum Trigger { Assign, Defer, Close }

        private readonly StateMachine<State, Trigger> _machine;
        
        public IEnumerable<Trigger> PermittedTriggers => _machine.PermittedTriggers;

        public void Fire(Trigger trigger)
        {
            _machine.Fire(trigger);
        }

        public State CurrentState => _machine.State;
        
        public Bug()
        {
            _machine = new StateMachine<State, Trigger>(State.Open);
            _machine.Configure(State.Open)
                .Permit(Trigger.Assign, State.Assigned);
            
            _machine.Configure(State.Assigned)
                .SubstateOf(State.Open)
                .Permit(Trigger.Close, State.Closed)
                .Permit(Trigger.Defer, State.Deferred);
        }
    }
}