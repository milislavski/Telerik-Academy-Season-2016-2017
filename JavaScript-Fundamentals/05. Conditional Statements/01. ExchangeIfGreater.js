//   Write an if statement that takes two double variables a and b and exchanges their values if the first one is
// greater than the second. As a result print the values a and b, separated by a space.

// a	b	  result
// 5	2	  2 5
// 3	4	  3 4
// 5.5	4.5	  4.5 5.5

function exchangeValuesIfFirstIsBigger(firstValue, secondValue) {
    var result;
    if (firstValue > secondValue) {
        result = secondValue + ' ' + firstValue;
        return result;
    } else {
        result = firstValue + ' ' + secondValue;
        return result;
    }
}

console.log(exchangeValuesIfFirstIsBigger(5,2));
console.log(exchangeValuesIfFirstIsBigger(3,4));
console.log(exchangeValuesIfFirstIsBigger(5.5,4.5));