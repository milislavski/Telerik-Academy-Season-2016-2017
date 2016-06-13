// Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
//
// x	  y	     inside K & outside of R
// ------------------
// 1	  4	     yes
// 3	  2	     yes
// 0	  1	     no
// 4	  1	     no
// 2	  0	     no
// 4	  0	     no
// 2.5	  1.5	 yes
// 3.5	  1.5	 yes
// -100	  -100	 no

function isInCircleOutRectangle(x, y) {
    var isPointInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 3 * 3,
        isOutRectangle = !(x >= -1 && x <= 5 && y <= 1 && y >= -1);
    if (isPointInCircle && isOutRectangle) {
        console.log('yes');
    }
    else {
        console.log('no');
    }
}
isInCircleOutRectangle(1, 4);
isInCircleOutRectangle(3, 2);
isInCircleOutRectangle(0, 1);
isInCircleOutRectangle(4, 1);
isInCircleOutRectangle(2, 0);
isInCircleOutRectangle(4, 0);
isInCircleOutRectangle(2.5, 1.5);
isInCircleOutRectangle(3.5, 1.5);
isInCircleOutRectangle(-100, -100);
