using System;
using System.Net;

namespace Browsr
{
    // Thrown when Browsr is unable to load a web page
    class HttpException {

        private string _title;
        private string _message;

        public string Title {
            get {
                return _title;
            }
            set {
                _title = value;
            }
        }
        public string Message {
            get {
                return _message;
            }
            set {
                _message = value;
            }
        }

        public HttpException(System.Net.WebException e) {

            if(e.Status == WebExceptionStatus.ProtocolError) {

                var response = (HttpWebResponse) e.Response;
                int statusCode = (int) response.StatusCode;

                Title = statusCode.ToString();

                switch(statusCode) {

                    case 404:
                        Message = "Page not found";
                        break;

                    case 400:
                        Message = "Bad request";
                        break;

                    case 403:
                        Message = "Forbidden";
                        break;

                    default: // Catchall
                        Message = response.StatusDescription;
                        break;

                }
                
            } else
                Message = e.Status.ToString();
            
        }

    }

}
