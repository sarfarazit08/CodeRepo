function confirmation(){
	var val = confirm('Are you sure you want to leave?')
	
	if(val){
		alert('GoodBye! Thank you for visiting.')
		window.location = "https://sarfarazit.wordpress.com/"
	}
	else{
		alert('Thank you for staying.')
	}
	
}