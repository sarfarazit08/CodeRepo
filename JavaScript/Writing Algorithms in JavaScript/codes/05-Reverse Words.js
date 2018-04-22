// 05-Reverse Words.js

function reverseWords(sentence)
{
	var wordsArr = sentence.split(' ');
	var reversedWordsArr= [];
	
	wordsArr.forEach(word => {
	  var reversedWord = '';
	  for (var i = word.length - 1; i>=0 ; i--){
	    reversedWord += word[i];
	  }
	  reversedWordsArr.push(reversedWord);
	  
	});
	
	return reversedWordsArr.join(' ');
}

// input 1
// reverseWords("This is reversed words sentence")

// input 2
//reverseWords("sihT si desrever sdrow ecnetnes")

