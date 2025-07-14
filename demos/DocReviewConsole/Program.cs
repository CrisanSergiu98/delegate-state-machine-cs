using StateMachineLib;

StateMachine machine = new();

machine.AddState(new("Submitted") { OnEnter = () => Console.WriteLine("Document submitted.") });
machine.AddState(new("Reviewed") { OnEnter = () => Console.WriteLine("Document reviewed.") });
machine.AddState(new("Approved") { OnEnter = () => Console.WriteLine("Document approved.") });
machine.AddState(new("Rejected") { OnEnter = () => Console.WriteLine("Document rejected.") });

machine.AddTransition("Submitted", "Reviewed", () => true);
machine.AddTransition("Reviewed", "Approved", () => true);
machine.AddTransition("Reviewed", "Rejected", () => false);

machine.SetInitialState("Submitted");

while (machine.MoveNext());