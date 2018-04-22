// 07-Mean Median Mode.js

//find mean
function getMean(arr){
  var sum = 0;
  for (var i = 0; i <= arr.length - 1; i++){
    sum += arr[i];
  }
  console.log(sum)
  var mean = sum / arr.length;
  return mean;
}

//find median
function getMedian(arr){
  arr.sort(function(a, b) {return a- b});
  var median;
  
  if(arr.length % 2 !==0){
    median = arr[Math.floor(arr.length / 2)];
  } else {
    median = (arr[(arr.length/2) - 1] + arr[(arr.length/2) + 1]) / 2 ;
  }
  return median;
}

//find mode
function getMode(arr){
  var modeObj = {};
  
  arr.forEach(num => {
    if(!modeObj[num]) modeObj[num] = 0;
    modeObj[num]++;
  });
  
  var maxFreq = 0;
  var modes=[];
  for (var num in modeObj)  {
    if(modeObj[num] > maxFreq) {
      modes = [num];
      maxFreq = modeObj[num];
    } 
    else if (modeObj[num] === maxFreq) modes.push(num);
  }
  
  if(modes.length === Object.keys(modeObj).length) modes = [];
  
  return modes;
}

// find MeanMedianMode 
function MeanMedianMode(arr){
  return { 
    mean :   getMean(arr),
    mdeian : getMedian(arr),
    mode : getMode(arr)
  };
}


// input 1
// MeanMedianMode([1,2,3,4,5,5,6,3,4,7,4])

// input 2
// MeanMedianMode([1,2,3,0,5,-5,-3,3,4,7,4])

// input 3
// MeanMedianMode([8,2,3,0,5,5,-3,3,4,7,4])