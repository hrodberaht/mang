namespace mang.Domain
{
    public class CountriesServices
    {
        public string Name { get; set; }

        public string getCountry()
        {
            string webApiKey = "";
            var api = new AllegroServiceWDSL.AllegroWebApiPortTypeClient();

            var a = api.doGetCountriesAsync(1,webApiKey);  
            return a.Result[0].countryname;
        }
    }
}