// Sort 3 real values in descending order.
// Use nested if statements.
// Note: Don’t use arrays and the built-in sorting functionality.


// a	   b	   c	 result
// 5	   1	   2	 5 2 1
// -2	   -2	   1	 1 -2 -2
// -2	   4	   3	 4 3 -2
// 0	   -2.5	   5	 5 0 -2.5
// -1.1	-0.5   -0.1	 -0.1 -0.5 -1.1

function sortNumbersInDescending(firstNumber, secondNumber, thirdNumber) {
    var biggestNumber,
        smallestNumber,
        middleNumber,
        result;
    if (firstNumber > secondNumber) {
        if (firstNumber > thirdNumber) {
            biggestNumber = firstNumber;
            if(secondNumber > thirdNumber){
                middleNumber = secondNumber;
                smallestNumber = thirdNumber;
            }
            else {
                middleNumber = thirdNumber;
                smallestNumber = secondNumber;
            }
        }
        else {
            biggestNumber = thirdNumber;
            if (firstNumber > secondNumber){
                middleNumber = firstNumber;
                smallestNumber = secondNumber;
            }
            else {
                middleNumber = secondNumber;
                smallestNumber = firstNumber;
            }
        }
    }
    else {
        if (secondNumber > thirdNumber) {
            biggestNumber = secondNumber;
            if (firstNumber > thirdNumber){
                middleNumber = firstNumber;
                smallestNumber = thirdNumber;
            }
            else {
                middleNumber = thirdNumber;
                smallestNumber = firstNumber;
            }
        }
        else {
            biggestNumber = thirdNumber ;
            if (firstNumber > secondNumber){
                middleNumber = firstNumber;
                smallestNumber = secondNumber;
            }
            else {
                middleNumber = secondNumber;
                smallestNumber = firstNumber;
            }
        }
    }
    result = biggestNumber + ' ' + middleNumber + ' ' + smallestNumber;
    return result;
}
console.log(sortNumbersInDescending(5,1,2));
console.log(sortNumbersInDescending(-2,-2,1));
console.log(sortNumbersInDescending(-2,4,3));
console.log(sortNumbersInDescending(0,-2.5,5));
console.log(sortNumbersInDescending(-1.1,-0.5,-0.1));
