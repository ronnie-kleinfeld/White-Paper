# BAD EXAMPLE OF THREADING TO LOCK BANK ACCOUNT FROM MULTIPLE DRAW
# BAD EXAMPLE OF THREADING TO LOCK BANK ACCOUNT FROM MULTIPLE DRAW
# BAD EXAMPLE OF THREADING TO LOCK BANK ACCOUNT FROM MULTIPLE DRAW
# BAD EXAMPLE OF THREADING TO LOCK BANK ACCOUNT FROM MULTIPLE DRAW

import threading
import time


class BankAccount(threading.Thread):
    account_balance = 100

    def __init__(self, name, money_request):
        threading.Thread.__init__(self)
        self.name = name
        self.money_request = money_request

    def run(self):
        thread_lock.acquire()
        BankAccount.get_money(self)
        thread_lock.release()

    @staticmethod
    def get_money(bank_account):
        print(
            "{} tries to withdrawal ${} at {}".format(
                bank_account.name,
                bank_account.money_request,
                time.strftime("%H:%M:%S", time.gmtime()),
            )
        )
        if BankAccount.account_balance - bank_account.money_request > 0:
            BankAccount.account_balance -= bank_account.money_request
            print(f"New account balance is : ${BankAccount.account_balance}")
        else:
            print("Not enough money in the account")
            print(f"Current balance : ${BankAccount.account_balance}")
        time.sleep(3)


# Create a lock to be used by threads
thread_lock = threading.Lock()
# Create new threads
doug = BankAccount("Doug", 1)
paul = BankAccount("Paul", 100)
sally = BankAccount("Sally", 50)
# Start new Threads
doug.start()
paul.start()
sally.start()
# Have threads wait for previous threads to terminate
doug.join()
paul.join()
sally.join()
print("Execution Ends")
