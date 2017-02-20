﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForumAPI.Models
{
    public enum UserStatus
    {
        Administrator, Moderator, Active, Deactivated, Banned
    }

    /// <summary>
    /// The model for a user. Contains both login information and posting
    /// information.
    /// </summary>
    public class User
    {
        [Key]
        public int ID { get; set; }

        [JsonRequired]
        public string Name { get; set; }
        // Email attribute is checked when the model is created, so there is no
        // required JSON Annotation
        public string Email { get; set; }

        public DateTime Created { get; set; }
        public UserStatus Status { get; set; }
        
        // Passwords must be encrypted for the purpose of security, even if
        // this will not see commercial use.
        [JsonIgnore]
        public string SHA256Password { get; set; }
        
        // A random string attached to the password before encryption.
        [JsonIgnore]
        public string Salt { get; set; }

        [JsonIgnore]
        public int PasswordProtocolVersion { get; set; }

        [Required]
        public bool HasSignature { get; set; }
        public string Signature { get; set; }

        [InverseProperty("Author")] [JsonIgnore]
        public ICollection<Thread> Threads { get; set; }
        [InverseProperty("Author")] [JsonIgnore]
        public ICollection<Post> Posts { get; set; }
    }
}
