/// <reference path="script.js" />

myApp.filter("gender", function () {
	return function (gender) {
		switch (gender) {
			case 0:
				return "Not disclosed";
			case 1:
				return "Male";
			case 2:
				return "Female";                    
		}
	}
});