using System;
namespace TaskR
{
    public class HTTPClient
    {
        private string basicAuth; //authentication information for api user:pass format
        private string apiDomain; //origin for TaskR instance, for sure its bkbe.hu

        public HTTPClient()
        {
            //read config file, store basicAuth,apiDomain
        }

        public CommandResult sendCommand(string command, string[] parameters)
        {
            //somehow process the terrible api responses we get
            //curl -u {basicAuth} -i " + apiDomain + "/api/" + parametersSeparatedWithSlash
        }
    }
}
