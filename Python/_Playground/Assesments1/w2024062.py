VALID_VALUES = [0, 20, 40, 60, 80, 100, 120]
progression_rules = {}
progression_summary = {}


def generate_key(pass_credits, defer_credits, fail_credits):
    return f"{pass_credits:03d}{defer_credits:03d}{fail_credits:03d}"


class Progression_Rules:
    def __init__(self, pass_credits, defer_credits, fail_credits, message):
        self.pass_credits = pass_credits
        self.defer_credits = defer_credits
        self.fail_credits = fail_credits
        self.message = message


def add_progression_rule(pass_credits, defer_credits, fail_credits, message):
    progression_rules[
        generate_key(pass_credits, defer_credits, fail_credits)
    ] = Progression_Rules(pass_credits, defer_credits, fail_credits, message)


def add_progression_rules():
    add_progression_rule(120, 0, 0, "Progress")
    add_progression_rule(100, 20, 0, "Progress (module trailer)")
    add_progression_rule(100, 0, 20, "Progress (module trailer)")
    add_progression_rule(80, 40, 0, "Do not Progress - module retriever")
    add_progression_rule(80, 20, 20, "Do not Progress - module retriever")
    add_progression_rule(80, 0, 40, "Do not Progress - module retriever")
    add_progression_rule(60, 60, 0, "Do not progress - module retriever")
    add_progression_rule(60, 40, 20, "Do not progress - module retriever")
    add_progression_rule(60, 20, 40, "Do not progress - module retriever")
    add_progression_rule(60, 0, 60, "Do not progress - module retriever")
    add_progression_rule(40, 80, 0, "Do not progress - module retriever")
    add_progression_rule(40, 60, 20, "Do not progress - module retriever")
    add_progression_rule(40, 40, 40, "Do not progress - module retriever")
    add_progression_rule(40, 20, 60, "Do not progress - module retriever")
    add_progression_rule(40, 0, 80, "Exclude")
    add_progression_rule(20, 100, 0, "Do not progress - module retriever")
    add_progression_rule(20, 80, 20, "Do not progress - module retriever")
    add_progression_rule(20, 60, 40, "Do not progress - module retriever")
    add_progression_rule(20, 40, 60, "Do not progress - module retriever")
    add_progression_rule(20, 20, 80, "Exclude")
    add_progression_rule(20, 0, 100, "Exclude")
    add_progression_rule(0, 120, 0, "Do not progress - module retriever")
    add_progression_rule(0, 100, 20, "Do not progress - module retriever")
    add_progression_rule(0, 80, 40, "Do not progress - module retriever")
    add_progression_rule(0, 60, 60, "Do not progress - module retriever")
    add_progression_rule(0, 40, 80, "Exclude")
    add_progression_rule(0, 20, 100, "Exclude")
    add_progression_rule(0, 0, 120, "Exclude")


def init_progression_summary():
    for key, value in progression_rules.items():
        progression_summary[value.message.upper()] = 0


def check_if_has_more_outcomes() -> bool:
    print()
    print("Would you like to enter another set of data?")
    has_more = input("Enter 'y' for yes or 'q' to quit and view results: ")
    if has_more.upper() == "Q":
        return False
    elif has_more.upper() == "Y":
        return True
    else:
        print("Out of range, acceptable values are 'y' for yes ot 'q' to quit.")
        check_if_has_more_outcomes()


def input_data():
    while True:
        pass_credits = input_credits_and_validate("pass")
        defer_credits = input_credits_and_validate("defer")
        fail_credits = input_credits_and_validate("fail")

        total_credits = pass_credits + defer_credits + fail_credits
        if total_credits == 120:
            outcome_key = generate_key(pass_credits, defer_credits, fail_credits)
            progression_summary[progression_rules[outcome_key].message.upper()] += 1
            print(progression_rules[outcome_key].message)
            if check_if_has_more_outcomes() is False:
                break
        else:
            print("Total incorrect")


def input_credits_and_validate(verb):
    while True:
        value = input(f"Please enter your credits at {verb}: ")
        if value.isdigit():
            value = int(value)
            if value in VALID_VALUES:
                return value
            else:
                print(f"Out of range, acceptable values are {VALID_VALUES}")
        else:
            print(f"Integer required, acceptable values are {VALID_VALUES}")


def show_histogram():
    for key, value in progression_summary.items():
        print(key, value)


def main():
    add_progression_rules()
    init_progression_summary()
    input_data()
    show_histogram()


main()
