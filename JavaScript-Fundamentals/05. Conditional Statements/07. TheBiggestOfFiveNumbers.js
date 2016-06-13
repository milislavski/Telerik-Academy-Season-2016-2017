// Write a script that finds the greatest of given 5 variables.
// Use nested if statements.

// a	  b	     c	     d	   e	   biggest
// 5	  2	     2	     4	   1	   5
// -2	 -22     1	     0	   0	   1
// -2	  4	     3	     2     0	   4
// 0	  -2.5	 0	     5	   5	   5
// -3	  -0.5	 -1.1    -2	   -0.1   -0.1

function findBiggestOfFiveNumbers(a, b, c, d, e) {
    var biggestNumber = a;
    if (b > biggestNumber) {
        biggestNumber = b;
    }

    if (c > biggestNumber) {
        biggestNumber = c;
    }

    if (d > biggestNumber) {
        biggestNumber = d;
    }

    if (e > biggestNumber) {
        biggestNumber = e;
    }
    return biggestNumber;
}
console.log(findBiggestOfFiveNumbers(5, 2, 2, 4, 1));
console.log(findBiggestOfFiveNumbers(-2, -22, 1, 0, 0));
console.log(findBiggestOfFiveNumbers(-2, 4, 3, 2, 0));
console.log(findBiggestOfFiveNumbers(0, -2.5, 0, 5, 5));
console.log(findBiggestOfFiveNumbers(-3, -0.5, -1.1, -2, -0.1));