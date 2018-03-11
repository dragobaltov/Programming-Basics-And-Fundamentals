// CPP2.cpp : Defines the entry point for the console application.
// 
#include "stdafx.h"
#include <iostream>
using namespace std;

int A[2][20];
int B[40];

void CreateAndPrintA()
{
	srand(time_t(NULL));

	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 20; j++)
		{
			A[i][j] = rand() % 100;
			cout << A[i][j] << " ";
		}

		cout << endl;
	}
}

void BubbleSortForRow1()
{
	for (int j = 0; j < 19; j++)
	{
		for (int k = 0; k < 19; k++)
		{
			if (A[0][k] > A[0][k + 1])
			{
				int initialValue = A[0][k];
				A[0][k] = A[0][k + 1];
				A[0][k + 1] = initialValue;
			}
		}
	}
}

void CreateAndPrintB()
{
	int index = 0;

	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 20; j++)
		{
			B[index] = A[i][j];
			cout << B[index] << " ";
			index++;
		}
	}

	cout << endl;
}

void SelectionSortForRow2()
{
	for (int i = 0; i < 19; i++)
	{
		int min = i;

		for (int j = i + 1; j < 20; j++)
		{
			if (A[1][min] > A[1][j])
			{
				min = j;
			}
		}

		int initialValue = A[1][min];
		A[1][min] = A[1][i];
		A[1][i] = initialValue;
	}
}

void BubbleSortForB()
{
	for (int j = 0; j < 39; j++)
	{
		for (int k = 0; k < 39; k++)
		{
			if (B[k] > B[k + 1])
			{
				int initialValue = B[k];
				B[k] = B[k + 1];
				B[k + 1] = initialValue;
			}
		}
	}
}

bool BinarySearch(int n)
{
	int left = 0;
	int mid = 0;
	int right = 39;

	while (left <= right)
	{
		mid = (left + right) / 2;

		if (B[mid] == n)
		{
			return true;
		}
		else
		{
			if (B[mid] > n)
			{
				right = mid - 1;
			}
			else
			{
				left = mid + 1;
			}
		}
	}

	return false;
}

int main() {
	CreateAndPrintA();
	BubbleSortForRow1();
	SelectionSortForRow2();
	cout << "-------------------------------" << endl;

	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 20; j++)
		{
			cout << A[i][j] << " ";
		}

		cout << endl;
	}

	cout << "-------------------------------" << endl;
	CreateAndPrintB();
	cout << "-------------------------------" << endl;
	BubbleSortForB();

	for (int i = 0; i < 40; i++)
	{
		cout << B[i] << " ";
	}

	int n;
	cout << endl << "n = ";
	cin >> n;

	if (BinarySearch(n))
	{
		cout << "The number was found" << endl;
	}
	else
	{
		cout << "The number was not found" << endl;
	}

	return 0;
}
