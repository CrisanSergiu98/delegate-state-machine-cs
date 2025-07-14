namespace StateMachineLib;

public class StateMachine
{
    private Dictionary<string, State> _states = new();
    private List<Transition> _transitions = new();
    private State? _currentState;
    public string? CurrentStateName => _currentState?.Name;
    public void AddState(State state)
    {
        _states[state.Name] = state;
    }
    public void AddTransition(string from, string to, TransitionCondition condition)
    {
        _transitions.Add(new Transition(from, to, condition));
    }
    public void SetInitialState(string stateName)
    {
        if (_states.TryGetValue(stateName, out var state))
        {
            _currentState = state;
            _currentState.OnEnter?.Invoke();
        }
        else throw new ArgumentException("Invalid State.");
    }
    public bool MoveNext()
    {
        if (_currentState == null) return false;

        var transition = _transitions.Where(t => t.From == _currentState.Name && t.Condotion()).FirstOrDefault();

        if (transition == null) return false;

        _currentState.OnExit?.Invoke();
        _currentState = _states[transition.To];
        _currentState.OnEnter?.Invoke();

        return true;
    }
}