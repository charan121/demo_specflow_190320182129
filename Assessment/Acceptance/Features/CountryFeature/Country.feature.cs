﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Assessment.Acceptance.Features.CountryFeature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Country", Description="\tAPI methods related to Country are validated here", SourceFile="Acceptance\\Features\\CountryFeature\\Country.feature", SourceLine=0)]
    public partial class CountryFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Country.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Country", "\tAPI methods related to Country are validated here", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that response by calling code and by capital city with 372", new string[] {
                "mytag"}, SourceLine=4)]
        public virtual void CheckThatResponseByCallingCodeAndByCapitalCityWith372()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check that response by calling code and by capital city with 372", new string[] {
                        "mytag"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("I warm up the API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.When("I make a request with 372 and by Tallinn", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.Then("the case should success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that response by calling code and by capital city with 371", new string[] {
                "mytag"}, SourceLine=10)]
        public virtual void CheckThatResponseByCallingCodeAndByCapitalCityWith371()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check that response by calling code and by capital city with 371", new string[] {
                        "mytag"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.Given("I warm up the API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.When("I make a request with 371 and by Tallinn", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("the case should failure", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Find Countries in regions for example for Asia", new string[] {
                "mytag"}, SourceLine=16)]
        public virtual void FindCountriesInRegionsForExampleForAsia()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find Countries in regions for example for Asia", new string[] {
                        "mytag"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("I warm up the API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.When("I make a request with Asia : null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("the system should return bordering countries more than 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Find Countries in regions for example for Europe", new string[] {
                "mytag"}, SourceLine=22)]
        public virtual void FindCountriesInRegionsForExampleForEurope()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find Countries in regions for example for Europe", new string[] {
                        "mytag"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.Given("I warm up the API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.When("I make a request with Europe : null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("the system should return bordering countries more than 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check country and expected bordering countries in given region", new string[] {
                "mytag"}, SourceLine=28)]
        public virtual void CheckCountryAndExpectedBorderingCountriesInGivenRegion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check country and expected bordering countries in given region", new string[] {
                        "mytag"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given("I warm up the API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.When("I make a request with Asia : null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("the case should success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void CheckThatResponseByCallingCodeAndByCapitalCity(string code, string capital, string result, string status, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check that response by calling code and by capital city", @__tags);
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given("I warm up the API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.When("I make a request with 371 and by Tallinn", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("the response should be the failure", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.And("the response status code shoulde be 500", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that response by calling code and by capital city, 372", new string[] {
                "mytag"}, SourceLine=42)]
        public virtual void CheckThatResponseByCallingCodeAndByCapitalCity_372()
        {
#line 35
this.CheckThatResponseByCallingCodeAndByCapitalCity("372", "Tallinn", "Success", "200", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that response by calling code and by capital city, 371", new string[] {
                "mytag"}, SourceLine=42)]
        public virtual void CheckThatResponseByCallingCodeAndByCapitalCity_371()
        {
#line 35
this.CheckThatResponseByCallingCodeAndByCapitalCity("371", "Tallinn", "failure", "500", ((string[])(null)));
#line hidden
        }
        
        public virtual void CheckThatResponseByCountryName(string name, string result, string status, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check that response by country name", @__tags);
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
 testRunner.Given("I warm up the API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
 testRunner.When("I make a request with Asia : India", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("the response should be the Success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.And("the response status code should be 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that response by country name, India", new string[] {
                "mytag"}, SourceLine=54)]
        public virtual void CheckThatResponseByCountryName_India()
        {
#line 47
this.CheckThatResponseByCountryName("India", "Success", "200", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that response by country name, USA", new string[] {
                "mytag"}, SourceLine=54)]
        public virtual void CheckThatResponseByCountryName_USA()
        {
#line 47
this.CheckThatResponseByCountryName("USA", "failure", "200", ((string[])(null)));
#line hidden
        }
        
        public virtual void UseCurrencyCodeAndProduceOneTest(string capital, string currency, string results, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use currency code and produce one test", @__tags);
#line 59
this.ScenarioSetup(scenarioInfo);
#line 60
 testRunner.Given("I warm up the API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
 testRunner.When("I make a request with Euro, 371 and Riga", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.Then("the response should be the <Result>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.And("the response status code should be <Status>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Use currency code and produce one test, Riga", new string[] {
                "mytag"}, SourceLine=66)]
        public virtual void UseCurrencyCodeAndProduceOneTest_Riga()
        {
#line 59
this.UseCurrencyCodeAndProduceOneTest("Riga", "Euro", "Success", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion