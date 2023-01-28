int[,] Prod2Array (int [,] input1Array, int [,] input2Array) {
    int[,] arrayProd = new int[input1Array.GetLength(0), input1Array.GetLength(1)];
    if (input1Array.GetLength(1) != input2Array.GetLength(0)) {
        Console.WriteLine("Матрицы нельзя перемножить");
    }
    else {
        for (int i = 0; i < input1Array.GetLength(0); i++)
        {
            for (int j = 0; j < input2Array.GetLength(1); j++)
            {
                for (int k = 0; k < input2Array.GetLength(0); k++)
                {
                    arrayProd[i, j] += input1Array[i,k] * input2Array[k, j];
                }
            }
        }
    }
    return arrayProd;
}
