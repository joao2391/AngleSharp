﻿using System;

namespace AngleSharp
{
    /// <summary>
    /// The collection of (known / used) header names.
    /// </summary>
    static class Headers
    {
        #region General-Headers

        /// <summary>
        /// Tells all caching mechanisms from server to client or vice-versa
        /// whether they may cache this object. It is measured in seconds.
        /// e.g. Cache-Control: no-cache
        /// e.g. Cache-Control: max-age=3600
        /// </summary>
        public const String CACHE_CONTROL = "Cache-Control";

        /// <summary>
        /// Options that are desired for the connection,
        /// e.g. Connection: keep-alive
        /// e.g. Connection: close
        /// </summary>
        public const String CONNECTION = "Connection";

        /// <summary>
        /// The length of the request/response body in octets (8-bit bytes)
        /// Content-Length: 348
        /// </summary>
        public const String CONTENT_LENGTH = "Content-Length";

        /// <summary>
        /// A Base64-encoded binary MD5 sum of the content of the response,
        /// e.g. Content-MD5: Q2hlY2sgSW50ZWdyaXR5IQ==
        /// </summary>
        public const String CONTENT_MD5 = "Content-MD5";

        /// <summary>
        /// The MIME type of this content (requests use this only with POST / PUT methods),
        /// e.g. Content-Type: application/x-www-form-urlencoded
        /// e.g. Content-Type: text/html; charset=utf-8
        /// </summary>
        public const String CONTENT_TYPE = "Content-Type";

        /// <summary>
        /// The date and time that the message was sent,
        /// e.g. Date: Tue, 15 Nov 1994 08:12:31 GMT
        /// </summary>
        public const String DATE = "Date";

        /// <summary>
        /// Implementation-specific headers that may have various effects anywhere along the
        /// request-response chain.
        /// e.g. Pragma: no-cache
        /// </summary>
        public const String PRAGMA = "Pragma";

        /// <summary>
        /// Informs the client or server of proxies through which the response / request was sent.
        /// e.g. Via: 1.0 fred, 1.1 example.com (Apache/1.1)
        /// </summary>
        public const String VIA = "Via";

        /// <summary>
        /// A general warning about possible problems with the entity body.
        /// e.g. Warning: 199 Miscellaneous warning
        /// </summary>
        public const String WARNING = "Warning";

        #endregion

        #region Request-Headers

        /// <summary>
        /// Content-Types that are acceptable for the response,
        /// e.g. Accept: text/plain
        /// </summary>
        public const String ACCEPT = "Accept";

        /// <summary>
        /// Character sets that are acceptable,
        /// e.g. Accept-Charset: utf-8
        /// </summary>
        public const String ACCEPT_CHARSET = "Accept-Charset";

        /// <summary>
        /// List of acceptable encodings. See HTTP compression.
        /// e.g. Accept-Encoding: gzip, deflate
        /// </summary>
        public const String ACCEPT_ENCODING = "Accept-Encoding";

        /// <summary>
        /// List of acceptable human languages for response,
        /// e.g. Accept-Language: en-US
        /// </summary>
        public const String ACCEPT_LANGUAGE = "Accept-Language";

        /// <summary>
        /// Acceptable version in time, 
        /// e.g. Accept-Datetime: Thu, 31 May 2007 20:35:00 GMT
        /// </summary>
        public const String ACCEPT_DATETIME = "Accept-Datetime";

        /// <summary>
        /// Authentication credentials for HTTP authentication,
        /// e.g. Authorization: Basic QWxhZGRpbjpvcGVuIHNlc2FtZQ==
        /// </summary>
        public const String AUTHORIZATION = "Authorization";

        /// <summary>
        /// An HTTP cookie previously sent by the server with Set-Cookie (below),
        /// e.g. Cookie: $Version=1; Skin=new;
        /// </summary>
        public const String COOKIE = "Cookie";

        /// <summary>
        /// Indicates that particular server behaviors are required by the client,
        /// e.g. Expect: 100-continue
        /// </summary>
        public const String EXPECT = "Expect";

        /// <summary>
        /// The email address of the user making the request,
        /// e.g. From: user@example.com
        /// </summary>
        public const String FROM = "From";

        /// <summary>
        /// The domain name of the server (for virtual hosting), and the TCP port number on which
        /// the server is listening. The port number may be omitted if the port is the standard
        /// port for the service requested. Mandatory since HTTP/1.1. Although domain name are
        /// specified as case-insensitive, it is not specified whether the contents of the
        /// Host field should be interpreted in a case-insensitive manner and in practice some
        /// implementations of virtual hosting interpret the contents of the Host field in a
        /// case-sensitive manner.
        /// e.g. Host: en.wikipedia.org:80
        /// </summary>
        public const String HOST = "Host";

        /// <summary>
        /// Only perform the action if the client supplied entity matches the same entity on the
        /// server. This is mainly for methods like PUT to only update a resource if it has not
        /// been modified since the user last updated it.
        /// e.g. If-Match: "737060cd8c284d8af7ad3082f209582d"
        /// </summary>
        public const String IF_MATCH = "If-Match";

