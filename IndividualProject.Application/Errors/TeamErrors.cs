using IndividualProject.Common.ResultPattern;

namespace IndividualProject.Errors
{
    public static class TeamErrors
    {
        public static Error NotFound(string id) =>
            Error.NotFound("Team.NotFound", $"Team: {id} not found");

        public static Error Conflict(string name) =>
            Error.Conflict("Team.Conflict", $"Team with Name: {name} already exists.");

        public static Error CreateFailure =>
            Error.Failure("Team.CreateFailure", $"Something went wrong in creating team");

        public static Error Updatefailure =>
            Error.Failure("Team.UpdateFailure", $"Something went wrong in updating team");

        public static Error DeleteFailure =>
            Error.Failure("Team.DeleteFailure", $"Something went wrong in deleting team");
    }
}
