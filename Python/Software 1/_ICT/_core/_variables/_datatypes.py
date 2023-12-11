int1 = 5  # 5
int2 = int(54)  # 45

float1 = 5  # 5 (int)
float2 = float(56)  # 56.0

bool1 = True  # True
bool2 = False  # False
bool3 = 0  # False

from decimal import Decimal

dec = Decimal(0)
dec += Decimal("0.0111111111111111")
dec += Decimal("0.0111111111111111")
print(dec)  # 0.0222222222222222
dec -= Decimal("0.0222222222222222")
print(dec)  # 0E-16

set1 = {1, 2, 3}  # {1, 2, 3}
set2 = set([1, 1, 2, 3, 4])  # {1, 2, 3, 4}

from array import array

array1 = array("i", [1, 2, 3])
