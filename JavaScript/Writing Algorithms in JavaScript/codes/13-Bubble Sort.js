// 13-Bubble Sort.js

function BubbleSort(array){
 for (var i = array.length; i > 0; i--){
  for (var j = 0; j < i; j++){
    if(array[j] > array[j+1]){
      var temp = array[j];
      array[j] = array[j+1];
      array[j+1] = temp;
    }
  }
 }
  return array; 
}

// input 1
// BubbleSort([5,4,8,2,1]);

// input 2
// BubbleSort([5,4,-8,2,1]);

// input 3
// BubbleSort([5,4,8,2,1,0,2,1]);