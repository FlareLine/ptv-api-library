using Newtonsoft.Json;

using PTVWrapper.Models;

using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PTVWrapper.Request
{
    public class Request
    {

        // Base url for the PTV API
        static string API_URL = "http://timetableapi.ptv.vic.gov.au";

        /// <summary>
        /// Generate a URI signature for making API requests - a developer id and key is required
        /// </summary>
        /// <param name="re">Request to be made</param>
        /// <param name="id">Developer id</param>
        /// <param name="ky">Developer key</param>
        /// <returns>URL signature for <paramref name="re"/></returns>
        public static string GenerateSignature(string re, string id, string ky)
        {
            // Insert the base string for API calls and format the string to contain the developer id
            string url = String.Format("/v3/{0}{1}devid={2}", $"{re}", re.Contains("?") ? "&" : "?", id);

            // Create a new encoding object for string byte encoding
            ASCIIEncoding encoding = new ASCIIEncoding();

            //Encode both the developer key and the request url
            byte[] kb = encoding.GetBytes(ky);
            byte[] ub = encoding.GetBytes(url);

            // Generate the url token hash for authenticating the API request
            byte[] tb = new System.Security.Cryptography.HMACSHA1(kb).ComputeHash(ub);

            // Build the token from the bytes
            StringBuilder sb = new StringBuilder();
            Array.ForEach(tb, x => sb.Append(x.ToString("X2")));

            // Output the string from the StringBuilder
            url = String.Format("{0}{1}&signature={2}", API_URL, url, sb.ToString());

            // Return the API string
            return url;
        }

        /// <summary>
        /// Request data from the API using a pre-encoded signature string
        /// </summary>
        /// <param name="re">The request signature</param>
        /// <returns>Some data from the API based on <paramref name="re"/></returns>
        public static async Task<Payload> RequestEncFromAPI(string re)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    return JsonConvert.DeserializeObject<Payload>(await client.GetStringAsync(re), new JsonSerializerSettings
                    {
                        MissingMemberHandling = MissingMemberHandling.Ignore,
                        NullValueHandling = NullValueHandling.Ignore,
                        Error = HandleDeserializationError
                    });
                }
            } catch (HttpRequestException e)
            {
                // Couldn't retreive data from the API, either the API or your internet connection is not responding
                Debug.Write(e.StackTrace);

                // Return a blank Payload object
                return await Task.FromResult<Payload>(null);
            }
        }

        /// <summary>
        /// Override method for requesting using unencoded URIs - a developer id and key is required
        /// </summary>
        /// <param name="re">Unencoded request URI</param>
        /// <param name="id">Developer id</param>
        /// <param name="ky">Developer key</param>
        /// <returns>Some data from the API based on <paramref name="re"/></returns>
        public static async Task<Payload> RequestUnencFromAPI(string re, string id, string ky) => await RequestEncFromAPI(GenerateSignature(re, id, ky));

        /// <summary>
        /// Handle any errors regarding receiving a null objects from the API - this stops the program trying to put the null object into the results
        /// </summary>
        static void HandleDeserializationError(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs errorArgs)
        {
            var currentError = errorArgs.ErrorContext.Error.Message;
            errorArgs.ErrorContext.Handled = true;
        }
    }
}