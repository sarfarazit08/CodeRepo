// 11-Memoized Fibonacci.js

function MemoizedFibonacci(index, cache){
  cache = cache || [];
  
  
  if (cache[index]) return cache[index];
  else {
    if (index < 3) return 1;
   else {
    cache[index] = MemoizedFibonacci(index-2,cache) + MemoizedFibonacci(index-1, cache);
    }
  }
  return cache[index];
}

// input 1
// MemoizedFibonacci(2);

// input 2
// MemoizedFibonacci(4);

// input 3
// MemoizedFibonacci(90);