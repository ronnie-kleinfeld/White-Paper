class ProgressionRule:
    def __init__(self, pass_credits, defer_credits, fail_credits, message):
        self.pass_credits = pass_credits
        self.defer_credits = defer_credits
        self.fail_credits = fail_credits
        self.message = message

    def __str__(self) -> str:
        return f"{self.message} - {self.pass_credits}, {self.defer_credits}, {self.fail_credits}"
