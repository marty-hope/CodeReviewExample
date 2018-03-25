using System;
using System.Text;

namespace CodeReviewExample
{
    public class SkinCatTwo
    {
        private readonly string StringToAppend = "Stuff to Add";

        public string AddStuffToStringOne(string str)
        {
            return String.Format("{0}. {1}", str, StringToAppend);
        }

        public string AddStuffToStringTwo(string str)
        {
            return $"{str}. {StringToAppend}";

        }

        public string AddStuffToStringThree(string str)
        {
            var builder = new StringBuilder();
            builder.Append(str);
            builder.Append(". ");
            builder.Append(StringToAppend);
            return builder.ToString();
        }

        public string AddStuffToStringFour(string str)
        {
            return str + " " + StringToAppend;
        }
    }
}
