// ConsoleApplication1.cpp : Defines the entry point for the console application.
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

	int fibonacciNthNumber = Fibonacci(n);
	cout << "Fibonacci "<<n<< "th number is " << fibonacciNthNumber<<endl;

    return 0;
}

