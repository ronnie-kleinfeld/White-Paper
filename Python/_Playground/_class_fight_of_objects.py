# We will create classes for both a Warrior and a Battle class
# The Warrior class will simulate both the attributes and capabilities of a Warrior
# The Battle class will however simulate the actions that occur in a battle such as starting the fight and getting the results

import random
import math


class Warrior:
    def __init__(self, name="warrior", health=0, attk_max=0, block_max=0):
        self.name = name
        self.health = health
        self.attk_max = attk_max
        self.block_max = block_max

    def attack(self):
        # random() returns a value from 0.0 to 1.0
        attk_amt = self.attk_max * (random.random() + 0.5)
        return attk_amt

    def block(self):
        # Randomly calculate how much of the attack was blocked
        block_amt = self.block_max * (random.random() + 0.5)
        return block_amt


# The Battle class will have the capability to loop until 1 Warrior dies
# The Warriors will each get a turn to attack each turn
class Battle:
    def start_fight(self, warrior1, warrior2):
        # Continue looping until a Warrior dies switching back and
        # forth as the Warriors attack each other
        while True:
            if self.get_attack_result(warrior1, warrior2) == "Game Over":
                print("Game Over")
                break

            if self.get_attack_result(warrior2, warrior1) == "Game Over":
                print("Game Over")
                break

    # Have the attack and block amounts be integers to make the results clean
    # Output the results of the fight as it goes
    # If a Warrior dies return that result to end

    def get_attack_result(self, attacker, defender):
        attacker_attack_amount = attacker.attack()
        defender_block_amount = defender.block()
        damage_2_defender = math.ceil(attacker_attack_amount - defender_block_amount)
        defender.health = defender.health - damage_2_defender

        print(
            f"{attacker.name} attacks {defender.name} deals {damage_2_defender:02d} damage, {defender.name} is down from {(defender.health + damage_2_defender):02d} to {defender.health:02d} health"
        )

        if defender.health <= 0:
            print(f"{defender.name} has Died and {attacker.name} is Victorious")
            return "Game Over"
        else:
            return "Fight Again"


thor = Warrior("111", 50, 10, 5)
loki = Warrior("222", 50, 10, 5)
battle = Battle()
battle.start_fight(thor, loki)
