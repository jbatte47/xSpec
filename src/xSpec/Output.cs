using System;

using Xunit.Abstractions;

namespace XSpec
{
  public class Output
  {
    private readonly ITestOutputHelper _helper;
    private readonly string _messageFormat;

    public Output(ITestOutputHelper helper, int depth)
    {
      _helper = helper;
      _messageFormat = string.Format("{0}{{1}}", new String(' ', depth * 2));
    }

    public void WriteLine(string message)
    {
      _helper.WriteLine(_messageFormat, message);
    }
  }
}
