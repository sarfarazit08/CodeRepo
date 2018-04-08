// 09-Binary Search.js

function BinarySearch(arr, key){
  var sortedArr = arr.sort();
  //console.log(sortedArr);
  
  var centerIndex = Math.floor(sortedArr.length/2);
  //console.log(centerIndex);
  
  var centerElement = sortedArr[centerIndex];
  //console.log(centerElement);
  
  if (centerElement === key) return true;
  else if (centerElement > key && sortedArr.length > 1) {
    return BinarySearch(sortedArr.splice(0, centerIndex), key);
  } 
  else if (centerElement < key && sortedArr.length > 1) {
    return BinarySearch(sortedArr.splice(centerIndex, sortedArr.length), key);
  }
  else return false;
}
// input 1
// BinarySearch([5], 5)

// input 2
// BinarySearch([2,3,4,5,6], 3)

// input 3
// BinarySearch([1,2,3,4,5,6], 5)