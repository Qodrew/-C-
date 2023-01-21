int[] CreateArray() {
    System.Console.Write("Задайте размерность массива: ");
    int size = int.Parse(Console.ReadLine());
    for(int i = 0; i < size; i++) {
        Console.Write($"Введите {i+1} элемент массива: ");
        arrayNum[i] = int.Parse(Console.ReadLine());
    }
    return arrayNum;
}
