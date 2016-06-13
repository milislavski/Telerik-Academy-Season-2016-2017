//  Write an expression that calculates trapezoid's area by given sides a and b and height h.
//
//  a	   b	        h	        area
//  5	   7	        12	        72
//  2	   1	        33	        49.5
//  8.5	   4.3  	    2.7	        17.28
//  100	   200	        300	        45000
//  0.222  0.333	    0.555	    0.1540125

function calculateTrapezoidArea(sideA, sideB, height) {
    var area = ((sideA + sideB) / 2) * height;
    return area;
}
console.log(calculateTrapezoidArea(5, 7, 12));
console.log(calculateTrapezoidArea(2, 1, 33));
console.log(calculateTrapezoidArea(8.5, 4.3, 2.7));
console.log(calculateTrapezoidArea(100, 200, 300));
console.log(calculateTrapezoidArea(0.222, 0.333, 0.555));