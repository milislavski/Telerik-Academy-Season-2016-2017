//Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
// Use a switch statement.

// digit	result
// 2	    two
// 1	    one
// 0	    zero
// 5	    five
// -0.1	    not a digit
// hi	    not a digit
// 9	    nine
// 10	    not a digit

function printDigitAsWord(digit) {
    switch (digit) {
        case 0:
            return 'zero';
            break;
        case 1:
            return 'one';
            break;
        case 2:
            return 'two';
            break;
        case 3:
            return 'three';
            break;
        case 4:
            return 'four';
            break;
        case 5:
            return 'five';
            break;
        case 6:
            return 'six';
            break;
        case 7:
            return 'seven';
            break;
        case 8:
            return 'eight';
            break;
        case 9:
            return 'nine';
            break;
        default :
            return 'not a digit';
            break;
    }
}
var digits = [2, 1, 0, 5, -0.1, 'hi', 9, 10];
for (var digit in digits) {
    console.log(digits[digit] + ' --> ' + printDigitAsWord(digits[digit]));
}