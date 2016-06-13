// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
// Examples:
// 
// n	Divided by 7 and 5?
// ------------------------
// 3	false
// 0	true
// 5	false
// 7	false
// 35	true
// 140	true

function canDividedBy35(number) {
    var result = false;
    if (!(number % 5) && !(number % 7)) {
        result = true;
    }
    return result;
}

console.log(canDividedBy35(3));
console.log(canDividedBy35(0));
console.log(canDividedBy35(5));
console.log(canDividedBy35(7));
console.log(canDividedBy35(35));
console.log(canDividedBy35(140));
