namespace Student_Enroll_Console.Model
{
    public class Errors
    {
        public object? exception { get; set; }
        public string? errorMessage { get; set; }
    }
    public class ErrorMessage
    {
        public object? RawValue { get; set; }
        public object? AttemptedValue { get; set; }
        public List<Errors>? errors { get; set; }
        public int ValidationState { get; set; }
        public bool IsContainerNode { get; set; }
        public object? Children { get; set; }
    }

    public class Error
    {
        public ErrorMessage? error_message { get; set; }
    }
}