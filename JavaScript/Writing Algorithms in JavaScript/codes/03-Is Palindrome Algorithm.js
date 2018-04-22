// Is Palindrome Algorithm

function IsPalindrome(str){
    var text = str.toLowerCase();
    var charArr = text.split('');
    var validCharArr = 'abcdefghijklmnopqrstuvwxyz'.split('');
    
    var letterArr = [];
    
    charArr.forEach(char => {
       if(validCharArr.indexOf(char) > -1) letterArr.push(char);
    });
    
    if(letterArr.join('') === letterArr.reverse().join(''))
        return true;
    else
        return false;
}

// input 1
//IsPalindrome('Madam')

// input 2
//IsPalindrome("Madam I'm Adam")

// input 3
//IsPalindrome("Modem")
