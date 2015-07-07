using Xunit;
using Xunit.Abstractions;

namespace XSpec
{
  public abstract class Spec
  {
    private readonly ITestOutputHelper _output;

    protected void Describe(string text, Action setup)
    {

    }
  }
}
