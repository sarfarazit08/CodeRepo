// 15-Max Stock Profit.js

function MaxStockProfit(array){
  var maxProfit = -1;
  var buyPrice = 0;
  var sellPrice = 0;
  
  var buyPriceFlag = true;
  
  for (var i = 0; i < array.length; i++){
    if(buyPriceFlag) buyPrice = array[i];
    sellPrice = array[i+1];
    
    
    if(sellPrice < buyPrice){
      buyPriceFlag = true;
    }
    else {
      var tempProfit = sellPrice - buyPrice;
      if(tempProfit > maxProfit) maxProfit = tempProfit;
      buyPriceFlag =false;
    }
  }
  return maxProfit;
}

// input 1
// MaxStockProfit([15,41,5,0,89,23,38]);

// input 2
// MaxStockProfit([10,18,4,5,9,6,16,12]);

// input 3
// MaxStockProfit([5,4,-8,2,1,0,2,1]);