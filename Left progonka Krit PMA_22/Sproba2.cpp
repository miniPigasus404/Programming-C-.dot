#include <iostream>
#include<vector>
#include<string>
using namespace std;


int main()
{
    double n;
    cout << "Print n: ";
    cin >> n;
    double h = 1 / n;


    vector<double>  a(n+1);
    vector<double>  c(n+1);
    vector<double>  b(n+1);
    vector<double>  f(n+1);
    vector<double>  y(n + 1); y[1] = 1; y[n] = 0.5f;
    vector<double>  X(n+1);
    vector<double>  yStar(n+1);

    double kapa1 = 0;
    double kapa2 = 0;
    vector<double>  alpha(n+1); 
    vector<double>  betta(n+1);



    for (int i = 1; i < n; i++) {
        a[i] = (1 / (h * h)) + (1 + i * h) / (2 * h);
        b[i] = (1 / (h * h)) - (1 + i * h) / (2 * h);
        c[i] = 1 + (2 / (h * h));
        f[i] = -2 / ((1 + i * h) * (1 + i * h) * (1 + i * h));
        X[i] = (i-1) * h;
        yStar[i] = 1 / (X[i] + 1);
    }

    alpha[n] = kapa2;
    betta[n] = y[n];
    cout << "The matrix in primary shape:" << endl;
    for (int i = 1; i < n; i++) {
        if (i == 1) {
            cout << "\t\t" << 1 << "\t" << kapa1 << endl;
        }
        cout << to_string(a[i]) << " - " << to_string(c[i]) << " + " << to_string(b[i]) << " = " << to_string(-f[i]) << endl;
        if (i == n-1) {
            cout << "\t\t\t\t" << kapa2 << "  " << y[n] << endl << endl;
        }
    }

    for (int i = n - 1; i > 0; i--) {
        alpha[i] = a[i] / (c[i] - b[i] * alpha[i + 1]);
        betta[i] = (betta[i + 1] * b[i] + f[i]) / (c[i] - b[i] * alpha[i + 1]);
    }

    for (int i = 1; i < n; i++) {
        y[i + 1] = alpha[i + 1] * y[i] + betta[i + 1];
    }

    cout << "Yi\t\t" << "Y*\n";
    for (int i = 1; i < n; i++) {
        cout << "Y " << i << ": " << y[i] << "     " << "y* " << i << ":  " << yStar[i] << endl;
    }



}

