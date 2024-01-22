namespace TxPanthers.Api.Models;
using System.ComponentModel.DataAnnotations.Schema;

using System.Text.Json.Serialization;

[Table("members")]
public class MemberDetails
{
    [Column("id")]
    public int Id { get; set; }
    [Column("firstname")]
    public string FirstName { get; set; }
    [Column("lastname")]
    public string LastName { get; set; }
    [Column("email")]
    public string Email { get; set; }
    [Column("phone")]
    public string Phone { get; set; }

}