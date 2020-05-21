using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
     // using exponential notation: DateTime answer = moment.AddSeconds(1e9);

     DateTime answer = moment.AddSeconds(1_000_000_000);

     return answer;
    }
}