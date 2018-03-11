// FactorielRecursive.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int Factoriel(int n)
{
	if (n == 1 || n == 0)
	{
		return 1;
	}
	else
	{
		return Factoriel(n - 1) * n;
	}
}

int main()
{
	int n;

	cout << "n = ";
	cin >> n;

	int factoriel = Factoriel(n);

	cout << "Factoriel ot " << n << " e " << factoriel << endl;

    return 0;
}

