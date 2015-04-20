using System;
using System.Collections.Generic;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for MailCode
/// </summary>
public class MailCode
{
    public static string getCode(string sEmail){
        MD5 md5Hash = MD5.Create();
        // you will want to change this line so that your site doesn't produce the same verification code as another site
        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(sEmail + ":programming.rocks"));
        // Create a new Stringbuilder to collect the bytes 
        // and create a string.
        StringBuilder sBuilder = new StringBuilder();

        // Loop through each byte of the hashed data  
        // and format each one as a hexadecimal string. 
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }

        // Return the hexadecimal string. 
        return sBuilder.ToString().Substring(0,4);
    }
}
