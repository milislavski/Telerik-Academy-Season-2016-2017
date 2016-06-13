// Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

//numbers	number as words
// 0	    Zero
// 9	    Nine
// 10	    Ten
// 12	    Twelve
// 19	    Nineteen
// 25	    Twenty five
// 98	    Ninety eight
// 98	    Ninety eight
// 273    	Two hundred and seventy three
// 400    	Four hundred
// 501    	Five hundred and one
// 617    	Six hundred and seventeen
// 711    	Seven hundred and eleven
// 999    	Nine hundred and ninety nine

function printNumberAsWords(number) {
    var firstDigit = Math.floor(number / 100) % 10,
        secondDigit = Math.floor(number / 10) % 10,
        thirdDigit = number % 10,
        numbersToTwenty = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"
            , "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"],
        tens = ["Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"],
        result;
    //result = firstDigit+'|'+secondDigit+'|'+thirdDigit;
    if(number >= 0 && number < 20){
        result = numbersToTwenty[number];
    }
    else if (number > 19 && number < 100){
        if (thirdDigit === 0) {
            result = tens[secondDigit-2];
        }
        else {
            result = tens[secondDigit-2] + ' ' + numbersToTwenty[thirdDigit].toLowerCase();
        }
    }
    else {
        if(secondDigit === 0 && thirdDigit === 0){
            result = numbersToTwenty[firstDigit] + ' hundred';
        }
        else if(secondDigit !== 0 && thirdDigit === 0){
            result = numbersToTwenty[firstDigit] + ' hundred and ' + tens[secondDigit-2].toLowerCase();
        }
        else if(secondDigit === 0 && thirdDigit !==0) {
            result = numbersToTwenty[firstDigit] + ' hundred and ' + numbersToTwenty[thirdDigit].toLowerCase();
        }
        else {
            if (secondDigit === 1){
                result = numbersToTwenty[firstDigit] + ' hundred and ' + numbersToTwenty[thirdDigit+10].toLowerCase();
            }
            else{
                result = numbersToTwenty[firstDigit] + ' hundred and ' + tens[secondDigit-2].toLowerCase() +' '+ numbersToTwenty[thirdDigit].toLowerCase();
            }
        }
    }
    return result;
}
console.log(printNumberAsWords(0));
console.log(printNumberAsWords(9));
console.log(printNumberAsWords(10));
console.log(printNumberAsWords(12));
console.log(printNumberAsWords(19));
console.log(printNumberAsWords(25));
console.log(printNumberAsWords(98));
console.log(printNumberAsWords(98));
console.log(printNumberAsWords(273));
console.log(printNumberAsWords(400));
console.log(printNumberAsWords(501));
console.log(printNumberAsWords(617));
console.log(printNumberAsWords(711));
console.log(printNumberAsWords(999));


