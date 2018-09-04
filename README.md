# Halifax Code Golf

## Rules of Code Golf

- Solve problem
- Lowest character count wins*

### Try

- Make it work
- Make is small
- Make it really small
- No smaller than than I can still read it
  
#### *Small print

- File size in bytes is score. 
- Hint: Use linux line endings and ASCII text files
- Adjudicator's decision on “solution good and in the spirit of the problem posed” is final.

## Hole 1 - Ten Green Bottles

Print the following rhyme to the console

``` Console
Ten green bottles standing on the wall
Ten green bottles standing on the wall
And if one green bottle should accidentally fall,
There'll be nine green bottles standing on the wall.
```

Note: Care must be taken to match case, line endings and punctuation

## Hole 2 - FizzBuzz

### Challenge

Write a program that prints the decimal numbers from 1 to 100 inclusive. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”.

### Output

The output will be a list of numbers (and Fizzes, Buzzes and FizzBuzzes) separated by a newline (either \n or \r\n). A trailing newline is acceptable, but a leading newline is not. Apart from your choice of newline, the output should look like this:

``` Console
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
16

...

91
92
Fizz
94
Buzz
Fizz
97
98
Fizz
Buzz
```

## Hole 3 - Collatz Sequence

### Rules

- If the number is even, divide it by two
- If the number is odd, triple it and add one.
- Now, form a sequence by performing this operation repeatedly, beginning with any positive integer, and taking the result at each step as the input at the next.
- Stop when you reach 1

So the sequence starting with 13 is:

``` Console
13, 40, 20, 10, 5, 16, 8, 4, 2, 1
```

With a length of 10

See <https://en.wikipedia.org/wiki/Collatz_conjecture> for further information.

### Task

Read a number from the command line or user input and output the length of the Collatz sequence.
