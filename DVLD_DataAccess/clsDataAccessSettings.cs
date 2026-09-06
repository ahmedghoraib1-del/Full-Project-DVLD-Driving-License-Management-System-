using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DVLD_DataAccess
{
   public static class clsDataAccessSettings
    {
        //⇣⇣''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''⇣⇣
        //Write your connection string here. Replace YOUR_USER_ID and YOUR_PASSWORD with your actual database credentials.
        //⇣⇣''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''⇣⇣
        //public static string ConnectionString = "Server=.;Database=DVLD;User Id=YOUR_USER_ID;Password=YOUR_PASSWORD;TrustServerCertificate=True";

        public static string ConnectionString =
            "Server=.;Database=DVLD;Integrated Security=True;TrustServerCertificate=True";

    }
}