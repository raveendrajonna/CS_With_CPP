// cpp-ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>



int main()
{
	char str[80];
	int i;

	printf("Enter your family name: ");
	scanf_s("%79s", str);
	printf("Enter your age: ");
	scanf_s("%d", &i);
	printf("Mr. %s , %d years old.\n", str, i);
	printf("Enter a hexadecimal number: ");
	scanf_s("%x", &i);
	printf("You have entered %#x (%d).\n", i, i);

	return 0;
}

