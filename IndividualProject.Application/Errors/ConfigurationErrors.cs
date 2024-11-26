﻿using IndividualProject.Common.ResultPattern;

namespace IndividualProject.Errors
{
    //TODO
    //DELETE IN THE FUTURE(USED ONLY FOR TESTING THE TEAM SERVICE)
    public static class ConfigurationErrors
    {
        public static Error NotFound(string id) =>
            Error.NotFound("Configurations.NotFound", $"Configuration: {id} not found");

        public static Error Conflict(string name) =>
            Error.Conflict("Configurations.Conflict", $"Configuration with Name: {name} already exists.");

        public static Error CreateFailure =>
            Error.Failure("Configurations.CreateFailure", $"Something went wrong in creating configuration");

        public static Error Updatefailure =>
            Error.Failure("Configurations.UpdateFailure", $"Something went wrong in updating configuration");

        public static Error DeleteFailure =>
            Error.Failure("Configurations.DeleteFailure", $"Something went wrong in deleting configuration");
    }
}
