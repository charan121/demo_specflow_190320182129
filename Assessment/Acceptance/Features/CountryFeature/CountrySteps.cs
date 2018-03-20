using FluentAssertions;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace Assessment
{
    /// <summary>
    /// Country API Steps for the feature
    /// </summary>
    [Binding]
    public class CountrySteps
    {
        private bool actual = false;
        private string _actualResult = "failure";
        private int borders = 0;
        private HttpStatusCode _statusCode;
        private Country _countryObj = new Country();
        private SpecFlowTests.SpecFlowTestListener _testListener = new SpecFlowTests.SpecFlowTestListener();

        [Given(@"I warm up the API")]
        public void GivenIWarmUpTheAPI()
        {
            _testListener.WriteTestOutput(" GivenIWarmUpTheAPI(): ");
        }

        [When(@"I make a request with (.*), (.*) and (.*)")]
        public void GetCountryDetails(string currency, string code, string capital)
        {
            _testListener.WriteTestOutput(" Getting Details from - api:{/rest/v2/capital/{capital} ");
            _countryObj = ScenarioUtils.GetCountryDetails(code, capital, currency);
            if (_countryObj.currencies[0].name == currency)
            {
                actual = true;
            }
            _testListener.WriteTestOutput($"result : {actual}");
        }

        [When(@"I make a request with (.*) : (.*)")]
        public void GetCountriesInRegion(string region, string param = null)
        {
            _testListener.WriteTestOutput(" Getting Details from - api:{/rest/v2/region/{region} ");
            var _listCountries = ScenarioUtils.GetCountriesInTheRegion(region);

            if (_listCountries != null)
            {
                foreach (var item in _listCountries)
                {
                    borders = Convert.ToInt16(item.borders.Count);
                    if (borders > 3)
                    {
                        actual = true;
                        break;
                    }
                }
            }
            _testListener.WriteTestOutput($"result : {actual}");
        }

        [Then(@"the case should success")]
        public void ThenTheCaseShouldSuccess()
        {
            actual.Should().BeTrue();
        }

        [Then(@"the case should failure")]
        public void ThenTheCaseShouldFailure()
        {
            actual.Should().BeFalse();
        }

        [Then(@"the system should return bordering countries more than (.*)")]
        public void GetBorderingCountryMoreThanGivenInput(int countryCount)
        {
            borders.Should().BeGreaterThan(countryCount);
        }

        [When(@"I make a request with (.*) and by (.*)")]
        public void GetCountryDetails(string code, string capital)
        {
            _testListener.WriteTestOutput(" Getting Details from - api:{/rest/v2/capital/{capital} ");
            _countryObj = ScenarioUtils.GetCountryDetails(code, capital);
            if (!string.IsNullOrEmpty(Convert.ToString(_countryObj)))
            {
                actual = true;
            }
            _testListener.WriteTestOutput($"result : {actual}");
        }

        [Then(@"the response should be the (.*)")]
        public void ThenTheResponseShouldBeThe(string result)
        {
            if (_statusCode.Should().Equals(HttpStatusCode.OK))
            {
                _actualResult = "Success";
            }
        }

        [Then(@"the response status code should be (.*)")]
        public void ThenTheResponseStatusCodeShouldeBe(HttpStatusCode statusCode)
        {
            _statusCode.Should().Equals(statusCode);
        }

    }
}
