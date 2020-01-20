class BankAccount():
    def __init__(self):
        self.balance = 0
        self.interest = 1.02

    def __str__(self):
        return f"Current Balance: $ {self.balance}"

    def withdraw(self, amount):
        if amount > self.balance:
            return False
        elif amount <= 0:
            return False
        else:
            return -=amount

    def deposit(self, amount):
        if amount <= 0:
            return False
        else:
            self.balance += amount
            return self.balance

    def check_balance(self):
        return self.balance

    def accumulate_interest(self):
        self.balance = self.balance * self.interest
        return self.balance


class ChildrensAccount(BankAccount):
    def __init__(self):
        super().__init__()
        self.interest = 0

    def accumulate_interest(self):
        self.balance += 10
        return self.balance


class OverdraftAccount(BankAccount):
    def __init__(self):
        super().__init__()
        self.overdraft_penalty = 40

    def withdraw(self, amount):
        if amount > self.balance:
            self.balance -= self.overdraft_penalty
            return False
        else:
            return super().withdraw(amount)

    def accumulate_interest(self):
        if self.balance <= 0:
            return self.balance
        else:
            return super().accumulate_interest()




            Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid (2010) and After Earth (2013). Jaden is also known for some of his philosophy that he delivers via Twitter. When writing on Twitter, he is known for almost always capitalizing every word.

Your task is to convert strings to how they would be written by Jaden Smith. The strings are actual quotes from Jaden Smith, but they are not capitalized in the same way he originally typed them.

Example:

def toJadenCase(NonJaden):
    return string.capwords(NonJaden)