string line = Console.ReadLine();

        int[] a = line.Split(' ').Select(x => int.Parse(x)).ToArray();

        void BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }                   
                }            
            }
            for (int j = 0; j < mas.Length; j++)
            {
                Console.Write($"{mas[j]} ");
            }
        }

        BubbleSort(a);
