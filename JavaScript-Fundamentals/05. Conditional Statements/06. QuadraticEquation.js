// Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0
// and solves it (prints its real roots). Calculates and prints its real roots.
// Note: Quadratic equations may have 0, 1 or 2 real roots.
// a	  b	    c	  roots
// 2	  5	   -3	  x1=-3; x2=0.5
// -1	  3	    0	  x1=3; x2=0
// -0.5	  4	   -8     x1=x2=4
// 5	  2  	8	  no real roots

function solveQuadraticEquation(a, b, c) {
    var d = (b * b) - (4 * a * c),
        result,
        x1,
        x2;
    if (d < 0) {
        result = 'no real roots';
    }
    else if (d === 0) {
        x1 = (-b) / (2 * a);
        x2 = (-b) / (2 * a);
        result = 'x1=x2=' + x1;
    }
    else {
        x1 = ((-b) - Math.sqrt(d)) / (2 * a);
        x2 = ((-b) + Math.sqrt(d)) / (2 * a);
        result = 'x1=' + x1 + '; x2=' + x2;
    }
    return result;
}
console.log(solveQuadraticEquation(2, 5, -3));
console.log(solveQuadraticEquation(-1, 3, 0));
console.log(solveQuadraticEquation(-0.5, 4, -8));
console.log(solveQuadraticEquation(5, 2, 8));
