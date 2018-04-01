var sum = 0;
var count = 0;
process.argv.forEach(function (val, index, array) {
  if(index > 1) {
    sum += parseInt(val);
    count ++;
  }
});
console.log(sum / count);
