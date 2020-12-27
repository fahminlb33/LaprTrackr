using SQLite;
using System;

namespace LaprTrackr.Models
{
    public class EatRecord
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [Indexed]
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public float Calorie { get; set; }
    }
}
