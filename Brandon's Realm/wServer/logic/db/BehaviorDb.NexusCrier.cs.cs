#region

using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;

#endregion

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ NexusCrier = () => Behav()
            .Init("Nexus Crier",
            new State(
                new State("Wait",   //This is the State that waits till there is a player within 10 blocks
                        new ConditionalEffect(ConditionEffectIndex.Invisible), //This is to prevent it to be killed, unless you want to murder him...
                new State("TEXT1",
                    new Taunt("Brandon is the current owner <3"),
                    new TimedTransition(10000, "TEXT2"),
                    new NoPlayerWithinTransition(10, "Wait")
                        ),
            new State("TEXT2",
                new Taunt("Got my eyes on you hackers!"),
                new TimedTransition(10000, "TEXT3"),
                new NoPlayerWithinTransition(10, "Wait")
                ),
            new State("TEXT3",
                new Taunt("IF you want to donate tell brandon/yato on discord!"),
                new TimedTransition(10000, "TEXT4"),
                new NoPlayerWithinTransition(10, "Wait")
                ),
            new State("TEXT4",
                new Taunt("More will be added soon!"),
                new TimedTransition(10000, "TEXT1"),
                new NoPlayerWithinTransition(10, "Wait")
                )
                    )
            ));
    }
}