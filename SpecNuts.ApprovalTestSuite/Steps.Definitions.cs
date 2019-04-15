﻿using System;
using System.Threading.Tasks;
using SpecNuts;
using SpecNuts.Json;
using TechTalk.SpecFlow;

namespace SpecResults.ApprovalTestSuite
{
	[Binding]
	public partial class Steps : ReportingStepDefinitions
	{
        private readonly ScenarioContext _scenarioContext;
        public Steps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
		public static void BeforeTestRun()
		{
			Reporters.FixedRunTime = DateTime.MinValue;
			Reporters.Add(new JsonReporter());
			IntializeApprovalTests();
		}

		[Given(@"a scenario is specified")]
		public void GivenAScenarioIsSpecified()
		{
		}

		[When(@"the tests run")]
		public async Task WhenTheTestsRun()
		{
            // Prevents CS1998
            await Task.Run(() => { });
		}

		[Then(@"a report is generated")]
		public void ThenAReportIsGenerated()
		{
		}

		[Given(@"a ""(.*)"" scenario is specified")]
		public void GivenAScenarioIsSpecified(string p0)
		{
		}

		[When(@"the tests with ""(.*)"" parameters run ""(.*)""")]
		public void WhenTheTestsWithParametersRun(string p0, string p1)
		{
		}

		[Then(@"""(.*)"" report is generated")]
		public void ThenReportIsGenerated(int p0)
		{
		}

		[When(@"a step is not implemented")]
		public void WhenAStepIsNotImplemented()
		{
			_scenarioContext.Pending();
		}

		[When]
		public void When_a_step_uses_method_name_style()
		{
		}

		[When]
		public void When_a_step_uses_method_name_style_with_a_P0(string p0)
		{
		}

		[When]
		public void When_a_step_uses_P0_with_P1_parameters(string p0, string p1)
		{
		}

		[When(@"a step throws an exception")]
		public void WhenAStepThrowsAnException()
		{
			throw new Exception("Error!");
		}

		[When(@"the a step contains a table and a ""(.*)"" param:")]
		public void WhenTheAStepContainsATableAndAParam(string p0, Table table)
		{
		}

		[When]
		public void When_a_step_uses_method_name_underscore_style_with_a_table_param_and_a_P0_param(string p0, Table table)
		{
		}

		[When(@"a child step was executed")]
		public void WhenAChildStepWasExecuted()
		{
			ReportStep(_scenarioContext, WhenTheTestsRun).Wait();
		}

		[Given(@"a ""(.*)"" scenario is specified with a multi-line argument")]
		public void GivenAScenarioIsSpecifiedWithAMulti_LineArgument(string p0, string multilineText)
		{
		}

		[When(@"the tests with multiple line parameters")]
		public void WhenTheTestsWithMultipleLineParameters(string multilineText)
		{
		}

		[Given(@"there are (.*) cucumbers")]
		public void GivenThereAreCucumbers(int p0)
		{
		}

		[When(@"I eat (.*) cucumbers")]
		public void WhenIEatCucumbers(int p0)
		{
		}

		[Then(@"I should have (.*) cucumbers")]
		public void ThenIShouldHaveCucumbers(int p0)
		{
		}
	}
}