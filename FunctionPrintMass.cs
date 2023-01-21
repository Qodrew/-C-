void PrintArray(int[] array) {
    int count = array.Length;
    for (int i = 0; i < count; i++) {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
