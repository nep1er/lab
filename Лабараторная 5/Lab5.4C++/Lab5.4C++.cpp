#include <iostream>
using namespace std;

void next_permutation(char a[], int n) 
{
    int k = -1;

    for (int i = n - 2; i >= 0; --i) 
    {
        if (a[i] < a[i + 1])
        {
            k = i;
            break;
        }
    }

    int l = -1;
    for (int i = n - 1; i > k; --i) 
    {
        if (a[i] > a[k]) 
        {
            l = i;
            break;
        }
    }

    swap(a[k], a[l]);
    for (int i = k + 1, j = n - 1; i < j; ++i, --j) 
    {
        swap(a[i], a[j]);
    }
}

int main() 
{
    int n;
    cin >> n;

    char* a = new char[n];
    for (int i = 0; i < n; ++i) 
    {
        cin >> a[i];
    }

    next_permutation(a, n);

    for (int i = 0; i < n; ++i) 
    {
        cout << a[i] << ' ';
    }

    return 0;
}