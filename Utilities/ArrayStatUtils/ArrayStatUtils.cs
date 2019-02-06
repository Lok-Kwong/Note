using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using UtilExceptions;
using System.Linq.Expressions;

namespace Utilities
{
    /// <summary>
    /// An Array Utility class for statistical methodology
    /// </summary>
    public static class ArrayStatUtils
    {
        /// <summary>
        /// Finds the average of all the elements in the array.
        /// orig. author: @github.com/ssyuen
        /// </summary>
        /// <param name="a">The byte type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double Mean(this byte[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The sbyte type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double Mean(this sbyte[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The short type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double Mean(this short[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The ushort type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double Mean(this ushort[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The byte type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double Mean(this int[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The uint type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double Mean(this uint[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The long type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double Mean(this long[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The ulong type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double Mean(this ulong[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The float type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double Mean(this float[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The double type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double Mean(this double[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The char array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double Mean(this char[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// orig. author: @github.com/ssyuen
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this byte[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1:
                    return a[0];
            }
            Array.Sort(a);
            if (a.Length % 2 == 0)
            {
                int l = a[(a.Length / 2) - 1];
                int h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type sbyte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this sbyte[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
                {
                    case 0:
                        throw new IndexOutOfRangeException("Array is empty.");
                    case 1:
                        return a[0];
                }
            Array.Sort(a);
            if (a.Length % 2 == 0)
            {
                int l = a[(a.Length / 2) - 1];
                int h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }


        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this short[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
                {
                    case 0:
                        throw new IndexOutOfRangeException("Array is empty.");
                    case 1:
                        return a[0];
                }
            Array.Sort(a);
            if (a.Length % 2 == 0)
            {
                int l = a[(a.Length / 2) - 1];
                int h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type ushort</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this ushort[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
                {
                    case 0:
                        throw new IndexOutOfRangeException("Array is empty.");
                    case 1:
                        return a[0];
                }
            Array.Sort(a);
            if (a.Length % 2 == 0)
            {
                int l = a[(a.Length / 2) - 1];
                int h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this int[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1:
                    return a[0];
            }
            Array.Sort(a);
            if (a.Length % 2 == 0)
            {
                int l = a[(a.Length / 2) - 1];
                int h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }


        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type uint</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this uint[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
                {
                    case 0:
                        throw new IndexOutOfRangeException("Array is empty.");
                    case 1:
                        return a[0];
                }
            Array.Sort(a);
            if (a.Length % 2 == 0)
            {
                uint l = a[(a.Length / 2) - 1];
                uint h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this long[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
                {
                    case 0:
                        throw new IndexOutOfRangeException("Array is empty.");
                    case 1:
                        return a[0];
                }
            Array.Sort(a);
            if (a.Length % 2 == 0)
            {
                long l = a[(a.Length / 2) - 1];
                long h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type ulong</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this ulong[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
                {
                    case 0:
                        throw new IndexOutOfRangeException("Array is empty.");
                    case 1:
                        return a[0];
                }
            Array.Sort(a);
            if (a.Length % 2 == 0)
            {
                ulong l = a[(a.Length / 2) - 1];
                ulong h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this float[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
                {
                    case 0:
                        throw new IndexOutOfRangeException("Array is empty.");
                    case 1:
                        return a[0];
                }
            Array.Sort(a);
            if (a.Length % 2 == 0)
            {
                float l = a[(a.Length / 2) - 1];
                float h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this double[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
                {
                    case 0:
                        throw new IndexOutOfRangeException("Array is empty.");
                    case 1:
                        return a[0];
                }
            Array.Sort(a);
            if (a.Length % 2 == 0)
            {
                double l = a[(a.Length / 2) - 1];
                double h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type char</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this char[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
                {
                    case 0:
                        throw new IndexOutOfRangeException("Array is empty.");
                    case 1:
                        return a[0];
                }
            Array.Sort(a);
            if (a.Length % 2 == 0)
            {
                char l = a[(a.Length / 2) - 1];
                char h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }
    }//ArrayStatUtils
}//namespace Utilities
