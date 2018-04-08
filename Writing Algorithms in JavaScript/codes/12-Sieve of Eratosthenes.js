// 12-Sieve of Eratosthenes.js

function SieveOfEratosthenes(num){
 var primes = [];
 
 for (var i = 0; i <= num; i++){
   primes[i] = true;
 }
 
 primes[0] = false;
 primes[1] = false;
 
 for (var i = 2; i <= Math.sqrt(num); i++){
   for (var j = 2; i * j <= num ; j++){
     primes[i*j] = false;
   }
 }
 
 var identifiedPrimes = [];
 for (var i = 0; i < primes.length; i++){
   if(primes[i]) identifiedPrimes.push(i);
 }
  return identifiedPrimes; 
}

// input 1
// SieveOfEratosthenes(2);

// input 2
// SieveOfEratosthenes(40);

// input 3
// SieveOfEratosthenes(90);