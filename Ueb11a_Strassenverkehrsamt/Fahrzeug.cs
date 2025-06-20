using System.Collections.Generic;

namespace Ueb11a_Strassenverkehrsamt
{
    /// <summary>
    /// Ein Fahrzeug kann ein Auto, Motorrad, Car, LKW, etc. sein
    /// </summary>
    public class Fahrzeug
    {
        /// <summary>
        /// Fahrzeugart: Auto, Motorrad, Car, LKW
        /// </summary>
        public FahrzeugArt Art { get; set; }
        /// <summary>
        /// Marke ist z.B. BMW
        /// </summary>
        public string Marke { get; set; }

        /// <summary>
        /// Typ ist z.B. Golf
        /// </summary>
        public string Typ { get; set; }

        /// <summary>
        /// Rot oder Blau, etc.
        /// </summary>
        public string Farbe { get; set; }

        /// <summary>
        /// Autonummer ohne Kantonszeichen; 607609
        /// </summary>
        public int Kennzeichen { get; set; }

        /// <summary>
        /// 1 Auto hat genau 1 Halter
        /// </summary>
        public Person Halter { get; set; }
    }
}
