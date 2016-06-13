// Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius

// x	  y	     inside
// ---------------------
// 0	  1	     true
// -5	  0	     true
// -4	  5	     false
// 1.5	  -3	 true
// -4	  -3.5	 false
// 100	  -30	 false
// 0	  0	     true
// 0.2	  -0.8	 true
// 0.9	  -4.93	 false
// 2	  2.655	 true

//formula (px - cx) * (px - cx) + (py - cy) * (py - cy) <= r * r

function isInCircle(x, y, cx, cy, r) {
    cx = 0;
    cy = 0;
    r = 5;
    var isPointInCircle = (x - cx) * (x - cx) + (y - cy) * (y - cy) <= r * r;
    console.log(isPointInCircle);
}
isInCircle(0, 1);
isInCircle(-5, 0);
isInCircle(-4, 5);
isInCircle(1.5, -3);
isInCircle(-4, -3.5);
isInCircle(100, -30);
isInCircle(0, 0);
isInCircle(0.2, -0.8);
isInCircle(0.9, -4.93);
isInCircle(2, 2.655);