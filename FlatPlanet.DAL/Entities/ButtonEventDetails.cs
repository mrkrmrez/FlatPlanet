namespace FlatPlanet.DAL.Entities
{
using System;
using System.ComponentModel.DataAnnotations;
    public class ButtonEventDetails
    {
        [Key]
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}
