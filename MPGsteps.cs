using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NextClassProject;
using FluentAssertions;

namespace SpecFlowProject1
{
    [Binding]
    public sealed class MPGsteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public MPGsteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Miles driven is (.*)")]
        public void GivenMilesDrivenIs(double p0)
        {
            _scenarioContext.Add("miles", p0);
        }

        [Given(@"Gallons used is (.*)")]
        public void GivenGallonsUsedIs(double p0)
        {
            _scenarioContext.Add("gallons", p0);
        }

        [When(@"calc_MPG is called")]
        public void WhenCalc_MPGIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("MPG", f.calc_MPG(_scenarioContext.Get<double>("miles"), _scenarioContext.Get<double>("gallons")));
        }

        [When(@"gasHog is called")]
        public void WhenGasHogIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("hogOrNot", f.gasHog(_scenarioContext.Get<double>("miles"), _scenarioContext.Get<double>("gallons")));
        }

        [Then(@"the fuel efficieny should be (.*)")]
        public void ThenTheFuelEfficienyShouldBe(double p0)
        {
            var m = _scenarioContext.Get<double>("MPG");
            m.Should().Be(p0);
        }

        [Then(@"the car should be (.*)")]
        public void ThenTheCarShouldBe(Boolean p0)
        {
            var m = _scenarioContext.Get<Boolean>("hogOrNot");
            m.Should().Be(p0);
        }

        [When(@"gas rewards is called")]
        public void WhenGasRewardsIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("gasPoints", f.gasPoints(_scenarioContext.Get<double>("miles"), _scenarioContext.Get<double>("gallons")));
        }

        [Then(@"the points given should be (.*)")]
        public void ThenThePointsGivenShouldBe(double p0)
        {
            var m = _scenarioContext.Get<double>("gasPoints");
            m.Should().Be(p0);
        }


    }
}
