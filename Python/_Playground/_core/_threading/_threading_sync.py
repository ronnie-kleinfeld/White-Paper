import threading
import time
import random


class BankAccount(threading.Thread):
    acct_balance = 100

    def __init__(self, name, money_request):
        threading.Thread.__init__(self)
        self.name = name
        self.money_request = money_request

    def run(self):
        # Get lock to keep other threads from accessing the account
        threadLock.acquire()
        # Call the static method
        BankAccount.get_money(self)
        # Release lock so other thread can access the account
        threadLock.release()

    @staticmethod
    def get_money(customer):
        print(
            "{} tries to withdrawal ${} at {}".format(
                customer.name,
                customer.money_request,
                time.strftime("%H:%M:%S", time.gmtime()),
            )
        )
        if BankAccount.acct_balance - customer.money_request > 0:
            BankAccount.acct_balance -= customer.money_request
            print(f"New account balance is : ${BankAccount.acct_balance}")
        else:
            print("Not enough money in the account")
            print(f"Current balance : ${BankAccount.acct_balance}")
        time.sleep(3)


# Create a lock to be used by threads
threadLock = threading.Lock()
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
