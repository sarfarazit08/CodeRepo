// 04-Caesar Cipher.js
// also called as Shift Cipher

function caesarCipher(originalStr, num){
  num  = num % 26;
  //console.log(num)
  var lowerCaseStr = originalStr.toLowerCase();
  var alphabet = 'abcdefghijklmnopqrstuvwxyz'.split('');
  var encodedStr = '';
  
  for (var i = 0; i < lowerCaseStr.length; i++){
    
    var currentChar = lowerCaseStr[i];
    if(currentChar=== ' '){
      encodedStr += currentChar;
      continue;
    }
    
    var currentIndex = alphabet.indexOf(currentChar)
    var newIndex = currentIndex + num;
    
    if(newIndex > 25) newIndex = newIndex - 26;
    if(newIndex < 0 ) newIndex = 26 + newIndex
    
    if(originalStr[i]===originalStr[i].toUpperCase())
    {
      encodedStr += alphabet[newIndex].toUpperCase();
    }
    else  encodedStr += alphabet[newIndex]
  }
  
  return encodedStr;
}

// input 1
// caesarCipher('Hello World', 4);
 
// input 2
// caesarCipher('Hello World', -4);
 
// input 3
// caesarCipher('Hello World', 400);
 
 