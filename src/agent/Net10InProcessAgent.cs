// Copyright (c) Charlie Poole, Rob Prouse and Contributors. MIT License - see LICENSE.txt

using System;
using System.Runtime.Versioning;
using NUnit.Extensibility;

namespace NUnit.Engine.Agents
{
    [Extension(
        Description = "Agent for running tests in-process on .NET 10",
        Path ="/NUnit/Engine/AgentLaunchers")]
    [ExtensionProperty("AgentType", "LocalProcess")]
    [ExtensionProperty("TargetFramework", ".NETCoreApp,Version=v10.0")]
    public class Net10InProcessTestAgent : InProcessTestAgent
    {

        public Net10InProcessTestAgent(Guid agentId) : base(agentId)
        {
        }

        public static TestAgentType AgentType => TestAgentType.InProcess;
        public static FrameworkName TargetFramework => new FrameworkName(".NETCoreApp", new Version(10, 0, 0));
    }
}
