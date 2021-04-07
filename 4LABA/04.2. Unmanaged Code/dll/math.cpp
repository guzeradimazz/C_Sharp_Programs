#include "math.h"

int Sum(int a, int b) {
    return a + b;
}

int Subtract(int a, int b) {
    return a - b;
}

int Multiply(int a, int b) {
    return a * b;
}

int Divide(int a, int b) {
    return a / b;
}

int Mod(int a, int b) {
    return a % b;
}

int Gcd(int a, int b) {

    a = Abs(a);
    b = Abs(b);

    while (a > 0 && b > 0) {
        if (a > b) {
            a %= b;
        } else {
            b %= a;
        }
    }
    
    return a + b;
}

int Min(int a, int b) {
    return a < b ? a : b;
}

int Max(int a, int b) {
    return a > b ? a : b;
}

int Abs(int a) {
    int modifier = a < 0 ? -1 : 1;
    return a * modifier;
}

int Pow(int a, int power) {

    int value = 1;

    while (power--) {
        value *= a;
    }

    return value;
}