using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimulAPI.Models
{/// <summary>
/// Reprezinta o persoana specifica
/// </summary>
    public class Person
    {/// <summary>
    /// Id din SQL - Baza de date
    /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// Numele userului
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// Prenumele userului
        /// </summary>
        public string LastName { get; set; } = "";

    }
}