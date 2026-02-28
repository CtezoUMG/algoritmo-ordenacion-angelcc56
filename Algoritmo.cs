using System;
using System.Linq; // Necesario para Enumerable y ToArray()

public class Algoritmo
{
    public int[] GenerarNumeros(int n)
    {
        // Semilla fija (42) garantiza que todos los alumnos ordenen la misma secuencia
        Random r = new Random(42);
        return Enumerable.Range(0, n).Select(_ => r.Next(0, 50000)).ToArray();
    }

    public bool EstaOrdenado(int[] arr)
    {
        if (arr == null || arr.Length == 0) return true;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            // Si el actual es mayor al siguiente, no está ordenado
            if (arr[i] > arr[i + 1]) return false;
        }
        return true;
    }

    public void QuickSort(int[] arr)
    {
    QuickSort(arr, 0, arr.Length - 1);
    }

    private void QuickSort(int[] arr, int bajo, int alto)
    {
        if (bajo < alto)
        {
            int p = Particionar(arr, bajo, alto);
            QuickSort(arr, bajo, p - 1);
            QuickSort(arr, p + 1, alto);
        }
    }

    private int Particionar(int[] arr, int bajo, int alto)
    {
        int pivote = arr[alto];
        int i = bajo - 1;
        for (int j = bajo; j < alto; j++)
        {
            if (arr[j] <= pivote)
            {
                i++;
                // Intercambiar arr[i] y arr[j]
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        // Intercambiar arr[i+1] y arr[alto] (el pivote)
        int temp2 = arr[i + 1];
        arr[i + 1] = arr[alto];
        arr[alto] = temp2;
        return i + 1;
    }
    }
