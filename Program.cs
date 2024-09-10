void Write1ThroughN_While(int n) {
    int b = 0;
    while (b <= n) {
        Console.WriteLine(b);
        b++;
    }
}

void Write1ThroughN_For(int n) {
    for (int x=0; x <= n; x++)
        Console.WriteLine(x);
}

void WriteNThrough1_While(int n){
    int b = 1;
    while (b >= n) {
        Console.WriteLine(b);
        b--;
    }
}

void WriteNThrough1_For(int n) {
    for (int x=1; x >= n; x++)
        Console.WriteLine(x);
}

void WriteEvensThrough100() {
    for (int x=0; x <= 100; x++) {
        if (x % 2 == 0)
            Console.WriteLine(x);
    }
}

void FindSum(int n) {
    int sum = 0;
    for (int x=0; x <= n; x++) {
        sum += x;
    }
    Console.WriteLine(sum);
}

void FindSumOfEvenNumbers(int n) {
    int sum = 0;
    for (int x=0; x <= n; x++) {
        if (x % 2 == 0)
            sum += x;
    }
    Console.WriteLine(sum);
}

void FindSumOfOddNumbers(int n) {
    int sum = 0;
    for (int x=0; x <= n; x++) {
        if (x % 2 != 0)
            sum += x;
    }
    Console.WriteLine(sum);
}