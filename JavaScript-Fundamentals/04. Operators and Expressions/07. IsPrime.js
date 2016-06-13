// Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

// n	Prime?
// --------------
// 1	false
// 2	true
// 3	true
// 4	false
// 9	false
// 37	true
// 97	true
// 51	false
// -3	false
// 0	false

function isPrime(number) {
    var isPrime = true,
        i;
    if (number < 2) {
        return false;
    }
    for (i = 2; i <= Math.sqrt(number); i += 1) {
        if (number % i == 0) {
            isPrime = false
        }
    }
    return isPrime;
}

var numbers = [1, 2, 3, 4, 9, 37, 97, 51, -3, 0];
for (var num in numbers) {
    console.log(numbers[num] + ' is prime number -> ' + isPrime(numbers[num]));
}
