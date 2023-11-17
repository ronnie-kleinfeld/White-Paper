using System;
using System.Security.AccessControl;
namespace CoreConsoleApp
{
    /// <summary>
    /// struct inherits from System.ValueType by default
    /// see diagram
    /// </summary>
    public struct CardInfo
    {
        public string name { get; set; }
        public CardFamilesEnum CardFamilies { get; set; }
    }

    /// <summary>
    /// struct inherits from System.Enum by default
    /// see diagram
    /// </summary>
    public enum CardFamilesEnum
    {
        Alien,
        Robot,
        Human
    }
}