using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace EFS.Common.Helper
{
    public static class IpAddressHelper
    {
        /// <summary>
        ///     Detects the client ip address.
        /// </summary>
        /// <returns></returns>
        public static string DetectClientIpAddress()
        {
            var sBuilder = new StringBuilder();
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                IPInterfaceProperties ipInterfaceProperties = networkInterface.GetIPProperties();
                foreach (UnicastIPAddressInformation address in ipInterfaceProperties.UnicastAddresses)
                {
                    if (address.Address.AddressFamily != AddressFamily.InterNetwork)
                    {
                        continue;
                    }
                    if (IPAddress.IsLoopback(address.Address))
                    {
                        continue;
                    }
                    sBuilder.Append(address.Address);
                }
            }

            return sBuilder.ToString();
        }

        /// <summary>
        /// Gets the visitor ip address.
        /// </summary>
        /// <param name="getLan">if set to <c>true</c> [get lan].</param>
        /// <returns></returns>
        //public static string GetVisitorIpAddress(IHttpContextAccessor httpContextAccessor, bool getLan = false)
        //{
        //    string visitorIPAddress = HttpContent.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        //    if (String.IsNullOrEmpty(visitorIPAddress))
        //        visitorIPAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

        //    if (string.IsNullOrEmpty(visitorIPAddress))
        //        visitorIPAddress = HttpContext.Current.Request.UserHostAddress;

        //    if (string.IsNullOrEmpty(visitorIPAddress) || visitorIPAddress.Trim() == "::1")
        //    {
        //        getLan = true;
        //        visitorIPAddress = string.Empty;
        //    }

        //    if (getLan)
        //    {
        //        if (string.IsNullOrEmpty(visitorIPAddress))
        //        {
        //            //This is for Local(LAN) Connected ID Address
        //            string stringHostName = Dns.GetHostName();
        //            //Get Ip Host Entry
        //            IPHostEntry ipHostEntries = Dns.GetHostEntry(stringHostName);
        //            //Get Ip Address From The Ip Host Entry Address List
        //            IPAddress[] arrIpAddress = ipHostEntries.AddressList;

        //            try
        //            {
        //                visitorIPAddress = arrIpAddress[arrIpAddress.Length - 2].ToString();
        //            }
        //            catch
        //            {
        //                try
        //                {
        //                    visitorIPAddress = arrIpAddress[0].ToString();
        //                }
        //                catch
        //                {
        //                    try
        //                    {
        //                        arrIpAddress = Dns.GetHostAddresses(stringHostName);
        //                        visitorIPAddress = arrIpAddress[0].ToString();
        //                    }
        //                    catch
        //                    {
        //                        visitorIPAddress = "127.0.0.1";
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return visitorIPAddress;
        //}
    }
}