        /// <summary>
        /// Allows a 304 Not Modified to be returned if content is unchanged,
        /// e.g. If-Modified-Since: Sat, 29 Oct 1994 19:43:31 GMT
        /// </summary>
        public const String IF_MODIFIED_SINCE = "If-Modified-Since";

        /// <summary>
        /// Allows a 304 Not Modified to be returned if content is unchanged, see HTTP ETag,
        /// e.g. If-None-Match: "737060cd8c284d8af7ad3082f209582d"
        /// </summary>
        public const String IF_NONE_MATCH = "If-None-Match";

        /// <summary>
        /// If the entity is unchanged, send me the part(s) that I am missing; otherwise, send
        /// me the entire new entity.
        /// e.g. If-Range: "737060cd8c284d8af7ad3082f209582d"
        /// </summary>
        public const String IF_RANGE = "If-Range";

        /// <summary>
        /// Only send the response if the entity has not been modified since a specific time,
        /// e.g. If-Unmodified-Since: Sat, 29 Oct 1994 19:43:31 GMT
        /// </summary>
        public const String IF_UNMODIFIED_SINCE = "If-Unmodified-Since";

        /// <summary>
        /// Limit the number of times the message can be forwarded through proxies or gateways,
        /// e.g. Max-Forwards: 10
        /// </summary>
        public const String MAX_FORWARDS = "Max-Forwards";

        /// <summary>
        /// Initiates a request for cross-origin resource sharing (asks server for an
        /// 'Access-Control-Allow-Origin' response header),
        /// e.g. Origin: http://www.example-social-network.com
        /// </summary>
        public const String ORIGIN = "Origin";

        /// <summary>
        /// Authorization credentials for connecting to a proxy,
        /// e.g. Proxy-Authorization: Basic QWxhZGRpbjpvcGVuIHNlc2FtZQ==
        /// </summary>
        public const String PROXY_AUTHORIZATION = "Proxy-Authorization";

        /// <summary>
        /// Request only part of an entity. Bytes are numbered from 0.
        /// e.g. Range: bytes=500-999
        /// </summary>
        public const String RANGE = "Range";

        /// <summary>
        /// This is the address of the previous web page from which a link to the currently requested
        /// page was followed. (The word referrer is misspelled in the RFC as well as in most implementations.),
        /// e.g. Referer: http://en.wikipedia.org/wiki/Main_Page
        /// </summary>
        public const String REFERER = "Referer";

        /// <summary>
        /// The transfer encodings the user agent is willing to accept: the same values as for the response
        /// header Transfer-Encoding can be used, plus the "trailers" value (related to the "chunked" transfer
        /// method) to notify the server it expects to receive additional headers (the trailers) after the last,
        /// zero-sized, chunk.	
        /// e.g. TE: trailers, deflate
        /// </summary>
        public const String TE = "TE";

        /// <summary>
        /// Ask the server to upgrade to another protocol.
        /// e.g. Upgrade: HTTP/2.0, SHTTP/1.3, IRC/6.9, RTA/x11
        /// </summary>
        public const String UPGRADE = "Upgrade";

        /// <summary>
        /// The user agent string of the user agent,
        /// e.g. User-Agent: Mozilla/5.0 (X11; Linux x86_64; rv:12.0) Gecko/20100101 Firefox/21.0
        /// </summary>
        public const String USER_AGENT = "User-Agent";

        #endregion

        #region Response-Headers

        /// <summary>
        /// Specifying which web sites can participate in cross-origin resource sharing,
        /// e.g. Access-Control-Allow-Origin: *
        /// </summary>
        public const String ACCESS_CONTROL_ALLOW_ORIGIN = "Access-Control-Allow-Origin";

        /// <summary>
        /// What partial content range types this server supports,
        /// e.g. Accept-Ranges: bytes
        /// </summary>
        public const String ACCEPT_RANGES = "Accept-Ranges";

        /// <summary>
        /// The age the object has been in a proxy cache in seconds,
        /// e.g. Age: 12
        /// </summary>
        public const String AGE = "Age";

        /// <summary>
        /// Valid actions for a specified resource. To be used for a 405 Method not allowed.
        /// e.g. Allow: GET, HEAD
        /// </summary>
        public const String ALLOW = "Allow";

        /// <summary>
        /// The type of encoding used on the data. See HTTP compression.
        /// e.g. Content-Encoding: gzip
        /// </summary>
        public const String CONTENT_ENCODING = "Content-Encoding";

        /// <summary>
        /// The language the content is in,
        /// e.g. Content-Language: da
        /// </summary>
        public const String CONTENT_LANGUAGE = "Content-Language";

        /// <summary>
        /// An alternate location for the returned data
        /// Content-Location: /index.htm
        /// </summary>
        public const String CONTENT_LOCATION = "Content-Location";

