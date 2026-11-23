// Copyright (c) Charlie Poole, Rob Prouse and Contributors. MIT License - see LICENSE.txt

using System.Reflection;

namespace NUnit.Agents
{
    public class Net10Agent : NUnitAgent<Net10Agent>
    {
        private static readonly Logger log = InternalTrace.GetLogger(typeof(Net10Agent));

        public static void Main(string[] args)
        {
            log.Debug("Using nunit.agent.core version " +
                typeof(NUnitAgent<Net10Agent>).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version);
            Execute(args);
        }
    }
}
