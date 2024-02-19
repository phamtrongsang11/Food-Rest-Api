using ErrorOr;

namespace BuberBreakfast.ServicesErrors;

public static class Errors{
    public static class Breakfast{
        public static Error NotFound => Error.NotFound(
            code: "Breakfast.NotFound",
            description: "Breakfast not found"
        );

        public static Error InvalidName => Error.Validation(
            code: "Breakfast.InvalidName",
            description: $"Breakfast name must be at least {Models.Breakfast.MinNameLength} and at most {Models.Breakfast.MaxNameLength}"
        );
        public static Error InvalidDescripton => Error.Validation(
            code: "Breakfast.InvalidDescripton",
            description: $"Breakfast descripton must be at least {Models.Breakfast.MinNameLength} and at most {Models.Breakfast.MaxNameLength}"
        );
    }
}