# I declare that my work contains no examples of misconduct, such as plagiarism, or collusion.
# Any code taken from other sources is referenced within my code solution.
# I used the listed libraries which are common Python libraries
# I used https://stackoverflow.com to learn how to read and save data in file
# Student ID: 20240602 Ronnie Kleinfeld
# Date: Nov 11, 2023


import os
import pickle
import ProgressionRule as pr


VALID_VALUES = [0, 20, 40, 60, 80, 100, 120]
progression_rules = pr.progression_rules
progression_log = []
progression_summary = {}

# get a path for Part 3 file
current_directory = os.path.realpath(
    os.path.join(os.getcwd(), os.path.dirname(__file__))
)
FILE_NAME = "progression_data.txt"
path = os.path.join(current_directory, FILE_NAME)


def add_to_progression_log(progression_rule):
    # for Part 2
    progression_log.append(progression_rule)
    # for Part 3
    write_progression_data_to_file(progression_log)


def init_progression_summary():
    for key, value in progression_rules.items():
        progression_summary[value.message.upper()] = 0


def check_if_has_more_input() -> bool:
    print()
    print("Would you like to enter another set of data?")
    has_more = input("Enter 'y' for yes or 'q' to quit and view results: ")
    if has_more.upper() == "Q":
        return False
    elif has_more.upper() == "Y":
        return True
    else:
        print("Out of range, acceptable values are 'y' for yes ot 'q' to quit.")
        check_if_has_more_input()


def input_data():
    while True:
        pass_credits = input_credits_and_validate("pass")
        defer_credits = input_credits_and_validate("defer")
        fail_credits = input_credits_and_validate("fail")

        total_credits = pass_credits + defer_credits + fail_credits
        if total_credits == 120:
            outcome_key = pr.generate_key(pass_credits, defer_credits, fail_credits)
            progression_rule = progression_rules[outcome_key]
            progression_summary[progression_rule.message.upper()] += 1
            print(progression_rule.message)
            add_to_progression_log(progression_rule)
            if check_if_has_more_input() is False:
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
    print()
    print("Part 1: Histogram data")
    for key, value in progression_summary.items():
        print(key, value)


# for Part 2
def print_outcome_log():
    print()
    print("Part 2:")
    for index, item in enumerate(progression_log):
        print(f"{index}: {item}")


# for part 3
def write_progression_data_to_file(progression_rule):
    with open(path, "wb") as file:
        pickle.dump(progression_rule, file, pickle.HIGHEST_PROTOCOL)


def print_progression_data_from_file():
    with open(path, "rb") as file:
        items = pickle.load(file)

    print()
    print("Part 3:")
    for index, item in enumerate(items):
        print(f"{index}: {item}")


def main():
    pr.init_progression_rules()
    init_progression_summary()
    input_data()
    show_histogram()
    print_outcome_log()
    print_progression_data_from_file()


main()