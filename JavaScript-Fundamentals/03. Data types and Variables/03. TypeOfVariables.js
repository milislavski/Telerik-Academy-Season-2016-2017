// Try typeof on all variables you created.

var thisIsString = 'This is first homework from JavaScript Fundamentals course.',
    thisIsIntegerNumber = 2016,
    thisIsFloatNumber = 4.20,
    thisIsBoolean = true,
    thisIsArray = ['JavaScript',2016,thisIsBoolean],
    thisIsObject = {
        academy: 'Telerik',
        course: 'JavaScript Fundamentals'
    },
    thisIsFunction = function () {
        return 'This is my first javascript function.';
    },
    thisIsNull = null,
    thisIsUndefined = undefined;

console.log('thisIsString is ' + typeof thisIsString);
console.log('thisIsIntegerNumber is ' + typeof thisIsIntegerNumber);
console.log('thisIsFloatNumber is ' + typeof thisIsFloatNumber);
console.log('thisIsBoolean is ' + typeof thisIsBoolean);
console.log('thisIsArray is ' + typeof thisIsArray);
console.log('thisIsObject is ' + typeof thisIsObject);
console.log('thisIsFunction is ' + typeof thisIsFunction);
console.log('thisIsNull is ' + typeof thisIsNull);
console.log('thisIsUndefined is ' + typeof thisIsUndefined);


