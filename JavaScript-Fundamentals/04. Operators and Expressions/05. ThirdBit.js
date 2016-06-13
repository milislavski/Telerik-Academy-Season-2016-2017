// Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

// n	   binary representation	bit #3
// 5	   00000000 00000101	    0
// 8	   00000000 00001000	    1
// 0	   00000000 00000000	    0
// 15	   00000000 00001111	    1
// 5343	   00010100 11011111	    1
// 62241   11110011 00100001	    0

function thirdBitOfNumber(number) {
    var binaryNumber = number.toString(2),
        thirdDigit;

    while (binaryNumber.length < 16) {
        binaryNumber = '0' + binaryNumber;
    }
    thirdDigit = binaryNumber[binaryNumber.length - 4];
    return 'n -> ' + number + ' | binary representation -> ' + binaryNumber + ' | bit #3 -> ' + thirdDigit;
}
var numbers = [5, 8, 0, 15, 5343, 62241];

for (var num in numbers) {
    console.log(thirdBitOfNumber(numbers[num]));
}