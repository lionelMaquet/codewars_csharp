
// https://www.codewars.com/kata/541c8630095125aba6000c00

public class Number
{
    public int DigitalRoot(long n)
    {
        long num = n;
        long total = 0;
        while (num != 0)
        {
            total += num % 10;
            num /= 10;
        }
        return total < 10 ? (int)total : DigitalRoot(total);
    }
}