using System.Collections.Generic;
using System.Text;

namespace PokeTracker.API
{
    public class URLBuilder
    {
        private const char PATH_SEPARATOR = '/';
        private const char PARAMETER_START = '?';
        private const char PARAMETER_ASSIGN = '=';
        private const char PARAMETER_SEPARATOR = '&';
        
        private string baseURL;
        private List<string> pathSegments = new();
        private Dictionary<string, string> parameters = new();
        private StringBuilder stringBuilder = new();

        public URLBuilder(string baseURL)
        {
            if (!baseURL.EndsWith(PATH_SEPARATOR))
            {
                baseURL += PATH_SEPARATOR;
            }

            this.baseURL = baseURL;
        }

        public URLBuilder AddPathSegment(string segment)
        {
            if (!string.IsNullOrEmpty(segment))
            {
                pathSegments.Add(segment);
            }

            return this;
        }

        public URLBuilder AddParameter(string key, string value)
        {
            if (!string.IsNullOrEmpty(key))
            {
                parameters[key] = value;
            }
            
            return this;
        }

        public void Clear() => stringBuilder.Clear();

        public override string ToString()
        {
            stringBuilder.Append(baseURL);
            stringBuilder.AppendJoin(PATH_SEPARATOR, pathSegments);

            if (parameters.Count == 0) return stringBuilder.ToString();

            stringBuilder.Append(PARAMETER_START);
            foreach (var parameter in parameters)
            {
                stringBuilder.AppendJoin("", parameter.Key, PARAMETER_ASSIGN, parameter.Value);
                stringBuilder.Append(PARAMETER_SEPARATOR);
            }

            return stringBuilder.ToString();
        }
    }
}
