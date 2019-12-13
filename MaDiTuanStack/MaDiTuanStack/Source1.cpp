// Cách đi của quân mã


#include<iostream>

#define SIZE 26   // kich thuoc mang 5*5+1
#define n 5   // ban co 5*5

using namespace std;

//int X[8] = { 1,2,2,1,-1,-2,-2,-1 };
//int Y[8] = { -2,-1,1,2,2,1,-1,-2 };
int X[8] = { -2, -1, 1, 2, 2, 1, -1, -2 };
int Y[8] = { 1, 2, 2, 1, -1, -2, -2, -1 };
int Table[n][n] = { 0 };
int dem = 1;
int main()
{
	for (int i = 0; i < 8; i++)
	{
		Table[2][2] = 20;
		int xx = 2 + X[i];
		int yy = 2 + Y[i];
		if (xx >= 0 && xx < n && yy >= 0 && yy < n && Table[xx][yy] == 0)
		{
			Table[xx][yy] = dem;
		}
		dem++;
	}
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			printf("%4d", Table[i][j]);
		}
		printf("\n\n");
	}
	system("pause");
	return 0;
}