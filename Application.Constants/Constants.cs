namespace Application.Constants
{
    public class Constants
    {
        public const string API = "http://localhost:53120/";
        public const string MVC = "http://localhost:49805/";
        //public const string MVCSTSCallback = "https://localhost:44318/stscallback";
        public const string Angular = "http://localhost:62627/";

        public const string ClientSecret = "myrandomclientsecret";

        public const string IssuerUri = "https://CompanyIssueUriSTS/identity";
        public const string STSOrigin = "https://localhost:44300"; //identity server login
        public const string STS = STSOrigin + "/identity";
        public const string STSTokenEndpoint = STS + "/connect/token";
        //public const string STSAuthorizationEndpoint = STS + "/connect/authorize";
        //public const string STSUserInfoEndpoint = STS + "/connect/userinfo";
        //public const string STSEndSessionEndpoint = STS + "/connect/endsession";
        //public const string STSRevokeTokenEndpoint = STS + "/connect/revocation";
    }
}