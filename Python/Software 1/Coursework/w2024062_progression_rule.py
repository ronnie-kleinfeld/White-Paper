class ProgressionRule:
    def __init__(self, pass_credits, defer_credits, fail_credits, status, description):
        self.pass_credits = pass_credits
        self.defer_credits = defer_credits
        self.fail_credits = fail_credits
        self.status = status
        # the data in Table 1 in the instructions
        self.description = description

    def __str__(self) -> str:
        return f"{self.description} - {self.status} - {self.pass_credits}, {self.defer_credits}, {self.fail_credits}"

    def to_array(self):
        return [self.pass_credits, self.defer_credits, self.fail_credits]


def generate_key(pass_credits, defer_credits, fail_credits):
    return f"{pass_credits:03d}{defer_credits:03d}{fail_credits:03d}"


progression_rules = {}


def init_progression_rule(pass_credits, defer_credits, fail_credits, status, message):
    progression_rules[
        generate_key(pass_credits, defer_credits, fail_credits)
    ] = ProgressionRule(pass_credits, defer_credits, fail_credits, status, message)


# this is the exact data as in Table 1 of the instruction for this coursework
# there are a few line with capital P and other with lower case p
# for comparison I user upper case to campare


# there is also a requirement to relate to the Progression outcome in a shorter text
# from what is in Table 1, also in the Histogram
# I infered the short text and added it to this dictionary


# the following function populate the dictionary of the rules
# this is the Business logic of the university regarding the Progression Rules
# I used a dictionary with the combined credits as the key to access the correct outcome
# with an big O1 complexity and without any if statement


def init_progression_rules():
    init_progression_rule(120, 0, 0, "Progress", "Progress")
    init_progression_rule(100, 20, 0, "Trailer", "Progress (module trailer)")
    init_progression_rule(100, 0, 20, "Trailer", "Progress (module trailer)")
    init_progression_rule(80, 40, 0, "Retriever", "Do not Progress - module retriever")
    init_progression_rule(80, 20, 20, "Retriever", "Do not Progress - module retriever")
    init_progression_rule(80, 0, 40, "Retriever", "Do not Progress - module retriever")
    init_progression_rule(60, 60, 0, "Retriever", "Do not progress - module retriever")
    init_progression_rule(60, 40, 20, "Retriever", "Do not progress - module retriever")
    init_progression_rule(60, 20, 40, "Retriever", "Do not progress - module retriever")
    init_progression_rule(60, 0, 60, "Retriever", "Do not progress - module retriever")
    init_progression_rule(40, 80, 0, "Retriever", "Do not progress - module retriever")
    init_progression_rule(40, 60, 20, "Retriever", "Do not progress - module retriever")
    init_progression_rule(40, 40, 40, "Retriever", "Do not progress - module retriever")
    init_progression_rule(40, 20, 60, "Retriever", "Do not progress - module retriever")
    init_progression_rule(40, 0, 80, "Exclude", "Exclude")
    init_progression_rule(20, 100, 0, "Retriever", "Do not progress - module retriever")
    init_progression_rule(20, 80, 20, "Retriever", "Do not progress - module retriever")
    init_progression_rule(20, 60, 40, "Retriever", "Do not progress - module retriever")
    init_progression_rule(20, 40, 60, "Retriever", "Do not progress - module retriever")
    init_progression_rule(20, 20, 80, "Exclude", "Exclude")
    init_progression_rule(20, 0, 100, "Exclude", "Exclude")
    init_progression_rule(0, 120, 0, "Retriever", "Do not progress - module retriever")
    init_progression_rule(0, 100, 20, "Retriever", "Do not progress - module retriever")
    init_progression_rule(0, 80, 40, "Retriever", "Do not progress - module retriever")
    init_progression_rule(0, 60, 60, "Retriever", "Do not progress - module retriever")
    init_progression_rule(0, 40, 80, "Exclude", "Exclude")
    init_progression_rule(0, 20, 100, "Exclude", "Exclude")
    init_progression_rule(0, 0, 120, "Exclude", "Exclude")
