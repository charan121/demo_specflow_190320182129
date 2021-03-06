﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Assessment.Services;

namespace Assessment
{
    /// <summary>
    /// This class used for scenario utility
    /// </summary>
    public static class ScenarioUtils
    {
        static string endpoint = @"http://restcountries.eu/rest/v2/";
        static string endpointURL = "";
        static Country _countryObj = null;
        static List<Country> _lstCountries = null;

        /// <summary>
        /// This method get the country details 
        /// </summary>
        /// <param name="capital">name of the capital</param>
        /// <param name="code">code of the capital</param>
        /// <returns>Country</returns>
        public static Country GetCountryDetails(string code, string capital)
        {
            endpointURL = endpoint + "capital/" + capital;
            var client = new ServiceBase(endpointURL);
            var json = client.MakeRequest();
            _countryObj = ReadToObject(json)[0];
            if (_countryObj != null)
            {
                endpointURL = endpoint + "callingcode/" + code;
                client = new ServiceBase(endpointURL);
                json = client.MakeRequest();
                var _countryObjWithCode = ReadToObject(json)[0];
                if (_countryObjWithCode.callingCodes[0].ToString() != _countryObj.callingCodes[0].ToString())
                {
                    return null;
                }
                if (_countryObjWithCode.capital != _countryObj.capital)
                {
                    return null;
                }
            }
            return _countryObj;
        }

        /// <summary>
        /// this method to get the country details
        /// </summary>
        /// <param name="currency">currency</param>
        /// <param name="capital">capital</param>
        /// <returns>Country</returns>
        public static Country GetCountryDetailsByCurrencyAndCapital(string currency, string capital)
        {
            endpointURL = endpoint + "currency/" + currency;
            var client = new ServiceBase(endpointURL);
            var json = client.MakeRequest();
            _countryObj = ReadToObject(json)[0];
            if (_countryObj != null)
            {
                endpointURL = endpoint + "capital/" + capital;
                client = new ServiceBase(endpointURL);
                json = client.MakeRequest();
                var _countryObjWithCode = ReadToObject(json)[0];
                if (_countryObjWithCode.callingCodes[0].ToString() != _countryObj.callingCodes[0].ToString())
                {
                    return null;
                }
                if (_countryObjWithCode.capital != _countryObj.capital)
                {
                    return null;
                }
            }
            return _countryObj;
        }

        /// <summary>
        /// This method get the country details
        /// </summary>
        /// <param name="name">name of the country</param>
        /// <returns>Country</returns>
        public static Country GetCountryByName(string name)
        {
            endpointURL = endpoint + "name/" + name;
            var client = new ServiceBase(endpointURL);
            var json = client.MakeRequest();
            _countryObj = ReadToObject(json)[0];
            return _countryObj;
        }

        /// <summary>
        /// Get the countries within the specified region
        /// </summary>
        /// <param name="region"></param>
        /// <returns>List<Country></returns>
        public static List<Country> GetCountriesInTheRegion(string region)
        {
            endpointURL = endpoint + "region/" + region;
            var client = new ServiceBase(endpointURL);
            var json = client.MakeRequest();
            _lstCountries = ReadToObject(json);
            return _lstCountries;
        }

        /// <summary>
        /// Deserialize a JSON stream to a User object.  
        /// </summary>
        /// <param name="json">validate json object to deserialize</param>
        /// <returns>Basket</returns>
        public static List<Country> ReadToObject(string json)
        {
            return JsonConvert.DeserializeObject<List<Country>>(json);
        }

    }
}
