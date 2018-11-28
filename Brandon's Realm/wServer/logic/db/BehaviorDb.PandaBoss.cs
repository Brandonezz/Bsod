using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ PandaBoss = () => Behav()
            .Init("Brandon The Panda",
                new State(
                    new State("0.0",
                        new PlayerWithinTransition(8, "1.0")
                        ),
                    new State("1.0",
                        new TimedTransition(5000, "1.1"),
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 90, coolDownOffset: 0, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 100, coolDownOffset: 200, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 110, coolDownOffset: 400, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 120, coolDownOffset: 600, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 130, coolDownOffset: 800, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 140, coolDownOffset: 1000, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 150, coolDownOffset: 1200, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 160, coolDownOffset: 1400, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 170, coolDownOffset: 1600, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 180, coolDownOffset: 1800, shootAngle: 90),
                        new Shoot(1, 8, coolDown: 10000, fixedAngle: 180, coolDownOffset: 2000, shootAngle: 45),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 180, coolDownOffset: 0, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 170, coolDownOffset: 200, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 160, coolDownOffset: 400, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 150, coolDownOffset: 600, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 140, coolDownOffset: 800, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 130, coolDownOffset: 1000, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 120, coolDownOffset: 1200, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 110, coolDownOffset: 1400, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 100, coolDownOffset: 1600, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 90, coolDownOffset: 1800, shootAngle: 90),
                        new Shoot(1, 4, coolDown: 10000, fixedAngle: 90, coolDownOffset: 2000, shootAngle: 22.5)
                        ),
                    new State("1.1",
                        new HpLessTransition(.75, "2.0"),
                        new State("1.B",
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 90, coolDownOffset: 0, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 100, coolDownOffset: 200, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 110, coolDownOffset: 400, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 120, coolDownOffset: 600, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 130, coolDownOffset: 800, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 140, coolDownOffset: 1000, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 150, coolDownOffset: 1200, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 160, coolDownOffset: 1400, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 170, coolDownOffset: 1600, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 180, coolDownOffset: 1800, shootAngle: 90),
                            new Shoot(1, 8, coolDown: 10000, fixedAngle: 180, coolDownOffset: 2000, shootAngle: 45),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 180, coolDownOffset: 0, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 170, coolDownOffset: 200, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 160, coolDownOffset: 400, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 150, coolDownOffset: 600, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 140, coolDownOffset: 800, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 130, coolDownOffset: 1000, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 120, coolDownOffset: 1200, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 110, coolDownOffset: 1400, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 100, coolDownOffset: 1600, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 90, coolDownOffset: 1800, shootAngle: 90),
                            new Shoot(1, 4, coolDown: 10000, fixedAngle: 90, coolDownOffset: 2000, shootAngle: 22.5),
                            new TimedTransition(2000, "1.W")
                            ),
                        new State("1.W",
                            new Follow(0.7, range: 0.5),
                            new Flash(0xff00ff00, 0.1, 20),
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(2000, "1.B")
                            )
                        ),
                    new State("2.0",
                        new HpLessTransition(.625, "3.0"),
                        new Follow(.1, 15, 3),
                        new State("2.A",
                            new ConditionalEffect(ConditionEffectIndex.Armored),
                            new Shoot(10, 4, shootAngle: 10, projectileIndex: 1, coolDown: 1000),
                            new TimedTransition(5000, "2.1")
                            ),
                        new State("2.1",
                            new Shoot(10, 4, shootAngle: 10, projectileIndex: 1, coolDown: 1000),
                            new Shoot(16, 4, shootAngle: 90, coolDown: 1000),
                            new Shoot(16, 4, shootAngle: 90, angleOffset: 45, coolDown: 1500)
                            )
                        ),
                    new State("3.0",
                        new Wander(0.3),
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new TimedTransition(1050, "4.0"),
                        new Shoot(10, 6, shootAngle: 15, projectileIndex: 2, coolDown: 2000)
                        ),
                   new State("4.0",
                        new Shoot(10, 4, shootAngle: 10, projectileIndex: 1, coolDown: 1000),
                        new Shoot(16, 4, shootAngle: 90, coolDown: 1000),
                        new Shoot(16, 4, shootAngle: 90, angleOffset: 45, coolDown: 1500),
                        new HpLessTransition(.5, "5.0")
                        ),
                    new State("5.0",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new ChangeSize(1, 160),
                        new Flash(0xff00ff00, 1, 20),
                        new Taunt("Hi, I'm Brandon can I eat you up like a bamboo?"),
                        new TimedTransition(4000, "5.1")
                        ),
                   new State("5.1",
                        new Shoot(10, 4, shootAngle: 10, projectileIndex: 1, coolDown: 1000),
                        new Shoot(10, 6, shootAngle: 15, projectileIndex: 2, coolDown: 2000),
                        new Shoot(16, 4, shootAngle: 90, coolDown: 1000),
                        new Shoot(16, 4, shootAngle: 90, angleOffset: 45, coolDown: 1500),
                        new HpLessTransition(.05, "6.0")
                        ),
                    new State("6.0",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new Taunt("You're being rude to me I'm leaving I don't like meanies like you."),
                        new TimedTransition(5000, "6.1")
                        ),
                    new State("6.1",
                        new Suicide()
                        )
                    ),
                new Threshold(0.025,
                    new ItemLoot("Potion of Speed", 1.0),
                    new ItemLoot("Potion of Defense", 1.0),
                    new ItemLoot("Potion of Dexterity", 1.0),
                    new ItemLoot("Potion of Attack", 1.0),
                    new TierLoot(9, ItemType.Weapon, 0.1),
                    new TierLoot(4, ItemType.Ability, 0.1),
                    new TierLoot(9, ItemType.Armor, 0.1),
                    new TierLoot(3, ItemType.Ring, 0.05),
                    new TierLoot(10, ItemType.Armor, 0.05),
                    new TierLoot(10, ItemType.Weapon, 0.05),
                    new TierLoot(4, ItemType.Ring, 0.025)
                )
            );

    }
}