/*
	prime number include 1, 2
	prime number can't be divided remainder is 0, from (n-1) to 2
*/

using System;

bool check_prime (int x) {
	for (int i = x-1; i >= 2; i--) {
		if (x % i == 0) {
			Console.WriteLine(x + " is not a prime number!");
			return false;
		}
		
	}

	Console.WriteLine(x + " is a prime number!");
	return true;
}

check_prime(25);



