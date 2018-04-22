// 08-Two Sum.js

function twoSum(arr, sum){
  var numPairs = [];
  var hashArr = [];
  
  for (var i = 0; i < arr.length; i++){
    var currNum = arr[i];
    var counterpart = sum-currNum;
    
    if(hashArr.indexOf(counterpart) !== -1){
      numPairs.push([currNum,counterpart]);
    }
    hashArr.push(currNum);
  }
  return numPairs;  
}


// input 1
// twoSum([2,3,4,1,6,-1,0,5], 5)

// input 2
// twoSum([-2,3,4,-1,6,-1,0,5], 3)