//my name is mohammad dehghani
//برنامه حساب کردن دترمینان

using System;

class Program {
    static void Main(string[] args) {
        int[,] matrix = new int[3, 3];
        
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write("Enter element [{0}, {1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        int determinant = (
            (matrix[0,0] * matrix[1,1] * matrix[2,2]) + 
            (matrix[0,1] * matrix[1,2] * matrix[2,0]) + 
            (matrix[0,2] * matrix[1,0] * matrix[2,1]) -
            (matrix[0,2] * matrix[1,1] * matrix[2,0]) - 
            (matrix[0,0] * matrix[1,2] * matrix[2,1]) - 
            (matrix[0,1] * matrix[1,0] * matrix[2,2])
        );
        
        
        Console.WriteLine("Determinant: {0}", determinant);
    }
}