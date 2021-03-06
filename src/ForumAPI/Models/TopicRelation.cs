﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ForumAPI.Models
{
    [Serializable]
    public class TopicRelation
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public Topic Parent { get; set; }

        [Required]
        public Topic Child { get; set; }
    }
}
