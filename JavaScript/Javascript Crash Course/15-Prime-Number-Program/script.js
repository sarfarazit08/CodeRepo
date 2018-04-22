function chk_prime_num(form){
	var num = form.num.value
	var result = 0
	var numArray = new Array()
	var arrayCounter = 0
	
	for (i =2; i < num ; i++){
		result = num / i
		if( parseInt(result) - result == 0){
			numArray[arrayCounter] = result
			arrayCounter++
		}
	}
	
	if(arrayCounter > 0){
		show(arrayCounter, numArray, num)
	}else{
		document.write(num + " is a prime number.")
	}
}

function show(arrayCounter, numArray, num){
	document.write("<br /> The number "+ num +" is <b>NOT</b> a PRIME NUMBER <br />")
	
	document.write("<br/>Divisible by<br/><ul>")
	numArray.sort(ascending)	
	for(i=0; i<arrayCounter; i++){
		document.write("<li><b>"+numArray[i]+"</b>&nbsp;&nbsp;&nbsp;" + num + 
		"/" +numArray[i]+ " = "	+ 
		num/numArray[i] + "</li>" )
	}
	
	document.write("</ul>")	
}

function ascending(a,b){
	return a-b
}
