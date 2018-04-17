#!/bin/awk -f

BEGIN {
	FS = ":";
	printf("Username    Directory\n");
	printf("================================\n");
}

{
	printf("%-12s%-20s\n", $1, $6)
}
