# Delegate-Based State Machine Library 🚦

Hey there! This is a delegate-driven state machine engine for C#—lightweight, modular, and flexible for all your workflow needs. Think of it as the conductor of your state orchestra. 🎵

---

## Getting Started 🚀

1. 🔓 Open **DelegateStateMachine.sln** in Visual Studio, Rider, or your IDE of choice.  
2. 🏗️ Build the **StateMachineLib** project under `src/StateMachineLib/`.  
3. 📦 Reference the compiled DLL in your app or add the project directly to your solution.

---

## Core Concepts 🔑

- ▶️ **StateAction**  
  A `void` delegate that fires when you enter (`OnEnter`) or exit (`OnExit`) a state—perfect for logs, side effects, or animations.

- ▶️ **TransitionCondition**  
  A `bool` delegate evaluated each cycle. When it returns `true`, the machine jumps to the next state.

- ▶️ **State**  
  - **Name**: Unique identifier  
  - **OnEnter**: Optional enter hook  
  - **OnExit**: Optional exit hook

- ▶️ **Transition**  
  - **From → To**: Source and destination state names  
  - **Condition**: Delegate that gatekeeps the jump

- ▶️ **StateMachine**  
  1. 🗂️ Register states with `AddState(...)`  
  2. 🔗 Wire up transitions via `AddTransition(...)`  
  3. 🎬 Kick off with `SetInitialState(...)`  
  4. ▶️ Advance through  
     ```csharp
     while (machine.MoveNext()) { }
     ```

---

## Usage Tips 💡

- 📍 Centralize setup in `Program.cs` (see the demos for patterns).  
- ✍️ Pick state names that read like a story (e.g., Submitted → Reviewed → Approved).  
- 🖋️ Keep conditions inline with lambdas for readability.  
- 🛑 The machine stops gracefully when no transition is valid—no errors, just wrap-up.

### Demos 📚

- 📄 [document review](\demos\DocReviewConsole\Program.cs)  
- 🎮 [game-character states](\demos\GameCharacterDemo\Program.cs)  
- 🧾 [invoice processing](\demos\InvoiceProcessingDemo\Program.cs)

---

## Roadmap & Future Ideas 🛤️

- 🎯 Prioritized or parallel transitions  
- ⚡ Async/await–friendly hooks  
- 🗄️ Checkpointing & persistence  
- 🖼️ Automatic state-diagram export

I’ll keep iterating—your feedback and pull requests are highly welcome! 🙌

---
