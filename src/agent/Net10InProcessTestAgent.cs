// Copyright (c) Charlie Poole, Rob Prouse and Contributors. MIT License - see LICENSE.txt

using System;
using NUnit.Extensibility;

namespace NUnit.Engine.Agents
{
    /// <summary>
    /// Runs tests in the runner's own process under .NET 10.0. The engine selects
    /// in-process agents by an exact match on the TargetFramework property.
    /// </summary>
    [Extension(
        Description = "Agent for running tests in-process on .NET 10.0",
        Path = "/NUnit/Engine/InProcessAgents")]
    [ExtensionProperty("AgentType", "InProcess")]
    [ExtensionProperty("TargetFramework", ".NETCoreApp,Version=v10.0")]
    public class Net10InProcessTestAgent : InProcessTestAgent
    {
        public Net10InProcessTestAgent(Guid agentId) : base(agentId)
        {
        }
    }
}
