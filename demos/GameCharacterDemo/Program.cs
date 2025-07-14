using StateMachineLib;

Random rng = new();
StateMachine machine = new();

machine.AddState(new("Idle") { OnEnter = () => Console.WriteLine("Character is idle.") });
machine.AddState(new("Walking") { OnEnter = () => Console.WriteLine("Character is walking.") });
machine.AddState(new("Jumping") { OnEnter = () => Console.WriteLine("Character is jumping.") });
machine.AddState(new("Attacking") { OnEnter = () => Console.WriteLine("Character is attacking.") });
machine.AddState(new("Dead") { OnEnter = () => Console.WriteLine("Character is dead.") });

machine.AddTransition("Idle", "Walking", () => true);
machine.AddTransition("Walking", "Jumping", () => true);
machine.AddTransition("Jumping", "Attacking", () => true);
machine.AddTransition("Attacking", "Dead", () => true);

machine.SetInitialState("Idle");

while (machine.MoveNext()) ;
