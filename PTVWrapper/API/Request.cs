using System;
using System.Diagnostics;
using System.Text;

namespace PTVWrapper.Request
{
    public class Request
    {
        // Developer id and key required for PTV API requests
        // Replace the empty strings with your own, or use a method to return some valid credentials
        static string DEV_ID = "";
        static string DEV_KEY = "";

        // Base url for the PTV API
        static string API_URL = "http://timetableapi.ptv.vic.gov.au";

        /// <summary>
        /// Generate a URI signature for making API requests
        /// </summary>
        /// <param name="re">Request to be made</param>
        /// <returns>URL signature for <paramref name="re"/></returns>
        public static string GenerateSignature(string re)
        {
            // Insert the base string for API calls and format the string to contain the developer id
            string url = String.Format("/v3/{0}{1}devid={2}", $"/v3/{re}", re.Contains("?") ? "&" : "?", DEV_ID);

            // Create a new encoding object for string byte encoding
            ASCIIEncoding encoding = new ASCIIEncoding();

            //Encode both the developer key and the request url
            byte[] kb = encoding.GetBytes(DEV_ID);
            byte[] ub = encoding.GetBytes(url);

            // Generate the url token hash for authenticating the API request
            byte[] tb = new System.Security.Cryptography.HMACSHA1(kb).ComputeHash(ub);

            // Build the token from the bytes
            StringBuilder sb = new StringBuilder();
            Array.ForEach(tb, x => sb.Append(x.ToString("X2")));

            // Output the string from the StringBuilder
            url = String.Format("{0}{1}&signature={2}", API_URL, url, sb.ToString());

            // Write the url to the console if debugging
#if DEBUG
            Debug.Write(url);
#endif

            // Return the API string
            return url;
        }
    }
}
