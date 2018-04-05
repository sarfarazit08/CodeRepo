// Harmless Ransom Note Algorithm

function HarmlessRansomNote(noteText, magazineText) {
    var noteArr = noteText.split(' ');
    var magazineArr = magazineText.split(' ');
    
    var magazineObj = {};
    
    magazineArr.forEach(word => {
        if(!magazineObj[word]) magazineObj[word] = 0;
        magazineObj[word]++;
    });
    
    //console.log(magazineObj);
    
    var noteIsPossible = true;
    
    noteArr.forEach(word =>{
       if(magazineObj[word]) 
       {
            magazineObj[word]--;
           
            if(magazineObj[word] < 0 ) 
            noteIsPossible = false;
       }
       else
       {
           noteIsPossible = false;
       }
    });
    
    return noteIsPossible;
}

// input 1
HarmlessRansomNote('This is a text book store', 'This is the text which was written in the text book you bought from the book store')

// input 2
HarmlessRansomNote('This is written in the text book', 'This is the text which was written in the text book you bought from the book store')

// input 3
HarmlessRansomNote('This text book was bought from text book store', 'This is the text which was written in the text book you bought from the book store')

