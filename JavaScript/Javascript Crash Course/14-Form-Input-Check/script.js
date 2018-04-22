function val(form){
	if(checkEmpty(form.name)){
		if(checkEmpty(form.email)){
			return true
		}
		return false
	}
}

function checkEmpty(element){
	var s= element.value;
	if(s.length ==0){
		alert('Please fill all the details.')
		return false
	}
	else{
		return true		
	}
}