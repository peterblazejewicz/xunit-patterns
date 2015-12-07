using System;
using Xunit;
using Xunit.Abstractions;

namespace TestPatterns
{
    public class CoolReporter: IRunnerReporter
    {
        public string Description
            => "do not show progress messages";

        public bool IsEnvironmentallyEnabled
            => false;

        public string RunnerSwitch
            => "cool";

        public IMessageSink CreateMessageHandler(IRunnerLogger logger)
            => new CoolReporterMessageHandler(logger);
    }
}
