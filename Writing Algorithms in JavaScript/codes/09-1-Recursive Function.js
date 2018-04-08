// 09-1-Recursive Function.js

function factorial(num){
	if(num === 0 ) return 1;
	else if(num === 1)	  return num;
	else	{
	  return num * factorial(num - 1);
	}
}

// input 1
// factorial(0);

// input 2
// factorial(1);

// input 3
// factorial(5);