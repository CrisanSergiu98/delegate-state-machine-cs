using StateMachineLib;

decimal invoiceAmount = 1200;

StateMachine machine = new();

machine.AddState(new("Received") { OnEnter = () => Console.WriteLine("Invoice received.") });
machine.AddState(new("Validated") { OnEnter = () => Console.WriteLine("Invoice validated.") });
machine.AddState(new("Approved") { OnEnter = () => Console.WriteLine("Invoice approved.") });
machine.AddState(new("Flagged") { OnEnter = () => Console.WriteLine("Invoice flagged.") });

machine.AddTransition("Received", "Validated", () => true);
machine.AddTransition("Validated", "Approved", () => invoiceAmount < 1000);
machine.AddTransition("Validated", "Flagged", () => invoiceAmount >= 1000);

machine.SetInitialState("Received");

while (machine.MoveNext()) ;
