using ClassLibrary1.SpecflowPlugin;
using TechTalk.SpecFlow.Plugins;
using TechTalk.SpecFlow.Tracing;
using TechTalk.SpecFlow.UnitTestProvider;

[assembly: RuntimePlugin(typeof(MyFirstPlugin))]
namespace ClassLibrary1.SpecflowPlugin
{
    public class MyFirstPlugin : IRuntimePlugin
    {
        public void Initialize(
            RuntimePluginEvents runtimePluginEvents,
            RuntimePluginParameters runtimePluginParameters,
            UnitTestProviderConfiguration unitTestProviderConfiguration)
        {

            //runtimePluginEvents.CustomizeGlobalDependencies +=
            //    (s, ea) => ea.ObjectContainer.RegisterTypeAs<CustomTracer, ITestTracer>();

            runtimePluginEvents.CustomizeTestThreadDependencies +=
                (s, ea) => ea.ObjectContainer.RegisterTypeAs<MyTraceListener, ITraceListener>();
        }
    }
}