using Xunit;
using Xunit.Abstractions;

namespace TestPatterns
{
    public class CoolReporterMessageHandler: DefaultRunnerReporterMessageHandler
    {
        public CoolReporterMessageHandler(IRunnerLogger logger) : base(logger) { }

         protected override bool Visit(ITestStarting testStarting)
         {
            Logger.LogMessage($" CooL  {Escape(testStarting.Test.DisplayName)}");
            return base.Visit(testStarting);
         }
    }
}
