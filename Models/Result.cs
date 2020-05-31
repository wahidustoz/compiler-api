using System;

namespace compiler_api.Models
{
    public class Result
    {
        public Guid Id { get; set; }

        public long Memory { get; set; }

        public long ExecutionTime { get; set; }

        public string Output { get; set; }

        public CompilationStatus Status { get; set; }
    }

    public enum CompilationStatus
    {
        Compiled,
        SyntaxError,
        RuntimeError,
        TimeLimit,
        MemoryLimit
    }
}