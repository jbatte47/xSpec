using System;

namespace XSpec
{
  public class Step
  {
    private readonly Action _setup;
    private readonly Output _output;
    private readonly string _title;

    public Step(string title, Action setup, Output output)
    {
      _output = output;
      _setup = setup;
      _title = title;
    }

    public void Run()
    {

    }
  }
}
