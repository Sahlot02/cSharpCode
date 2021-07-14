using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorCodingManual
    {
        public static void printColorManual()
        {
            System.Console.WriteLine("     Color Coding Manual     ");
            int numricValueOfColorPair = 1;
            int totalMajorColor = 5;
            int totalMinorColor = 5;
            System.Console.WriteLine("Number  Major Color  Minor Color");
            for(int i = 0; i < totalMajorColor; i++)
            {
                for(int j = 0; j < totalMinorColor; j++)
                {
                    ColorPair color = new ColorPair {majorColor=ColorMap.colorMapMajor[i],minorColor=ColorMap.colorMapMinor[j] };
                    Console.WriteLine(" {0}        {1}          {2}",numricValueOfColorPair,ColorMap.colorMapMajor[i].Name,ColorMap.colorMapMinor[j].Name);
                    int correctPairNumber = getNumber.GetPairNumberFromColor(color);
                    Debug.Assert(numricValueOfColorPair == correctPairNumber);
                    numricValueOfColorPair++;
                }
            }
        }
            
    }
}
