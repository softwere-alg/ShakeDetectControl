using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ShakeDetectControlSample;

public static class Assert
{
    [Conditional("DEBUG")]
    public static void AssertEx(
        [DoesNotReturnIf(false)] bool condition,
        string message = "",
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0)
    {
        if (!condition)
        {
            if (message != string.Empty)
            {
                Console.WriteLine($"Assert Fail: at {memberName} in {sourceFilePath}:line {sourceLineNumber}, {message}");
            }
            else
            {
                Console.WriteLine($"Assert Fail: at {memberName} in {sourceFilePath}:line {sourceLineNumber}");
            }
            Console.WriteLine(Environment.StackTrace);
        }
    }
}
