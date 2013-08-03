/*
 * 11, 12. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
 * x^2 + 5 = 1x^2 + 0x + 5 -> { 5, 0, 1 }
 * Extend the program to support also subtraction and multiplication of polynomials.
 * 
 * NOTE: Please, edit the array and use the appropriate method for testing.
 */

using System;

namespace PolynomialOperations
{
    class PolynomialOperations
    {
        static void PrintPolynomial(int[] poly) //Blah, a pain in the butt to write all that
        {
            int maxPow = poly.Length - 1;
            string polyToPrint = "";
            if (poly[maxPow] != 1)
                polyToPrint += poly[maxPow] + "x^" + maxPow + " ";
            else
                polyToPrint += "x^" + maxPow + " ";
            for (int i = maxPow - 1; i > 0; i--)
            {
                if (Math.Abs(poly[i]) > 1)
                {
                    if (poly[i] > 0)
                    {
                        if (i == 1)
                        {
                            polyToPrint += "+" + poly[i] + "x ";
                        }
                        else
                        {
                            polyToPrint += "+" + poly[i] + "x^" + i + " ";
                        }
                    }
                    else
                    {
                        if (i == 1)
                        {
                            polyToPrint += poly[i] + "x ";
                        }
                        else
                        {
                            polyToPrint += poly[i] + "x^" + i + " ";
                        }
                    }
                }
                else if (Math.Abs(poly[i]) == 1)
                {
                    if (poly[i] > 0)
                    {
                        if (i == 1)
                        {
                            polyToPrint += "+x ";
                        }
                        else
                        {
                            polyToPrint += "+x^" + i + " ";
                        }
                    }
                    else
                    {
                        if (i == 1)
                        {
                            polyToPrint += "-x ";
                        }
                        else
                        {
                            polyToPrint += "-x^" + i + " ";
                        }
                    }
                }
                else // poly[i] == 0
                {

                }
            }
            if (poly[0] > 0)
                polyToPrint += "+" + poly[0];
            else if (poly[0] < 0)
            {
                polyToPrint += poly[0];
            }
            Console.WriteLine(polyToPrint);
        }
        static int[] addPolynomials(int[] poly1, int[] poly2)
        {
            if (poly1.Length < poly2.Length)
            {
                for (int i = 0; i < poly1.Length; i++)
                {
                    poly2[i] += poly1[i];
                }
                return poly2;
            }
            else
            {
                for (int i = 0; i < poly2.Length; i++)
                {
                    poly1[i] += poly2[i];
                }
                return poly1;
            }
        }
        static int[] subtractPolynomials(int[] poly1, int[] poly2)
        {
            if (poly1.Length < poly2.Length)
            {
                for (int i = 0; i < poly1.Length; i++)
                {
                    poly2[i] -= poly1[i];
                }
                return poly2;
            }
            else
            {
                for (int i = 0; i < poly2.Length; i++)
                {
                    poly1[i] -= poly2[i];
                }
                return poly1;
            }
        }
        static int[] multiplyPolynomials(int[] poly1, int[] poly2)
        {
            int[] returnPoly = new int[poly1.Length + poly2.Length - 1]; // to multiply polynomials we add their exponents
            for (int i = 0; i < poly1.Length; i++)
            {
                for (int j = 0; j < poly2.Length; j++)
                {
                    int position = i + j;
                    returnPoly[position] += poly1[i] * poly2[j];
                }
            }
            return returnPoly;
        }
        static void Main()
        {
            int[] poly1 = new int[] { -5, 1, 1, 5, -6 };
            int[] poly2 = new int[] { 2, 1, -4, 3 };
            PrintPolynomial(poly1);
            Console.WriteLine("*");
            PrintPolynomial(poly2);
            Console.WriteLine("=");
            int[] result = multiplyPolynomials(poly1, poly2);
            PrintPolynomial(result);
        }
    }
}