        /// <summary>
        /// An opportunity to raise a "File Download" dialogue box for a known MIME type with
        /// binary format or suggest a filename for dynamic content. Quotes are necessary with
        /// special characters. 
        /// e.g. Content-Disposition: attachment; filename="fname.ext"
        /// </summary>
        public const String CONTENT_DISPOSITION = "Content-Disposition";

        /// <summary>
        /// Where in a full body message this partial message belongs,
        /// e.g. Content-Range: bytes 21010-47021/47022
        /// </summary>
        public const String CONTENT_RANGE = "Content-Range";

        /// <summary>
        /// An identifier for a specific version of a resource, often a message digest,
        /// e.g. ETag: "737060cd8c284d8af7ad3082f209582d"
        /// </summary>
        public const String ETAG = "ETag";

        /// <summary>
        /// Gives the date/time after which the response is considered stale,
        /// e.g. Expires: Thu, 01 Dec 1994 16:00:00 GMT
        /// </summary>
        public const String EXPIRES = "Expires";

        /// <summary>
        /// The last modified date for the requested object, in RFC 2822 format
        /// e.g. Last-Modified: Tue, 15 Nov 1994 12:45:26 +0000
        /// </summary>
        public const String LAST_MODIFIED = "Last-Modified";

        /// <summary>
        /// Used to express a typed relationship with another resource, where the relation type is
        /// defined by RFC 5988
        /// e.g. Link: &lt;/feed&gt;; rel="alternate"
        /// </summary>
        public const String LINK = "Link";

        /// <summary>
        /// Used in redirection, or when a new resource has been created.
        /// e.g. Location: http://www.w3.org/pub/WWW/People.html
        /// </summary>
        public const String LOCATION = "Location";

        /// <summary>
        /// This header is supposed to set P3P policy, in the form of P3P:CP="your_compact_policy".
        /// However, P3P did not take off, most browsers have never fully implemented it, a lot of
        /// websites set this header with fake policy text, that was enough to fool browsers the
        /// existence of P3P policy and grant permissions for third party cookies.
        /// e.g. P3P: CP="This is not a P3P policy! See ... for more info."
        /// </summary>
        public const String P3P = "P3P";

        /// <summary>
        /// Request authentication to access the proxy.
        /// e.g. Proxy-Authenticate: Basic
        /// </summary>
        public const String PROXY_AUTHENTICATE = "Proxy-Authenticate";

        /// <summary>
        /// Used in redirection, or when a new resource has been created. This refresh
        /// redirects after 5 seconds.
        /// e.g. Refresh: 5; url=http://www.w3.org/pub/WWW/People.html
        /// </summary>
        public const String REFRESH = "Refresh";

        /// <summary>
        /// If an entity is temporarily unavailable, this instructs the client to try again
        /// after a specified period of time (seconds).
        /// e.g. Retry-After: 120
        /// </summary>
        public const String RETRY_AFTER = "Retry-After";

        /// <summary>
        /// A name for the server,
        /// e.g. Server: Apache/2.4.1 (Unix)
        /// </summary>
        public const String SERVER = "Server";

        /// <summary>
        /// An HTTP cookie,
        /// e.g. Set-Cookie: UserID=JohnDoe; Max-Age=3600; Version=1
        /// </summary>
        public const String SET_COOKIE = "Set-Cookie";

        /// <summary>
        /// The HTTP status of the response. "Status" is not listed as a registered header. The
        /// "Status-Line" of a "Response" is defined by RFC2616 without any explicit Status: header name.
        /// e.g. Status: 200 OK
        /// </summary>
        public const String STATUS = "Status";

        /// <summary>
        /// A HSTS Policy informing the HTTP client how long to cache the HTTPS only policy and
        /// whether this applies to subdomains.
        /// e.g. Strict-Transport-Security: max-age=16070400; includeSubDomains
        /// </summary>
        public const String STRICT_TRANSPORT_SECURITY = "Strict-Transport-Security";

        /// <summary>
        /// The Trailer general field value indicates that the given set of header fields is present in
        /// the trailer of a message encoded with chunked transfer-coding.
        /// e.g. Trailer: Max-Forwards
        /// </summary>
        public const String TRAILER = "Trailer";

        /// <summary>
        /// The form of encoding used to safely transfer the entity to the user. Currently defined methods
        /// are: chunked, compress, deflate, gzip, identity.	
        /// e.g. Transfer-Encoding: chunked
        /// </summary>
        public const String TRANSFER_ENCODING = "Transfer-Encoding";

        /// <summary>
        /// Tells downstream proxies how to match future request headers to decide whether the cached response can
        /// be used rather than requesting a fresh one from the origin server.
        /// e.g. Vary: *
        /// </summary>
        public const String VARY = "Vary";

        /// <summary>
        /// Indicates the authentication scheme that should be used to access the requested entity.
        /// e.g. WWW-Authenticate: Basic
        /// </summary>
        public const String WWW_AUTHENTICATE = "WWW-Authenticate";

        #endregion
    }
}
