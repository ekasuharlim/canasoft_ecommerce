using RestSharp;
using RestSharp.Authenticators;
using System.Text.Json;
using System.Text.Json.Serialization;
using canasoft_ecommerce.model;

namespace  canasoft_ecommerce
{
        public class CanasoftEcom
        {
            public CanasoftEcom()
            {
            }

            public TokenResponse GetToken(){
                var client = new RestClient("https://accounts.tokopedia.com/token?grant_type=client_credentials");
                client.Authenticator = new HttpBasicAuthenticator("89fbe60ae62649e38f210242a451be5e","96f729a8b36948a18e16e8046424f4c7");
                var request = new RestRequest(){
                    Method = Method.POST                
                };
                request.AddHeader("Content-Type","application/x-www-form-urlencoded");
                request.AddHeader("Accept","application/json");
                var jsonResponse = client.Execute(request).Content;
                var result = JsonSerializer.Deserialize<TokenResponse>(jsonResponse);                
                return result;
            }
        }    
}
