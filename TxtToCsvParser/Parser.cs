using System.Globalization;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParserMiamidade
{
    public static class Parser
    {
        public static List<string> ParseListofStrings(List<string> sourceList)
        {
            
            //if (sourceList.Count == 23)
            //{
            //    if (sourceList[4].Contains("broker", StringComparison.OrdinalIgnoreCase) ||
            //        sourceList[4].Contains("associate", StringComparison.OrdinalIgnoreCase))
            //    {
            //        var splitName = sourceList[2].Split(',');
            //        if (splitName.Count() > 1)
            //        {
            //            sourceList[2] = splitName[1] + " " + splitName[0];
            //        }
            //    }

            //    sourceList[2] = ConvertTo_ProperCase(sourceList[2]);
            //    if (sourceList[2].Contains("Llc"))
            //    {
            //        sourceList[2] = sourceList[2].Replace("Llc", "LLC");
            //    }

            //    sourceList[5] = ConvertTo_ProperCase(sourceList[5]);
            //    sourceList[5] = ConvertAddressToSpecifiedFormat(sourceList[5]);

            //    sourceList[6] = ConvertTo_ProperCase(sourceList[6]);
            //    sourceList[6] = ConvertAddressToSpecifiedFormat(sourceList[6]);

            //    sourceList[7] = ConvertTo_ProperCase(sourceList[7]);
            //    sourceList[7] = ConvertAddressToSpecifiedFormat(sourceList[7]);
            //    sourceList[8] = ConvertTo_ProperCase(sourceList[8]);

            //}
            //else
            //{
            //    // log error
            //}

            //for (int i = 0; i < sourceList.Count(); i++)
            //{
            //    var entry = sourceList[i];
            //    if (entry.Contains(","))
            //    {
            //        sourceList[i] = "\"" + sourceList[i] + "\"";
            //    }
            //}

            return sourceList;
        }

        private static string ConvertTo_ProperCase(string text)
        {
            if (!(string.IsNullOrEmpty(text) && string.IsNullOrWhiteSpace(text)))
            {
                TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                text =  myTI.ToTitleCase(text.ToLower());
            }

            return text;
        }

        private static string ConvertAddressToSpecifiedFormat(string entry)
        {
            string patternNe = @"\bNe\b";
            string patternNw = @"\bNw\b";
            string patternSw = @"\bSw\b";
            string patternSe = @"\bSe\b";
            
            if (Regex.IsMatch(entry, patternNe, RegexOptions.IgnoreCase))
            {
                entry = Regex.Replace(entry, patternNe, "NE", RegexOptions.IgnoreCase);
            }
            if (Regex.IsMatch(entry, patternNw, RegexOptions.IgnoreCase))
            {
                entry = Regex.Replace(entry, patternNw, "NW", RegexOptions.IgnoreCase);
            }
            if (Regex.IsMatch(entry, patternSw, RegexOptions.IgnoreCase))
            {
                entry = Regex.Replace(entry, patternSw, "SW", RegexOptions.IgnoreCase);
            }
            if (Regex.IsMatch(entry, patternSe, RegexOptions.IgnoreCase))
            {
                entry = Regex.Replace(entry, patternSe, "SE", RegexOptions.IgnoreCase);
            }

            return entry;
        }
    }
}
