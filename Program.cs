using System;
using System.Text;

namespace TransformToRot13
{
    class Program
    {
        public static string TransformToRot13(string textToTransform)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < textToTransform.Length; i++)
            {
                if (textToTransform[i] < 65 || textToTransform[i] > 90)
                {
                    result.Append(textToTransform[i]);
                }
                else if (textToTransform[i] < 78)
                {
                    result.Append((char)(textToTransform[i] + 13));
                }
                else
                {
                    result.Append((char)(textToTransform[i] - 13));
                }
            }

            return result.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\t===== Transform to ROT 13 =====\n");
            Console.Write("Enter the text to transform (We'll convert automatically in UPPERCASE) : ");
            string text = Console.ReadLine();
            Console.WriteLine(text.ToUpperInvariant() + " = " + TransformToRot13(text.ToUpperInvariant()));
        }
    }
}
