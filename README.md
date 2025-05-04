# A Little About The Code

This file may contain code that does not follow standard best practices. This is intentional to preserve the original Codewars challenge logic, ensuring that renaming or refactoring does not break existing solutions.

## Code Standards

Some Codewars tasks specify certain structures or naming conventions that, if changed, could break the solution logic.  

E.g., `sum()` instead of `Sum()`, `total_goals` instead of `TotalGoals`.

## Performance vs. Readability

These challenges are often approached from an automated testing perspective, where readability and simplicity take priority over performance or strict design patterns.

Below are examples demonstrating two different approaches, one that prioritizes readability and another that focuses on performance.

**Example (Readability-Oriented LINQ):**

```csharp
public static BigInteger[] PowersOfTwo(int n)
{
    return Enumerable
        .Range(0, n + 1)
        .Select(i => BigInteger.Pow(2, i))
        .ToArray();
}
```
```csharp
public static string RepeatString(int n, string s) => string.Concat(Enumerable.Repeat(s, n));
```

**Example (For Maximum Performance):**

```csharp
public static BigInteger[] PowersOfTwo_ForLoop(int n)
{
    var result = new BigInteger[n + 1];
    for (int i = 0; i <= n; i++)
    {
        result[i] = BigInteger.Pow(2, i);
    }
    return result;
}
```

```csharp
public static string RepeatStr(int n, string s)
{
    if (n <= 0 || string.IsNullOrEmpty(s))
        return string.Empty;
    
    var sb = new StringBuilder();
    for (int i = 0; i < n; i++)
    {
        sb.Append(s);
    }
    return sb.ToString();
}
```

## Challenge Conditions

Certain challenges explicitly require the logic to be implemented in specific ways, which may not always be the most efficient approach.

**Example (RegEx Condition In Challenge):**

```csharp
public static int LowercaseCountCheck(string s) => Regex.Matches(s, "[a-z]").Count;
```

**Example (Better Way):**

```csharp
public static int LowercaseCountCheck(string s) => s.Count(char.IsLower);
```