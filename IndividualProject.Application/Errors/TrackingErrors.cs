using IndividualProject.Common.ResultPattern;

namespace IndividualProject.Application.Errors
{
    public class TrackingErrors
    {
        public static Error NotFound(string id) =>
            Error.NotFound("Tracking.NotFound", $"Tracking: {id} not found");

        public static Error Conflict(string id) =>
            Error.Conflict("Tracking.Conflict", $"Tracking with ID: {id} already exists.");

        public static Error CreateFailure =>
            Error.Failure("Tracking.CreateFailure", $"Something went wrong in creating tracks");

        public static Error Updatefailure =>
            Error.Failure("Tracking.UpdateFailure", $"Something went wrong in updating tracks");

        public static Error DeleteFailure =>
            Error.Failure("Tracking.DeleteFailure", $"Something went wrong in deleting tracks");
    }
}
