f="Fizz"
b="Buzz"
[print(l) for l in [f+b if n%15==0 else f if n%3==0 else b if n%5==0 else n for n in range(101)]]
