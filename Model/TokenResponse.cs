namespace  canasoft_ecommerce.model{
    public class TokenResponse{
        public string access_token {get;set;}
        public string event_code {get;set;}

        public int expires_in {get; set;}

        public string last_login_type {get; set;}

        public string token_type{get; set;}
    }
}
