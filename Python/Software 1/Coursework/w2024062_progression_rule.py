class ProgressionRule:
    def __init__(self, pass_credits, defer_credits, fail_credits, message):
        self.pass_credits = pass_credits
        self.defer_credits = defer_credits
        self.fail_credits = fail_credits
        self.message = message

    def __str__(self) -> str:
        return f"{self.message} - {self.pass_credits}, {self.defer_credits}, {self.fail_credits}"

    def to_array(self):
        return [self.pass_credits, self.defer_credits, self.fail_credits]


def generate_key(pass_credits, defer_credits, fail_credits):
    return f"{pass_credits:03d}{defer_credits:03d}{fail_credits:03d}"


progression_rules = {}


def init_progression_rule(pass_credits, defer_credits, fail_credits, message):
    progression_rules[
        generate_key(pass_credits, defer_credits, fail_credits)
    ] = ProgressionRule(pass_credits, defer_credits, fail_credits, message)


def init_progression_rules():
    init_progression_rule(120, 0, 0, "Progress")
    init_progression_rule(100, 20, 0, "Progress (module trailer)")
    init_progression_rule(100, 0, 20, "Progress (module trailer)")
    init_progression_rule(80, 40, 0, "Do not Progress - module retriever")
    init_progression_rule(80, 20, 20, "Do not Progress - module retriever")
    init_progression_rule(80, 0, 40, "Do not Progress - module retriever")
    init_progression_rule(60, 60, 0, "Do not progress - module retriever")
    init_progression_rule(60, 40, 20, "Do not progress - module retriever")
    init_progression_rule(60, 20, 40, "Do not progress - module retriever")
    init_progression_rule(60, 0, 60, "Do not progress - module retriever")
    init_progression_rule(40, 80, 0, "Do not progress - module retriever")
    init_progression_rule(40, 60, 20, "Do not progress - module retriever")
    init_progression_rule(40, 40, 40, "Do not progress - module retriever")
    init_progression_rule(40, 20, 60, "Do not progress - module retriever")
    init_progression_rule(40, 0, 80, "Exclude")
    init_progression_rule(20, 100, 0, "Do not progress - module retriever")
    init_progression_rule(20, 80, 20, "Do not progress - module retriever")
    init_progression_rule(20, 60, 40, "Do not progress - module retriever")
    init_progression_rule(20, 40, 60, "Do not progress - module retriever")
    init_progression_rule(20, 20, 80, "Exclude")
    init_progression_rule(20, 0, 100, "Exclude")
    init_progression_rule(0, 120, 0, "Do not progress - module retriever")
    init_progression_rule(0, 100, 20, "Do not progress - module retriever")
    init_progression_rule(0, 80, 40, "Do not progress - module retriever")
    init_progression_rule(0, 60, 60, "Do not progress - module retriever")
    init_progression_rule(0, 40, 80, "Exclude")
    init_progression_rule(0, 20, 100, "Exclude")
    init_progression_rule(0, 0, 120, "Exclude")
