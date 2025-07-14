namespace StateMachineLib;

public class Transition
{
    public string From { get; }
    public string To { get; }
    public TransitionCondition Condotion { get; }
    public Transition(string from, string to, TransitionCondition condotion)
    {
        From = from;
        To = to;
        Condotion = condotion;
    }

}