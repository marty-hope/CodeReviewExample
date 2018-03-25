namespace CodeReviewExample
{
    public static class SkinCatOne
    {
        public static string ReturnNullMethodOne(string str)
        {
            if (str == null)
            {
                return "Null";
            }
            return str;
        }

        public static string ReturnNullMethodTwo(string str)
        {
            return str ?? "Null";
        }
    }
}
