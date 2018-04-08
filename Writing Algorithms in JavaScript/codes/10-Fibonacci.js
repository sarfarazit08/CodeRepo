// 10-Fibonacci.js

function Fibonacci(index){
  if (index > 0 && index <= 2 ) return 1;
  else if (index > 2) return Fibonacci(index-2) + Fibonacci(index-1);
  else console.log("No Fibonacci number for this postion.");
}

// input 1
// Fibonacci(0);

// input 2
// Fibonacci(2);

// input 3
// Fibonacci(4);

// input 4
// Fibonacci(9);