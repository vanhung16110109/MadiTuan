#include<iostream>

#define SIZE 26   // kich thuoc mang 5*5+1
#define n 5    // ban co 5*5

using namespace std;

int X[8] = { 1,2,2,1,-1,-2,-2,-1 };
int Y[8] = { -2,-1,1,2,2,1,-1,-2 };
int Table[n][n] = { 0 };
int dem = 1;
int C[SIZE][n] = { 0 };

struct STACK
{
	int A[SIZE] = { 0 };
	int B[SIZE] = { 0 };
	int top;

};

void InitStack(STACK&myStack)
{
	myStack.top = -1;
}

int IsEmptyStack(STACK&myStack)
{
	if (myStack.top == -1)
		return 1;
	return 0;
}

int IsFullStack(STACK&myStack)
{
	if (myStack.top == SIZE - 1)
		return 1;
	return 0;
}

void xuat(int A[][n])
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
			cout << "\t" << A[i][j];
		cout << endl;
	}
	cout << endl;
	cout << endl;
}

void Push(STACK&myStack, int x, int y)
{
	if (IsFullStack(myStack))
		cout << "Full";
	else
	{
		myStack.top++;
		myStack.A[myStack.top] = x;
		myStack.B[myStack.top] = y;
		Table[x][y] = dem;
		dem++;
	}
}

void diTuan(STACK&myStack)
{
	while (dem <= SIZE)
	{
		int tempmy = myStack.top;
		int flag = false;
		for (int i = 0; i < 8; i++)
		{
			int xx = myStack.A[tempmy] + X[i];
			int yy = myStack.B[tempmy] + Y[i];
			if (xx >= 0 && xx < n && yy >= 0 && yy < n && Table[xx][yy] == 0 && C[tempmy][i] == 0)
			{
				flag = true;
				C[tempmy][i] = 1;
				Push(myStack, xx, yy);
				xuat(Table);
				break;
			}
		}
		if (dem == SIZE)
		{
			xuat(Table);
			break;
		}
		if (flag == false)
		{
			/*int dong = myStack.A[tempmy];
			int cot = myStack.B[tempmy];*/
			Table[myStack.A[tempmy]][myStack.B[tempmy]] = 0;
			for (int j = 0; j < 8; j++)
				C[tempmy + 1][j] = 0;
			myStack.top--;
			dem--;
		}
		if (dem < 1)
		{
			cout << "Can't Solve";
			break;
		}
	}
}

int main()
{
	STACK Horse;
	InitStack(Horse);
	int x, y;
	cin >> x;
	cin >> y;
	Push(Horse, x, y);
	diTuan(Horse);
	cout << endl;
	xuat(Table);
	system("pause");
	return 0;
}