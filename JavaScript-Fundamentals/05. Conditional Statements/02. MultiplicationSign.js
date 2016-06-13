// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

// a	b	   c	 result
// 5	2	   2	 +
// -2	-2	   1	 +
// -2	4	   3	 -
// 0	-2.5   4	 0
// -1	-0.5   -5.1	 -

//+++ --- +-- ++-

function printSign(firstNumber, secondNumber, thirdNumber) {
    var sign = '';
    if (firstNumber === 0 || secondNumber === 0 || thirdNumber === 0) {
        sign = '0'
    }
    else if ((firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) ||
        (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) ||
        (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0) ||
        (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)) {
        sign = '+';
    }
    else {
        sign = '-';
    }
    return sign;
}

console.log(printSign(5, 2, 2));
console.log(printSign(-2, -2, 1));
console.log(printSign(-2, 4, 3));
console.log(printSign(0, -2.5, 4));
console.log(printSign(-1, -0.5, -5.1));