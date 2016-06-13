// Write an expression that checks if given integer is odd or even.
//Examples:
// n	Odd?
// ----------
// 3	true
// 2	false
// -2	false
// -1	true
// 0	false

function evenOrOdd(number) {
    var isOdd = false;
    if (number % 2) {
        isOdd = true
    }
    return isOdd;
}
console.log(evenOrOdd(3));
console.log(evenOrOdd(2));
console.log(evenOrOdd(-2));
console.log(evenOrOdd(-1));
console.log(evenOrOdd(0));