// 14-Merge Sort.js

function MergeSort(array){
  
  if(array.length < 2) return array;
  var midIndex = Math.floor(array.length / 2);
  var arr1 = array.slice(0,midIndex);
  var arr2 = array.slice(midIndex, array.length);
  
  return merge(MergeSort(arr1), MergeSort(arr2));
}

function merge(arr1, arr2){
  var sortedArr = []  ;
  
  while(arr1.length && arr2.length){
    var minElement;
    if(arr1[0] < arr2[0]) minElement = arr1.shift();
    else minElement = arr2.shift();
    sortedArr.push(minElement);
  }
  
  if(arr1.length) sortedArr = sortedArr.concat(arr1);
  else sortedArr = sortedArr.concat(arr2);
  
  return sortedArr;
}

// input 1
// MergeSort([15,41,-5,0,89,-23,38]);

// input 2
// MergeSort([5,4,-8,2,1,0]);

// input 3
// MergeSort([5,4,8,2,1,0,2,1]);