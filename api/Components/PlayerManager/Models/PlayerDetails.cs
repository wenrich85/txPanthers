using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace api.Components.PlayerManager
{
    [Table("players")]
    public class PlayerDetails
    {
        [Column("id")]
        public long Id {get; set;}
        
        [Column("member_id")]
        public int MemberId {get; set;}

        [Column("position")]
        public string Position {get; set;}
        
        [Column("jersey_number")]
        public int JerseyNumber {get; set;}
        
        [Column("height")]
        public decimal Height {get; set;}
        
        [Column("weight")]
        public decimal Weight {get; set;}

        [Column("dob")]
        public DateTime DateOfBirth {get; set;}

        [Column("graduation_year")]
        public int GraduationYear {get; set;}

        [Column("current_grade")]
        public int CurrentGrade {get; set;}

    }
}