using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class getNumber
    {
        private static int setIndex(Color[]colorArray,Color colorVal)
        {
            for(int i = 0; i <colorArray.Length;i++)
            {
                if (colorVal == colorArray[i]) return i;
            }
            return -1;
        }

        public static int GetPairNumberFromColor(ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex =setIndex(ColorMap.colorMapMajor,pair.majorColor);
            int minorIndex =setIndex(ColorMap.colorMapMinor, pair.minorColor);

            
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * ColorMap.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
