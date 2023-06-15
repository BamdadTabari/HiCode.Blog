﻿using System.ComponentModel.DataAnnotations;

namespace HC.Shared.Dtos.Identity;

public class LoginRequestDto
{
    [Required]
    public string grant_type { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string refresh_token { get; set; }
    public string scope { get; set; }

    public string client_id { get; set; }
    public string client_secret { get; set; }
}