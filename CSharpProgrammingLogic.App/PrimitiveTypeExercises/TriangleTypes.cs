﻿using LibFormatOutput;
using LibUserInput;

namespace CSharpProgrammingLogic.App.PrimitiveTypeExercises
{
    internal class TriangleTypes
    {
        internal static void Execute()
        {
            PrintTitle();
            float[] sides = GetTriangleSides();
            TriangleType type = DetermineTriangleType(sides);
            Console.WriteLine($"\nO triângulo é {type}.");

        }

        static float[] GetTriangleSides()
        {
            float[] sides = new float[3];

            for (int i = 0; i < 3; i++)
            {
                sides[i] = Receive.TriangleSide(i + 1);
            }
            return sides;
        }

        static void PrintTitle()
        {
            Console.WriteLine("\nIDENTIFICAÇÃO DE TRIÂNGULOS");
            Print.HorizontalLine();
        }

        static TriangleType DetermineTriangleType(float[] sides)
        {
            if (sides.Distinct().Count() == 1)
            {
                return TriangleType.Equilátero;
            }
            else if (sides.Distinct().Count() == 2)
            {
                return TriangleType.Isósceles;
            }
            else
            {
                return TriangleType.Escaleno;
            }
        }

        internal enum TriangleType
        {
            Equilátero,
            Isósceles,
            Escaleno
        }
    }
}