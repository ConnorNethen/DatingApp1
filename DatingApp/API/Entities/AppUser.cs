using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class AppUser
{
    [Key]
    public int Id { get; set; } // since it is 'Id' does not need to be specified as "Key"
    public required string UserName { get; set; }
}
