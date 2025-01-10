using System;


void factorial (int x) {
	int tmp = x;
	if (x > 0) {
		for (int i=x-1; i>0; i--) {
			tmp *= i;
		}
	} else {
		for (int i=x+1; i<0; i++) {
			tmp *= i;
		}
	}
	Console.WriteLine(tmp);
}


factorial(5);
factorial(-5);


