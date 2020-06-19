using System;

namespace ThreadingApp
{
    public interface ILineGenerator
    {
        string[] Generate(Random random);
    }
}