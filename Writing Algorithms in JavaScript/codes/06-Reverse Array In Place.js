// 06-Reverse Array In Place.js

function revereseArrayInPlace(arr){
  
  for (var i = 0 ; i < arr.length / 2; i++){
    var temp = arr[i];
    arr[i] = arr[arr.length - 1  - i];
    arr[arr.length - 1 - i] = temp;
  }
  return arr;
}

// input 1
// revereseArrayInPlace([1,2,3,4,5]);

// input 2
// revereseArrayInPlace([5,3,2]);