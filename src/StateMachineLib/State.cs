namespace StateMachineLib;

public class State
{
    public string Name { get; set; }
    public StateAction? OnEnter { get; set; }
    public StateAction? OnExit { get; set; }
    public State(string name)
    {
        Name = name;
    }
}