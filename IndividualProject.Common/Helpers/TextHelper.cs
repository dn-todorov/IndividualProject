using System.Text.RegularExpressions;

namespace IndividualProject.Common.Helpers
{
    public static class TextHelper
    {
        public static string CamelCaseToSnakeCase(string text)
        {
            return string.IsNullOrWhiteSpace(text)
                ? null
                : Regex.Replace(text, @"([A-Z])([A-Z][a-z])|([a-z0-9])([A-Z])", "$1$3_$2$4", RegexOptions.Compiled).ToLower();
        }

        public static string CamelCaseToSentenceCase(string text)
        {
            return Regex.Replace(Regex.Replace(text, @"(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"), @"(\p{Ll})(\P{Ll})", "$1 $2");
        }

        public static string KeepOnlyDigits(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;
            var arr = text.ToCharArray();
            return new string(Array.FindAll(arr, char.IsDigit));
        }

        public static string TitleCase(string text)
        {
            return string.IsNullOrEmpty(text)
                ? text
                : text.Substring(0, 1).ToUpperInvariant() + text.Substring(1);
        }

        public static string SanitizeString(string inputString)
        {
            return string.IsNullOrWhiteSpace(inputString) ? null : inputString.Trim();
        }

        public static string FormatBool(bool? boolean)
        {
            return boolean.HasValue && boolean.Value ? "Yes" : "No";
        }

        public static string NormaliseEmail(string email)
        {
            email = SanitizeString(email);
            if (string.IsNullOrWhiteSpace(email))
                return null;

            if (email.Contains("/"))
                email = SanitizeString(email.Split('/').FirstOrDefault());

            if (string.IsNullOrWhiteSpace(email))
                return null;

            var regex = Regex.Match(email, @"^[\S]{2,}@[\S]{2,}\.{1,}[\S]{2,}", RegexOptions.Compiled);
            return regex.Success ? regex.Value.ToLowerInvariant() : null;
        }

        public static string GetInitial(string str)
        {
            str = SanitizeString(str);
            return string.IsNullOrWhiteSpace(str) ? null : str.Substring(0, 1).ToUpperInvariant();
        }

        public static string GetPersonInitials(string personFullName)
        {
            if (string.IsNullOrWhiteSpace(personFullName))
                return string.Empty;

            return personFullName.Contains(",")
                ? Regex.Replace(personFullName, @"^([A-Z])[\s\S]*,+[\s\S]*([A-Z])[\s\S]*", "$2 $1", RegexOptions.Compiled)
                : Regex.Replace(personFullName, @"^([A-Z])[\s\S]*([A-Z])[\s\S]*", "$1 $2", RegexOptions.Compiled);
        }
    }
}
