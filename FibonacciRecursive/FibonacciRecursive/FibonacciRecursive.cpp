// FibonacciRecursive.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int Fibonacci(int n)
{
	if (n == 1 || n == 2)
	{
		return 1;
	}
	else
	{
		return Fibonacci(n - 1) + Fibonacci(n - 2);
	}
}

int main()
{
	int n;

	cout << "n = ";
	cin >> n;

	int number = Fibonacci(n);

	cout << "Fibonacci's " << n << "th number is " << number << endl;

    return 0;
}

