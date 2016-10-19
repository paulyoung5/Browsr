using System;
using System.IO;
using System.Net;
using System.Text;

namespace Browsr
{
    public class HTTP {

        public String Get(String url) {

            try {

                // Add uri scheme if necessary
                Uri addr = new UriBuilder(url).Uri;

                // Make the request, get the response
                HttpWebResponse response = HttpWebRequest.Create(addr).GetResponse() as HttpWebResponse;

                // Check the status code of the response, if its ok get the response stream
                // This is just a precaution as a exception would have been thrown
                return CheckStatus(response) ? ResponseStream(response) : null;

            } catch(WebException e) {

                // Catch web exceptions and format them nicely into a message with HttpException
                var exception = new HttpException(e);
                return exception.Title + " " + exception.Message;

            } catch(Exception e) {

                // Catch all other possible exceptions
                // This could result from the UriBuilder, etc
                return e.Message;
            }

        }

        public bool CheckStatus(HttpWebResponse res) {

            return (res.StatusCode == HttpStatusCode.OK);

        }

        public String ResponseStream(HttpWebResponse response) {

            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream;

            if (response.CharacterSet == null)
                readStream = new StreamReader(receiveStream);
            else
                readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

            String stream = readStream.ReadToEnd();

            response.Close();
            readStream.Close();

            return stream;

        }

    }
}
