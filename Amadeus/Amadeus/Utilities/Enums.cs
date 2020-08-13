namespace Amadeus.Utilities
{
    //TODO -> Possibly change to struct, but might not be needed
    public enum ItemTypes
    {
        User,
        Script,
        Object,
        Report
    };
    public enum SaveTypes
    {
        XML,
        CSV,
        TXT

    }

    /// <summary>
    /// Converts enum values to required strings
    /// </summary>
    public static class EnumsHelper
    {
        public static string EnumToString(dynamic enumChild)
        {
            var enumPlacement = (int)enumChild;
            if (enumChild.GetType() == typeof(ItemTypes))
            {
                switch (enumPlacement)
                {
                    case 0:
                        return "\\User_Data";
                    case 1:
                        return "\\Saved_Scripts";
                    case 2:
                        return "\\Result_Objects";
                    case 3:
                        return "\\Reports";
                    default:
                        return "";
                }
            }
            else
            {
                switch (enumPlacement)
                {
                    case 0:
                        return ".xml";
                    case 1:
                        return ".csv";
                    case 2:
                        return ".txt";
                    default:
                        return "";
                }
            }
        }
    }

}
