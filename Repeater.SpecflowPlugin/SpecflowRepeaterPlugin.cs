using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Generator.Plugins;

namespace Repeater.SpecflowPlugin
{
	public class SpecflowRepeaterPlugin
		: IGeneratorPlugin
	{
		void IGeneratorPlugin.Initialize(GeneratorPluginEvents generatorPluginEvents, GeneratorPluginParameters generatorPluginParameters)
		{
			generatorPluginEvents.CustomizeDependencies += GeneratorPluginEvents_CustomizeDependencies;
		}

		private void GeneratorPluginEvents_CustomizeDependencies(object sender, CustomizeDependenciesEventArgs e)
		{
		}
	}
}
