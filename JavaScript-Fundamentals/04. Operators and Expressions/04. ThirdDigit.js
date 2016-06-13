// Write an expression that checks for given integer if its third digit (right-to-left) is 7.

// Examples:
//
// n 	    Third digit 7
// ----------------------
// 5	    false
// 701	    true
// 1732	    true
// 9703	    true
// 877	    false
// 777877	false
// 9999799	true

function checkForDigit(number) {
    number = number.toString();
    if (number[number.length - 3] === '7') {
        return true;
    } else {
        return false;
    }
}

console.log(checkForDigit(5));
console.log(checkForDigit(701));
console.log(checkForDigit(1732));
console.log(checkForDigit(9703));
console.log(checkForDigit(877));
console.log(checkForDigit(777877));
console.log(checkForDigit(9999799));