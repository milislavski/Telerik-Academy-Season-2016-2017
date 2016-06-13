// Write a script that finds the biggest of three numbers.
// Use nested if statements.

// a  	 b	    c	    biggest
// 5	 2	    2   	5
// -2	 -2	    1       1
// -2	 4	    3   	4
// 0	 -2.5	5	    5
// -0.1	 -0.5	-1.1	-0.1

function returnBiggestOfThreeNumbers(firstNumber, secondNumber, thirdNumber) {
    var biggest;
    if (firstNumber > secondNumber) {
        if (firstNumber > thirdNumber) {
            biggest = firstNumber;
        }
        else {
            biggest = thirdNumber;
        }
    }
    else {
        if (secondNumber > thirdNumber) {
            biggest = secondNumber;
        }
        else {
            biggest = thirdNumber;
        }
    }
    return biggest;
}
console.log(returnBiggestOfThreeNumbers(5, 2, 2));
console.log(returnBiggestOfThreeNumbers(-2, -2, 1));
console.log(returnBiggestOfThreeNumbers(-2, 4, 3));
console.log(returnBiggestOfThreeNumbers(0, -2.5, 5));
console.log(returnBiggestOfThreeNumbers(-0.1, -0.5, -1.1));