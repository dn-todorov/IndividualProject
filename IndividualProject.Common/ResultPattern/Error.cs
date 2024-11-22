namespace IndividualProject.Common.ResultPattern
{
    public class Error
    {
        private Error(string code,
            string description,
            ErrorType errorType)
        {
            Code = code;
            Description = description;
            ErrorType = errorType;
        }

        public string Code { get; }
        public string Description { get; }
        public ErrorType ErrorType { get; }

        public static Error Failure(string code, string description) =>
            new Error(code, description, ErrorType.Failure);

        public static Error NotFound(string code, string description) =>
            new Error(code, description, ErrorType.NotFound);

        public static Error Validation(string code, string description) =>
            new Error(code, description, ErrorType.Validation);

        public static Error Conflict(string code, string description) =>
            new Error(code, description, ErrorType.Conflict);

        public static Error AccessUnAuthorized(string code, string description) =>
            new Error(code, description, ErrorType.AccessUnAuthorized);

        public static Error AccessForbiden(string code, string description) =>
            new Error(code, description, ErrorType.AccessForbiden);
    }
}
