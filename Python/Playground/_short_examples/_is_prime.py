def is_prime(num):
    for i in range(2, int(num / 2) + 1):
        if (num % i) == 0:
            return False
    return True


def get_primes(num):
    for i in range(1, num + 1):
        if is_prime(i):
            print(f"{i} is prime")
        else:
            print(f"{i} is NOT prime")


get_primes(100)
