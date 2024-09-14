using System.Globalization;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParserMiamidade
{
    public static class Parser
    {
        public static List<string> ParseListofStrings(List<string> sourceList)
        {
            
            sourceList[7] = ConvertTo_ProperCase(sourceList[7]);
            sourceList[7] = ConvertAddressToSpecifiedFormat(sourceList[7]);

            sourceList[11] = ConvertTo_ProperCase(sourceList[11]);
            sourceList[11] = ConvertAddressToSpecifiedFormat(sourceList[11]);

            sourceList[12] = ConvertTo_ProperCase(sourceList[12]);

            sourceList[14] = ConvertTo_ProperCase(sourceList[14]);

            sourceList[18] = ConvertTo_ProperCase(sourceList[18]);
            sourceList[18] = ConvertAddressToSpecifiedFormat(sourceList[18]);
            if (sourceList[18].Contains("Llc",StringComparison.OrdinalIgnoreCase))
            {
                sourceList[18] = sourceList[18].Replace("Llc", "LLC");
            }

            sourceList[19] = ConvertTo_ProperCase(sourceList[19]);
            sourceList[19] = ConvertAddressToSpecifiedFormat(sourceList[19]);
            if (sourceList[19].Contains("Llc", StringComparison.OrdinalIgnoreCase))
            {
                sourceList[19] = sourceList[19].Replace("Llc", "LLC");
            }

            sourceList[20] = ConvertTo_ProperCase(sourceList[20]);
            sourceList[20] = ConvertAddressToSpecifiedFormat(sourceList[20]);
            if (sourceList[18].Contains("Llc", StringComparison.OrdinalIgnoreCase))
            {
                sourceList[20] = sourceList[20].Replace("Llc", "LLC");
            }

            sourceList[24] = ConvertTo_ProperCase(sourceList[24]);

            for (int i = 0; i < sourceList.Count(); i++)
            {
                var entry = sourceList[i];
                if (entry.Contains(","))
                {
                    sourceList[i] = "\"" + sourceList[i] + "\"";
                }
            }

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
