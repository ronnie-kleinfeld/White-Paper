progression_outcomes = {}


def generate_key(pass_credits, defer_credits, fail_credits):
    return f"{pass_credits:03d}{defer_credits:03d}{fail_credits:03d}"


class ProgressionOutcome:
    def __init__(self, pass_credits, defer_credits, fail_credits, message):
        self.pass_credits = pass_credits
        self.defer_credits = defer_credits
        self.fail_credits = fail_credits
        self.message = message

    def generate_key(self):
        return generate_key(self.pass_credits, self.defer_credits, self.fail_credits)


def add_progression_outcome(pass_credits, defer_credits, fail_credits, message):
    progression_outcomes[
        generate_key(pass_credits, defer_credits, fail_credits)
    ] = ProgressionOutcome(pass_credits, defer_credits, fail_credits, message)


def add_progression_outcomes():
    add_progression_outcome(120, 0, 0, "Progress")
    add_progression_outcome(100, 20, 0, "Progress (module trailer)")
    add_progression_outcome(100, 0, 20, "Progress (module trailer)")
    add_progression_outcome(80, 40, 0, "Do not Progress – module retriever")
    add_progression_outcome(80, 20, 20, "Do not Progress – module retriever")
    add_progression_outcome(80, 0, 40, "Do not Progress – module retriever")
    add_progression_outcome(60, 60, 0, "Do not progress – module retriever")
    add_progression_outcome(60, 40, 20, "Do not progress – module retriever")
    add_progression_outcome(60, 20, 40, "Do not progress – module retriever")
    add_progression_outcome(60, 0, 60, "Do not progress – module retriever")
    add_progression_outcome(40, 80, 0, "Do not progress – module retriever")
    add_progression_outcome(40, 60, 20, "Do not progress – module retriever")
    add_progression_outcome(40, 40, 40, "Do not progress – module retriever")
    add_progression_outcome(40, 20, 60, "Do not progress – module retriever")
    add_progression_outcome(40, 0, 80, "Exclude")
    add_progression_outcome(20, 100, 0, "Do not progress – module retriever")
    add_progression_outcome(20, 80, 20, "Do not progress – module retriever")
    add_progression_outcome(20, 60, 40, "Do not progress – module retriever")
    add_progression_outcome(20, 40, 60, "Do not progress – module retriever")
    add_progression_outcome(20, 20, 80, "Exclude")
    add_progression_outcome(20, 0, 100, "Exclude")
    add_progression_outcome(0, 120, 0, "Do not progress – module retriever")
    add_progression_outcome(0, 100, 20, "Do not progress – module retriever")
    add_progression_outcome(0, 80, 40, "Do not progress – module retriever")
    add_progression_outcome(0, 60, 60, "Do not progress – module retriever")
    add_progression_outcome(0, 40, 80, "Exclude")
    add_progression_outcome(0, 20, 100, "Exclude")
    add_progression_outcome(0, 0, 120, "Exclude")


def multiple_outcomes():
    while True:
        outcome_key = input_progression()
        print(progression_outcomes[outcome_key].message)
        print()
        print("Would you like to enter another set of data?")
        more = input("Enter 'y' for yes or 'q' to quit and view results: ")
        if more == "q":
            break


def input_progression():
    pass_credits = input_validation("pass")
    defer_credits = input_validation("defer")
    fail_credits = input_validation("fail")

    total = pass_credits + defer_credits + fail_credits
    if total == 120:
        return f"{pass_credits:03d}{defer_credits:03d}{fail_credits:03d}"
    else:
        print("Total incorrect")


def input_validation(verb):
    while True:
        value = input(f"Please enter your credits at {verb}: ")
        if value.isdigit():
            value = int(value)
            valid_values = [0, 20, 40, 60, 80, 100, 120]
            if value in valid_values:
                return value
            else:
                print("Out of range")
        else:
            print("Integer required")


def main():
    add_progression_outcomes()
    multiple_outcomes()


main()
